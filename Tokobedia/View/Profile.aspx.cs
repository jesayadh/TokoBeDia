using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;

namespace Tokobedia.View
{
    public partial class Profile : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }

            emailLabel.Text = ProfileController.getEmail(Session["user"]);
            nameLabel.Text = ProfileController.getName();
            genderLabel.Text = ProfileController.getGender();
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void updateProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Update_Profile.aspx");
        }

        protected void changePasswordButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Change_Password.aspx");
        }
    }
}