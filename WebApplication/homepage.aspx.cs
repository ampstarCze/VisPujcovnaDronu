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
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Collection<Dron> drons = Dron.GetAll();
                GridView1.DataSource = drons;
                GridView1.DataBind();
            }
        }

        protected void dronBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;
            int id = row.RowIndex;
            Session["dronID"] = id.ToString();
            Response.Redirect("dron.aspx");
        }
    }
}