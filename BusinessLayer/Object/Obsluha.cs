using DTO.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Object
{
   public class Obsluha : PrihlasenyZakaznik
    {
        public int idObsluha { get; set; }

        public Obsluha(int idObsluha, string jmeno, string prijmeni, DateTime datumNarozeni, string adresa, string email, string telefon)
        {
            this.idObsluha = idObsluha;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNarozeni = datumNarozeni;
            this.adresa = adresa;
            this.email = email;
            this.telefon = telefon;
        }

        public Obsluha(ObsluhaDTO obsluhaDTO)
        {
            this.idObsluha = obsluhaDTO.idObsluha;
            this.jmeno = obsluhaDTO.jmeno;
            this.prijmeni = obsluhaDTO.prijmeni;
            this.datumNarozeni = obsluhaDTO.datumNarozeni;
            this.adresa = obsluhaDTO.adresa;
            this.email = obsluhaDTO.email;
            this.telefon = obsluhaDTO.telefon;
        }

        public Obsluha()
        { }

    }
}
