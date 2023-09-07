using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginMail.Text.Trim() == "user@user.cz" && loginHeslo.Text.Trim() == "user")
            {
                Session["username"] = "Jan Novak";
                Session["mail"] = "user@user.cz";
                Response.Redirect("homepage.aspx");
            }
            else
            { Response.Write("<script>alert('Nesprávné jméno nebo heslo!'); </script>"); }
        }
    }
}