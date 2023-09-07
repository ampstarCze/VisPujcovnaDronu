using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.dto;
using DataLayer.Mapper;

namespace BusinessLayer.Object
{
   public class Vypujcka
    {
        public int id { get; set; }
        public int idZakaznika { get; set; }
        public int idDron { get; set; }
        public DateTime datumVypujceni { get; set; }
        public DateTime datumVraceni { get; set; }
        public int cenaDen { get; set; }
        public int zaloha { get; set; }
        public string stavVypujcky { get; set; }

        public Vypujcka(int id, int idZakaznika, int idDron, DateTime datumVypujceni, DateTime datumVraceni, int cenaDen, int zaloha, string stavVypujcky)
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

        public Vypujcka(VypujckaDTO vypujckaDTO)
        {
            this.id = vypujckaDTO.id;
            this.idZakaznika = vypujckaDTO.idZakaznika;
            this.idDron = vypujckaDTO.idDron;
            this.datumVypujceni = vypujckaDTO.datumVypujceni;
            this.datumVraceni = vypujckaDTO.datumVraceni;
            this.cenaDen = vypujckaDTO.cenaDen;
            this.zaloha = vypujckaDTO.zaloha;
            this.stavVypujcky = vypujckaDTO.stavVypujcky;
        }

        public Vypujcka()
        {
        }

        public PrihlasenyZakaznik zakaznik { get; set; }

        public Dron dron { get; set; }

        public bool pokutaUdelna;

        public int rozdilDni()
        {
            if (datumVraceni == DateTime.MinValue)
            {
                datumVraceni = DateTime.Today;
            }

            return (int) datumVraceni.Subtract(datumVypujceni).TotalDays +1;
        }

        public VypujckaDTO toDto() => new VypujckaDTO(id, idZakaznika, idDron, datumVypujceni, datumVraceni, cenaDen, zaloha, stavVypujcky);

        public int cenaBez()
        {
            int finalCena = rozdilDni() * cenaDen;
            finalCena += vypoctiPokutu();
            return finalCena;
        }

        public async Task<bool> Update()
        {
            VypujckaMapper mapper = new VypujckaMapper();
            VypujckaDTO dto = this.toDto();
            await mapper.Update(dto);
            return true;
        }

        public async Task<bool> Pridat()
        {
            VypujckaMapper mapper = new VypujckaMapper();
            VypujckaDTO dto = this.toDto();
            await mapper.Insert(dto);
            return true;
        }

        public async static Task<Collection<Vypujcka>> GetAll()
        {
            VypujckaMapper vypujckaMapper = new VypujckaMapper();
            DronMapper dronMapper = new DronMapper();
            ZakaznikMapper zakaznikMapper = new ZakaznikMapper();
            Collection<VypujckaDTO> dTOs = await vypujckaMapper.SelectAll();
            Collection<Vypujcka> result = new Collection<Vypujcka>();
            foreach (VypujckaDTO dTO in dTOs)
            {
                Vypujcka vypujcka = new Vypujcka(dTO);
                ZakaznikDTO zakaznikDTO = await zakaznikMapper.SelectId(vypujcka.idZakaznika);
                vypujcka.zakaznik = new PrihlasenyZakaznik(zakaznikDTO);
                DronDTO dronDTO = dronMapper.SelectID(vypujcka.idDron);
                vypujcka.dron = new Dron(dronDTO);
                result.Add(vypujcka);
            }
            return result;
        }

        public async static Task<Collection<Vypujcka>> GetByZakaznikID(int id)
        {
            VypujckaMapper vypujckaMapper = new VypujckaMapper();
            DronMapper dronMapper = new DronMapper();
            ZakaznikMapper zakaznikMapper = new ZakaznikMapper();
            Collection<VypujckaDTO> dTOs = await vypujckaMapper.SelectZakaznikID(id);
            Collection<Vypujcka> result = new Collection<Vypujcka>();
            foreach (VypujckaDTO dTO in dTOs)
            {
                Vypujcka vypujcka = new Vypujcka(dTO);
                ZakaznikDTO zakaznikDTO = await zakaznikMapper.SelectId(vypujcka.idZakaznika);
                vypujcka.zakaznik = new PrihlasenyZakaznik(zakaznikDTO);
                DronDTO dronDTO = dronMapper.SelectID(vypujcka.idDron);
                vypujcka.dron = new Dron(dronDTO);
                result.Add(vypujcka);
            }
            return result;
        }

        public async static Task<Vypujcka> GetByID(int id)
        {
            VypujckaMapper vypujckaMapper = new VypujckaMapper();
            DronMapper dronMapper = new DronMapper();
            ZakaznikMapper zakaznikMapper = new ZakaznikMapper();
            VypujckaDTO dTO = await vypujckaMapper.SelectId(id);            
                Vypujcka vypujcka = new Vypujcka(dTO);
                ZakaznikDTO zakaznikDTO = await zakaznikMapper.SelectId(vypujcka.idZakaznika);
                vypujcka.zakaznik = new PrihlasenyZakaznik(zakaznikDTO);
                DronDTO dronDTO = dronMapper.SelectID(vypujcka.idDron);
                vypujcka.dron = new Dron(dronDTO);
            return vypujcka;
        }

        public async Task<int> cenaSleva()
        {
            VypujckaMapper mapper = new VypujckaMapper();
            int finalCena = rozdilDni() * cenaDen;
            int pokuta = vypoctiPokutu();
            if (pokuta <= 0)
            {
                Collection<VypujckaDTO> vypujckas = await mapper.SelectZakaznikID(idZakaznika);
                if (vypujckas.Count >= 2)
                {
                    finalCena -= finalCena / 20;
                }
            }
            else
            {
                finalCena += pokuta;
            }
            return (int) finalCena;
        }

        private int vypoctiPokutu()
        {
            int pokuta = 0;
            if (rozdilDni() > 7)
            {
                pokuta += cenaDen/10;
            }

            if (zakaznik.pokutovan)
            {
                pokuta += pokuta/10;
            }
            if (pokuta > 0)
            {
                pokutaUdelna = true;
            }
            else
            {
                pokutaUdelna = false;
            }

            return pokuta;
        }
    }
}
