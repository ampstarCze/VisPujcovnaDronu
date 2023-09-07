using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pujcovna_dronu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BZobrazDrony_Click(object sender, EventArgs e)
        {
            Form seznamDronu = new SeznamDronu();
            seznamDronu.Show();
        }

        private void BZobrazVypujcky_Click(object sender, EventArgs e)
        {
            Form vypujcky = new SeznamVypujcek();
            vypujcky.Show();
        }

        private void BZobrazZakazniky_Click(object sender, EventArgs e)
        {
            Form zakaznici = new SeznamZakazniku();
            zakaznici.Show();
        }

        private void BZobrazObsluhu_Click(object sender, EventArgs e)
        {

        }
    }
}
