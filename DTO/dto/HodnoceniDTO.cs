using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.dto
{
    [FirestoreData]
    public class HodnoceniDTO
    {

        [FirestoreProperty]
        public int id { get; set; }
        [FirestoreProperty]
        public int idDron { get; set; }
        [FirestoreProperty]
        public string jmenoZakaznika { get; set; }
        [FirestoreProperty]
        public DateTime datum { get; set; }
        [FirestoreProperty]
        public int hodnoceni { get; set; }
        [FirestoreProperty]
        public string poznamka { get; set; }


        public HodnoceniDTO(int id, int idDron, string jmenoZakaznika, DateTime datum, int hodnoceni, string poznamka)
        {
            this.id = id;
            this.idDron = idDron;
            this.jmenoZakaznika = jmenoZakaznika;
            this.datum = datum;
            this.hodnoceni = hodnoceni;
            this.poznamka = poznamka;
        }

        public HodnoceniDTO()
        { }

    }
}
