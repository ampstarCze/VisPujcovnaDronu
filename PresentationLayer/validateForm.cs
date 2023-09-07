using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BusinessLayer.Object;

namespace PresentationLayer
{
    public class validateForm
    {
        public static string checkHodnoceni(string poznamka, string hodnoceni)
        {
            string valid = "true";
            var regex = new Regex("^[a-zA-Z0-9,.@ ]*$");

            if (poznamka == "" || hodnoceni == "")
            {
             
                valid = "Formulář je prázdný."; 
            }
            if (!regex.IsMatch(poznamka))
            {              
                valid = "Formulář obsahuje nepovolené znaky.";
            }

            if (int.Parse(hodnoceni) <= 0 || int.Parse(hodnoceni) > 10)
            {
                valid = "Neplatná hodnota hodnocení.";
            }
            return valid;
        }

        public static int checkCount(Collection<Vypujcka> vypujckas, int dronID)
        {
            int count = 0;
            foreach (Vypujcka vypujcka in vypujckas)
            {
                if (vypujcka.idDron == dronID)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
