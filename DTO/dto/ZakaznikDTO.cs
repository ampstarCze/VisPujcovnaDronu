using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.dto
{
    [FirestoreData]
    public class ZakaznikDTO
    {
        [FirestoreProperty]
        public int id { get; set; }
        [FirestoreProperty]
        public string jmeno { get; set; }
        [FirestoreProperty]
        public string prijmeni { get; set; }
        [FirestoreProperty]
        public DateTime datumNarozeni { get; set; }
        [FirestoreProperty]
        public string adresa { get; set; }
        [FirestoreProperty]
        public string email { get; set; }
        [FirestoreProperty]
        public string telefon { get; set; }
        [FirestoreProperty]
        public Boolean pokutovan { get; set; }

        public ZakaznikDTO(int id, string jmeno, string prijmeni, DateTime datumNarozeni, string adresa , string email, string telefon , bool pokutovan)
        {
            this.id = id;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNarozeni = datumNarozeni;
            this.adresa = adresa;
            this.email = email;
            this.telefon = telefon;
            this.pokutovan = pokutovan;
        }

        public ZakaznikDTO()
        { }

    }
}
