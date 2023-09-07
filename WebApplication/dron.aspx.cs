using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer.Object;

namespace WebApplication
{
    public partial class dron : System.Web.UI.Page
    {

        protected async void Page_Load(object sender, EventArgs e)
        {       
            if (!IsPostBack)
            {
                int id = int.Parse(Session["dronID"].ToString());
                id++;
                Dron dron = Dron.GetByID(id);
                nazev.Text = "Název: " + dron.nazev;
                kategorie.Text = "Kategorie: " + dron.kategorie;
                rychlost.Text = "Rychlost: " + dron.rychlost + " Km/h";
                dobaLetu.Text = "Doba letu: " + dron.dobaLetu + " minut";
                pocetVrtuli.Text = "Počet vrtulí: " + dron.pocetVrtuli;
                cenaDen.Text = "Cena na den: " + dron.cenaDen + " Kč";
                zaloha.Text = "Záloha: " + dron.zaloha + " Kč";
                stav.Text = "Stav: " + dron.stav;

                Collection<Hodnoceni> hodnocenis = await Hodnoceni.GetByDronID(id);
                hodnoceniView.DataSource = hodnocenis;
                hodnoceniView.DataBind();
            }
            if (Session["username"] == null || Session["username"].Equals(""))
            {
                pridatHodnoceniBtn.Visible = false;
            }
            else
            {
                pridatHodnoceniBtn.Visible = true;
            }
        }

        protected void pridatHodnoceniBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("NoveHodnoceni.aspx");
        }
    }
}