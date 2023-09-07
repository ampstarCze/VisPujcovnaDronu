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
    public partial class PotvrzeniNavratu : Form
    {
        Vypujcka vypujcka;

        public PotvrzeniNavratu(Vypujcka vypujcka)
        {
            this.vypujcka = vypujcka;
            InitializeComponent();
        }

        private async void btnAno_Click(object sender, EventArgs e)
        {               
            vypujcka.dron.ZmenaStavu("Volny");
            vypujcka.stavVypujcky = "Vráceno";
            vypujcka.datumVraceni = DateTime.Today;
            await vypujcka.Update();
            // Zavolaní UC 18 - Notifikace zákazníka
            this.Close();
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
