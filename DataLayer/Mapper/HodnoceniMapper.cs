using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.dto;
using Google.Cloud.Firestore;

namespace DataLayer.Mapper
{
   public class HodnoceniMapper
    {

        public async Task<Collection<HodnoceniDTO>> SelectByDron(int idDron)
        {
            Collection<HodnoceniDTO> hodnocenis = new Collection<HodnoceniDTO>();

            QuerySnapshot snapshot =  await FirestoreDB.SelectFilter("hodnoceni", "idDron",idDron);           
            foreach (DocumentSnapshot snap in snapshot)
            {
                HodnoceniDTO hodnoceni = snap.ConvertTo<HodnoceniDTO>();
                hodnocenis.Add(hodnoceni);
            }          
            return hodnocenis;
        }

        public async Task<bool> Insert(HodnoceniDTO hodnoceni)
        {
            Dictionary<string, object> item = new Dictionary<string, object>
            {
                { "id", await FirestoreDB.maxID("hodnoceni") },
                { "idDron", hodnoceni.idDron },
                { "jmenoZakaznika", hodnoceni.jmenoZakaznika },
                { "datum", hodnoceni.datum.ToUniversalTime() },
                { "hodnoceni", hodnoceni.hodnoceni },
                { "poznamka", hodnoceni.poznamka }
            };

            await FirestoreDB.Insert("hodnoceni", item);
            return true;
        }


        
    }
}
