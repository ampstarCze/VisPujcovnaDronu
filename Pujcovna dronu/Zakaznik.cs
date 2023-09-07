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
    public partial class Zakaznik : Form
    {
        PrihlasenyZakaznik zakaznik;
        int ZakaznikID;

        public Zakaznik(int ZakaznikID)
        {
            this.ZakaznikID = ZakaznikID;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            zakaznik = await PrihlasenyZakaznik.GetByID(ZakaznikID);
            FZakJmeno.Text = zakaznik.jmeno;
            FZakPrijm.Text = zakaznik.prijmeni;
            FZakAdr.Text = zakaznik.adresa;
            FZakEmail.Text = zakaznik.email;
            FZakTel.Text = zakaznik.telefon;
        }

        private void FZakBVypujc_Click(object sender, EventArgs e)
        {
            Form seznamDronu = new SeznamDronu(ZakaznikID);
            seznamDronu.Show();
        }
    }
}
