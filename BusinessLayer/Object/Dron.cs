using DTO.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Mapper;

namespace BusinessLayer.Object
{
    public class Dron
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

        public Dron()
        { }

        public Dron(int idDron, string nazev, string kategorie, int rychlost, int dobaLetu, int pocetVrtuli, int cenaDen, int zaloha, string stav)
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

        public Dron(DronDTO dronDTO)
        {
            this.idDron = dronDTO.idDron;
            this.nazev = dronDTO.nazev;
            this.kategorie = dronDTO.kategorie;
            this.rychlost = dronDTO.rychlost;
            this.dobaLetu = dronDTO.dobaLetu;
            this.pocetVrtuli = dronDTO.pocetVrtuli;
            this.cenaDen = dronDTO.cenaDen;
            this.zaloha = dronDTO.zaloha;
            this.stav = dronDTO.stav;
        }

        DronDTO ToDTO() => new DronDTO(idDron, nazev, kategorie, rychlost, dobaLetu, pocetVrtuli, cenaDen, zaloha, stav);


        public void ZmenaStavu(string stav)
        {
            DronMapper mapper = new DronMapper();
            DronDTO dto = this.ToDTO();
            mapper.updateStav(dto.idDron, stav);
        }

        public static Collection<Dron> GetAll()
        {
            DronMapper mapper = new DronMapper();
            Collection<DronDTO> dronDTOs = new Collection<DronDTO>();
            dronDTOs = mapper.SelectAll();
            Collection<Dron> result = new Collection<Dron>();
            foreach(DronDTO dTO in dronDTOs)
            {
                Dron dron = new Dron(dTO);
                result.Add(dron);
            }
            return result;
        }

        public static Dron GetByID(int id)
        {
            DronMapper mapper = new DronMapper();
            Dron dron = new Dron(mapper.SelectID(id));
            return dron;
        }

        public bool lzeVypujcit()
        {
            if (stav == "Volny")
            {
                return true;
            }
            return false;
        }
    }
}
