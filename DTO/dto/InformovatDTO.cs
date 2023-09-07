using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.dto
{
    public class InformovatDTO
    {
        public int idInformovat { get; set; }
        public int idDron { get; set; }
        public int idZakaznika { get; set; }

        public InformovatDTO(int idInformovat, int idDron, int idZakaznika)
        {
            this.idInformovat = idInformovat;
            this.idDron = idDron;
            this.idZakaznika = idZakaznika;
        }

        public InformovatDTO()
        { }
    }
}
