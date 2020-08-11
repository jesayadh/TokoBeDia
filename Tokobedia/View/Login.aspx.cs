using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller; 

namespace Tokobedia
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Home.aspx");
            }
            
            if (Request.Cookies.Get("user") != null)
            {
                HttpCookie cookie = Request.Cookies.Get("user");
                int ID = int.Parse(cookie.Value);

                if (!IsPostBack)
                { 
                    loginEmailBox.Text = LoginController.getEmail(ID); 
                    loginPasswordBox.Attributes.Add("value", LoginController.getPassword(ID));
                }
            } 
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            string email = loginEmailBox.Text;
            string password = loginPasswordBox.Text;

            LblError.Visible = true;
            LblError.Text = LoginController.checkingInputUser(email, password);

            if (LblError.Text == "Success!")
            {
                Session["user"] = LoginController.toLogin(email, password);
                if (rememberMeCheck.Checked)
                {
                    HttpCookie cookie = new HttpCookie("user", (LoginController.getUserId(email, password)).ToString());
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                else
                { 
                    HttpCookie cookie = Response.Cookies.Get("user");
                    cookie.Expires = DateTime.Now.AddHours(-1);
                }
                Response.Redirect("Home.aspx");
            }
        }
    }
}