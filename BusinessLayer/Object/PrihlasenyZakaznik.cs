using DTO.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Mapper;
using System.Collections.ObjectModel;

namespace BusinessLayer.Object
{
  public class PrihlasenyZakaznik
    {
        public int id { get; set; }
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public DateTime datumNarozeni { get; set; }
        public string adresa { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public bool pokutovan { get; set; }

        public PrihlasenyZakaznik(int id, string jmeno, string prijmeni, DateTime datumNarozeni, string adresa, string email, string telefon, bool pokutovan)
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

        public PrihlasenyZakaznik(ZakaznikDTO zakaznikDTO)
        {
            this.id = zakaznikDTO.id;
            this.jmeno = zakaznikDTO.jmeno;
            this.prijmeni = zakaznikDTO.prijmeni;
            this.datumNarozeni = zakaznikDTO.datumNarozeni;
            this.adresa = zakaznikDTO.adresa;
            this.email = zakaznikDTO.email;
            this.telefon = zakaznikDTO.telefon;
            this.pokutovan = zakaznikDTO.pokutovan;
        }

        public PrihlasenyZakaznik()
        {          
        }

        public ZakaznikDTO toDto() => new ZakaznikDTO(id, jmeno, prijmeni, datumNarozeni, adresa, email, telefon, pokutovan);

        public async Task<bool> Pridat()
        {
            ZakaznikMapper mapper = new ZakaznikMapper();
            ZakaznikDTO dto = this.toDto();
            await mapper.Insert(dto);
            return true;
        }

        public async static Task<Collection<PrihlasenyZakaznik>> GetAll()
        {
            ZakaznikMapper zakaznikMapper = new ZakaznikMapper();
            Collection<ZakaznikDTO> dTOs = await zakaznikMapper.SelectAll();
            Collection<PrihlasenyZakaznik> result = new Collection<PrihlasenyZakaznik>();
            foreach (ZakaznikDTO dTO in dTOs)
            {
                PrihlasenyZakaznik zakaznik = new PrihlasenyZakaznik(dTO);
                result.Add(zakaznik);
            }
            return result;
        }

        public async static Task<PrihlasenyZakaznik> GetByID(int id)
        {
            ZakaznikMapper zakaznikMapper = new ZakaznikMapper();
            ZakaznikDTO dTO = await zakaznikMapper.SelectId(id);          
            return new PrihlasenyZakaznik(dTO);
        }

        public async static Task<PrihlasenyZakaznik> GetByMail(string mail)
        {
            ZakaznikMapper zakaznikMapper = new ZakaznikMapper();
            ZakaznikDTO dTO = await zakaznikMapper.SelectMail(mail);
            return new PrihlasenyZakaznik(dTO);
        }

        public string celeJmeno()
        {
            return jmeno + " " + prijmeni;
        }
    }
}
