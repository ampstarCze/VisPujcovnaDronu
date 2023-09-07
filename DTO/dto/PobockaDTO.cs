using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.dto
{
    public class PobockaDTO
    {
        public int idPobocka { get; set; }
        public string nazev { get; set; }
        public string adresa { get; set; }
        public string telefon { get; set; }

        public PobockaDTO(int idPobocka, string nazev, string adresa, string telefon)
        {
            this.idPobocka = idPobocka;
            this.nazev = nazev;
            this.adresa = adresa;
            this.telefon = telefon;
        }

        public PobockaDTO()
        { }
    }
}
