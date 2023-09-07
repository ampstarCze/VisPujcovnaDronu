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
    public partial class Vypujcit : Form
    {
        int idDron;
        int zakaznikID;
        private Vypujcka vypujcka;

        public Vypujcit(int idDron, int zakaznikID)
        {
            this.idDron = idDron;
            this.zakaznikID = zakaznikID;

            InitializeComponent();
        }

        private async void Vypujcit_Load(object sender, EventArgs e)
        {
            vypujcka = new Vypujcka();
            PrihlasenyZakaznik zakaznik = await PrihlasenyZakaznik.GetByID(zakaznikID);
            vypujcka.idZakaznika = zakaznikID;
            vypujcka.zakaznik = zakaznik;
            Dron dron = Dron.GetByID(idDron);
            vypujcka.idDron = idDron;
            vypujcka.dron= dron;
            vypujcka.datumVypujceni = DateTime.Today;
            vypujcka.zaloha = dron.zaloha;
            vypujcka.cenaDen = dron.cenaDen;

            VypujcZakJmeno.Text = vypujcka.zakaznik.celeJmeno();
            VypujcDron.Text = vypujcka.dron.nazev;
            VypujcZaloha.Text = vypujcka.zaloha.ToString();
            VypucjCenaDen.Text = vypujcka.cenaDen.ToString();
            VypujcDatumVypujcky.Text = vypujcka.datumVypujceni.ToString("dd/MM/yyyy");
        }

        private async void VratBVypujcit_Click(object sender, EventArgs e)
        {
            vypujcka.stavVypujcky = "Vypůjčeno";
            Vypujcka tmp = vypujcka;
            await tmp.Pridat();
            Dron dron = vypujcka.dron;
            dron.ZmenaStavu("Půjčený");
            this.Close();
        }
    }
}
