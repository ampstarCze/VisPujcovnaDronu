using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.dto
{
    public class ObsluhaDTO
    {
        public int idObsluha { get; set; }
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public DateTime datumNarozeni { get; set; }
        public string adresa { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }


        public ObsluhaDTO(int idObsluha,  string jmeno, string prijmeni, DateTime datumNarozeni, string adresa, string email, string telefon)
        {
            this.idObsluha = idObsluha;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNarozeni = datumNarozeni;
            this.adresa = adresa;
            this.email = email;
            this.telefon = telefon;
        }

        public ObsluhaDTO()
        { }
    }

}
