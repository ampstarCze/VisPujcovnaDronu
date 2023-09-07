using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Object;

namespace PresentationLayer
{
   public class dataConverter
    {
        public static Collection<Vypujcka> vypujckaDate(Collection<Vypujcka> vypujckas)
        {
            foreach (Vypujcka vypujcka in vypujckas)
            {
                vypujcka.datumVypujceni = vypujcka.datumVypujceni.ToLocalTime();
                if (vypujcka.datumVraceni != DateTime.MinValue)
                {
                    vypujcka.datumVraceni = vypujcka.datumVraceni.ToLocalTime();
                }
            }
            return vypujckas;
        }

        public static Vypujcka vypujckaDetailDate(Vypujcka vypujcka)
        {
            vypujcka.datumVypujceni = vypujcka.datumVypujceni.ToLocalTime();
            if (vypujcka.datumVraceni != DateTime.MinValue)
            {
                vypujcka.datumVraceni = vypujcka.datumVraceni.ToLocalTime();
            }
            return vypujcka;
        }
    }

}
