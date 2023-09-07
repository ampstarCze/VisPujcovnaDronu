using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.dto
{
    public class DronDTO
    {
        public int idDron { get; set; }
        public string nazev { get; set; }
        public string kategorie { get; set; }
        public int rychlost { get; set; }
        public int dobaLetu { get; set; }
        public int pocetVrtuli { get; set; }
        public int cenaDen { get; set; }
        public int zaloha { get; set; }
        public string stav { get; set; }

        public DronDTO(int idDron, string nazev, string kategorie, int rychlost, int dobaLetu, int pocetVrtuli, int cenaDen, int zaloha, string stav)
        {
            this.idDron = idDron;
            this.nazev = nazev;
            this.kategorie = kategorie;
            this.rychlost = rychlost;
            this.dobaLetu = dobaLetu;
            this.pocetVrtuli = pocetVrtuli;
            this.cenaDen = cenaDen;
            this.zaloha = zaloha;
            this.stav = stav;
        }

        public DronDTO()
        { }
    }
}
