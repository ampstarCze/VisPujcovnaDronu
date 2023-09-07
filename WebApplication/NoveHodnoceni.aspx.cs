using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer.Object;
using PresentationLayer;

namespace WebApplication
{
    public partial class NoveHodnoceni : System.Web.UI.Page
    {
        protected async void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null || Session["username"].Equals(""))
            {
                Response.Write("<script>alert('Nejste přihlášen/a!'); </script>");
                hodnoceniIn.Visible = false;
                poznamkaIn.Visible = false;
                pridatBtn.Visible = false;
            }

            PrihlasenyZakaznik zakaznik = await PrihlasenyZakaznik.GetByMail(Session["mail"].ToString());
            Collection<Vypujcka> vypujckas = await Vypujcka.GetByZakaznikID(zakaznik.id);

            if (validateForm.checkCount(vypujckas, int.Parse(Session["dronID"].ToString())+1) < 1)
            {
                Response.Write("<script>alert('Nelze hodnotit nevypujcený dron.'); </script>");
                hodnoceniIn.Visible = false;
                poznamkaIn.Visible = false;
                pridatBtn.Visible = false;

            }

        }

        protected async void pridatBtn_Click(object sender, EventArgs e)
        {

            string validation = validateForm.checkHodnoceni(poznamkaIn.Text, hodnoceniIn.Text);
            if (validation == "true")
            {
                Hodnoceni hodnoceni = new Hodnoceni
                {
                    idDron = int.Parse(Session["dronID"].ToString())+1,
                    jmenoZakaznika = Session["username"].ToString(),
                    hodnoceni = int.Parse(hodnoceniIn.Text),
                    datum = DateTime.Today,
                    poznamka = poznamkaIn.Text
                };
                await hodnoceni.Pridat();
                Response.Redirect("dron.aspx");             
            }
            else
            {
                Response.Write("<script>alert('Při došlo k chybě. ' + '" + validation +"' ); </script>");
            }

        }
    }
}