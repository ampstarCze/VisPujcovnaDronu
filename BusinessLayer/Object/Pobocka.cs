using DTO.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Object
{
   public class Pobocka
    {
        public int idPobocka { get; set; }
        public string nazev { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }

        public Pobocka(int idPobocka, string nazev, string adresa, string telefon)
        {
            this.idPobocka = idPobocka;
            this.nazev = nazev;
            this.adresa = adresa;
            this.telefon = telefon;
        }

        public Pobocka(PobockaDTO pobockaDTO)
        {
            this.idPobocka = pobockaDTO.idPobocka;
            this.nazev = pobockaDTO.nazev;
            this.adresa = pobockaDTO.adresa;
            this.telefon = pobockaDTO.telefon;
        }

        public Pobocka()
        {

        }
    }
}
