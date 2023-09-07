using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Default : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            

            try
            {
                if (Session["username"].Equals(""))
                {
                    LogInBtn.Visible = true;              
                    LogOffBtn.Visible = false;
                    Username.Visible = false;
                }

                else
                {
                    LogInBtn.Visible = false;
                    LogOffBtn.Visible = true;
                    Username.Visible = true;
                    Username.Text = Session["username"].ToString();
                }
            }
            catch
            {

            }
        }

        protected void LogInBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void LogOffBtn_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            LogInBtn.Visible = true;
            LogOffBtn.Visible = false;
            Username.Visible = false;
        }
    }
}