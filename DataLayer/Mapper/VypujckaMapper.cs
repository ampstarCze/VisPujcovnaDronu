using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Google.Cloud.Firestore;
using DTO.dto;

namespace DataLayer.Mapper
{
    public class VypujckaMapper
    {
        public async Task<Collection<VypujckaDTO>> SelectAll()
        {
            Collection<VypujckaDTO> vypujckas = new Collection<VypujckaDTO>();
            ZakaznikMapper zakaznikMapper = new ZakaznikMapper();

            QuerySnapshot snapshot = await FirestoreDB.SelectAll("vypujcka");
            DronMapper dronMapper = new DronMapper();
            foreach (DocumentSnapshot snap in snapshot)
            {
                VypujckaDTO vypujcka = snap.ConvertTo<VypujckaDTO>();

                vypujcka.zakaznik = await zakaznikMapper.SelectId(vypujcka.idZakaznika);
                vypujcka.dron = dronMapper.SelectID(vypujcka.idDron);

                vypujckas.Add(vypujcka);
            }
            return vypujckas;
        }

        public async Task<VypujckaDTO> SelectId(int id)
        {
            QuerySnapshot snapshots = await FirestoreDB.SelectFilter("vypujcka", "id", id);
            foreach (var snap in snapshots)
            {
                VypujckaDTO vypujcka = snap.ConvertTo<VypujckaDTO>();               
                return vypujcka;
            }
            return default;
        }

        public async Task<Collection<VypujckaDTO>> SelectZakaznikID(int id)
        {
            DronMapper dronMapper = new DronMapper();
            Collection<VypujckaDTO> vypujckas = new Collection<VypujckaDTO>();
            QuerySnapshot snapshots = await FirestoreDB.SelectFilter("vypujcka", "idZakaznika", id);
            foreach (DocumentSnapshot snap in snapshots)
            {
                VypujckaDTO vypujcka = snap.ConvertTo<VypujckaDTO>();
                vypujckas.Add(vypujcka);
            }
            return vypujckas;
        }

        public async Task<bool> Insert(VypujckaDTO vypujcka)
        {
            Dictionary<string, object> item = new Dictionary<string, object>
            {
                { "id", await FirestoreDB.maxID("vypujcka") },
                { "idZakaznika", vypujcka.idZakaznika },
                { "idDron", vypujcka.idDron },
                { "datumVypujceni", vypujcka.datumVypujceni.ToUniversalTime() }
            };
            if (vypujcka.datumVraceni != null && vypujcka.datumVraceni != DateTime.MinValue)
            {             
                item.Add("datumVraceni", vypujcka.datumVraceni.ToUniversalTime());
            }
            item.Add("cenaDen", vypujcka.cenaDen);
            item.Add("zaloha", vypujcka.zaloha);
            item.Add("stavVypujcky", vypujcka.stavVypujcky);
            await FirestoreDB.Insert("vypujcka", item);
            return true;
        }

        public async Task<bool> Update(VypujckaDTO vypujcka)
        {
            Dictionary<string, object> item = new Dictionary<string, object>
            {
                { "id", vypujcka.id },
                { "idZakaznika", vypujcka.idZakaznika },
                { "idDron", vypujcka.idDron },
                { "datumVypujceni", vypujcka.datumVypujceni.ToUniversalTime() },
                { "datumVraceni", vypujcka.datumVraceni.ToUniversalTime() },
                { "cenaDen", vypujcka.cenaDen },
                { "zaloha", vypujcka.zaloha },
                { "stavVypujcky", vypujcka.stavVypujcky }
            };
            await FirestoreDB.Update("vypujcka", item,vypujcka.id);
            return true;
        }


    }
}
