using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Object;

namespace Pujcovna_dronu
{
    public partial class DronVypujcen : Form
    {
        int idDron;
        int idZakaznika;

        public DronVypujcen(int idDron, int idZakaznika)
        {
            this.idDron = idDron;
            this.idZakaznika = idZakaznika;

            InitializeComponent();
        }

        private void btnObsazenNe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObsazenAno_Click(object sender, EventArgs e)
        {
            Informovat informovat = new Informovat
            {
                idZakaznika = idZakaznika,
                idDron = idDron
            };
            informovat.Pridat();
            this.Close();
        }
    }
}
