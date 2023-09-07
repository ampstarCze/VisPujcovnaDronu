using DTO.dto;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Mapper;
using System.Collections.ObjectModel;

namespace BusinessLayer.Object
{
    public class Hodnoceni
    {
        public int id { get; set; }
        public int idDron { get; set; }
        public string jmenoZakaznika { get; set; }
        public DateTime datum { get; set; }
        public int hodnoceni { get; set; }
        public string poznamka { get; set; }


        public Hodnoceni(int id, int idDron, string jmenoZakaznika, DateTime datum, int hodnoceni, string poznamka)
        {
            this.id = id;
            this.idDron = idDron;
            this.jmenoZakaznika = jmenoZakaznika;
            this.datum = datum;
            this.hodnoceni = hodnoceni;
            this.poznamka = poznamka;
        }

        public Hodnoceni(HodnoceniDTO hodnoceniDTO)
        {
            this.id = hodnoceniDTO.id;
            this.idDron = hodnoceniDTO.idDron;
            this.jmenoZakaznika = hodnoceniDTO.jmenoZakaznika;
            this.datum = hodnoceniDTO.datum;
            this.hodnoceni = hodnoceniDTO.hodnoceni;
            this.poznamka = hodnoceniDTO.poznamka;
        }

        public Hodnoceni()
        { }

        public HodnoceniDTO toDTO() => new HodnoceniDTO(id, idDron, jmenoZakaznika, datum, hodnoceni, poznamka);

        public async Task<bool> Pridat()
        {
            HodnoceniMapper mapper = new HodnoceniMapper();
            HodnoceniDTO dto = this.toDTO();
            await mapper.Insert(dto);
            return true;
        }

        public static async Task<Collection<Hodnoceni>> GetByDronID(int id)
        { 
           HodnoceniMapper mapper = new HodnoceniMapper();
            Collection<HodnoceniDTO> dTOs = await mapper.SelectByDron(id);
            Collection<Hodnoceni> result = new Collection<Hodnoceni>();
            foreach (HodnoceniDTO dTO in dTOs)
            {
                Hodnoceni hodnoceni = new Hodnoceni(dTO);
                result.Add(hodnoceni);
            }
            return result;
        }
    }
}
