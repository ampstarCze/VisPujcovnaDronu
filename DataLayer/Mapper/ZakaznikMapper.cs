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
    public class ZakaznikMapper
    {
        public async Task<Collection<ZakaznikDTO>> SelectAll()
        {
            Collection<ZakaznikDTO> zakazniks = new Collection<ZakaznikDTO>();

            QuerySnapshot snapshot = await FirestoreDB.SelectAll("prihlasenyZakaznik");
            foreach (DocumentSnapshot snap in snapshot)
            {
                ZakaznikDTO zakaznik = snap.ConvertTo<ZakaznikDTO>();
                zakazniks.Add(zakaznik);
            }
            return zakazniks;
        }

        public async Task<ZakaznikDTO> SelectId(int id)
        {
            QuerySnapshot snapshots = await FirestoreDB.SelectFilter("prihlasenyZakaznik", "id", id);
            foreach (var snap in snapshots)
            {
                ZakaznikDTO zakaznik = snap.ConvertTo<ZakaznikDTO>();
                return zakaznik;
            }     
            return default;
        }

        public async Task<ZakaznikDTO> SelectMail(string mail)
        {
            QuerySnapshot snapshots = await FirestoreDB.SelectFilter("prihlasenyZakaznik", "email", mail);
            foreach (var snap in snapshots)
            {
                ZakaznikDTO zakaznik = snap.ConvertTo<ZakaznikDTO>();
                return zakaznik;
            }
            return default;
        }

        public async Task<bool> Insert(ZakaznikDTO zakaznik)
        {
            Dictionary<string, object> item = new Dictionary<string, object>
            {
                { "id", await FirestoreDB.maxID("prihlasenyZakaznik") },
                { "jmeno", zakaznik.jmeno },
                { "prijmeni", zakaznik.prijmeni },
                { "datumNarozeni", zakaznik.datumNarozeni.ToUniversalTime() },
                { "adresa", zakaznik.adresa },
                { "email", zakaznik.email },
                { "telefon", zakaznik.telefon },
                { "pokutovan", zakaznik.pokutovan }
            };
            await FirestoreDB.Insert("prihlasenyZakaznik", item);
            return true;
        }

        public async Task<bool> Update(ZakaznikDTO zakaznik)
        {
            Dictionary<string, object> item = new Dictionary<string, object>
            {
                { "id", zakaznik.id },
                { "jmeno", zakaznik.jmeno },
                { "prijmeni", zakaznik.prijmeni },
                { "datumNarozeni", zakaznik.datumNarozeni },
                { "adresa", zakaznik.adresa },
                { "email", zakaznik.email },
                { "telefon", zakaznik.telefon },
                { "pokutovan", zakaznik.pokutovan }
            };
            await FirestoreDB.Update("prihlasenyZakaznik", item, zakaznik.id);
            return true;
        }                 
    }
}
