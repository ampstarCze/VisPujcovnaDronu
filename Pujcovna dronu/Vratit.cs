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
using PresentationLayer;

namespace Pujcovna_dronu
{
    public partial class Vratit : Form
    {
        int ID;
        Vypujcka vypujcka;
        public Vratit(int id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private async void Vratit_Load(object sender, EventArgs e)
        {
            vypujcka = await Vypujcka.GetByID(ID);
            vypujcka.datumVraceni = DateTime.Today;
            vypujcka = dataConverter.vypujckaDetailDate(vypujcka);
            VratCV.Text = vypujcka.id.ToString();
            VratZakJmeno.Text = vypujcka.zakaznik.celeJmeno();
            VratDron.Text = vypujcka.dron.nazev;
            VratZaloha.Text = vypujcka.dron.zaloha.ToString();
            VratBezSlevy.Text = vypujcka.cenaBez().ToString();
            VratPocetDni.Text = vypujcka.rozdilDni().ToString();
            int cenaSleva = await vypujcka.cenaSleva();
            VratSleva.Text = cenaSleva.ToString();

            VratDatumVypujcky.Text = vypujcka.datumVypujceni.Date.ToString("dd/MM/yyyy");
     

            if (vypujcka.stavVypujcky == "Vráceno")
            {
                VratBVrat.Enabled = false;
                VratBVrat.Visible = false;

                if (vypujcka.pokutaUdelna)
                {
                    MessageBox.Show("Byla započtena pokuta! ","Upozornění",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void VratBVrat_Click(object sender, EventArgs e)
        {
            Form form = new PotvrzeniNavratu(vypujcka);
            form.Show();
            this.Close();
        }
    }
}
