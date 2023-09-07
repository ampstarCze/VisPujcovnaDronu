using DTO.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Mapper;

namespace BusinessLayer.Object
{
    public class Informovat
    {
        public int idInformovat { get; set; }
        public int idDron { get; set; }
        public int idZakaznika { get; set; }


        public Informovat(int idInformovat, int idDron, int idZakaznika)
        {
            this.idInformovat = idInformovat;
            this.idDron = idDron;
            this.idZakaznika = idZakaznika;
        }

        InformovatDTO ToDTO() => new InformovatDTO(idInformovat, idDron, idZakaznika);

        public void Pridat()
        {
            InformovatMapper mapper = new InformovatMapper();
            InformovatDTO dto = this.ToDTO();
            mapper.Insert(dto);
        }

        public Informovat(InformovatDTO informovatDTO)
        {
            this.idInformovat = informovatDTO.idInformovat;
            this.idDron = informovatDTO.idDron;
            this.idZakaznika = informovatDTO.idZakaznika;
        }

        public Informovat()
        { }
    }
}
