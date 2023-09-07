using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.dto
{
    [FirestoreData]
    public class VypujckaDTO
    {
        [FirestoreProperty]
        public int id { get; set; }
        [FirestoreProperty]
        public int idZakaznika { get; set; }
        [FirestoreProperty]
        public int idDron { get; set; }
        [FirestoreProperty]
        public DateTime datumVypujceni { get; set; }
        [FirestoreProperty]
        public DateTime datumVraceni { get; set; }
        [FirestoreProperty]
        public int cenaDen { get; set; }
        [FirestoreProperty]
        public int zaloha { get; set; }
        [FirestoreProperty]
        public string stavVypujcky { get; set; }

        public ZakaznikDTO zakaznik { get; set; }

        public DronDTO dron { get; set; }

        public VypujckaDTO(int id, int idZakaznika, int idDron, DateTime datumVypujceni, DateTime datumVraceni, int cenaDen, int zaloha, string stavVypujcky)
        {
            this.id = id;
            this.idZakaznika = idZakaznika;
            this.idDron = idDron;
            this.datumVypujceni = datumVypujceni;
            this.datumVraceni = datumVraceni;
            this.cenaDen = cenaDen;
            this.zaloha = zaloha;
            this.stavVypujcky = stavVypujcky;
        }

        public VypujckaDTO()
        { }
    }
}
