using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller; 

namespace Tokobedia.View
{
    public partial class Update_Profile : System.Web.UI.Page
    {
        protected void loadBox()
        { 
                emailBox.Text = Update_ProfileController.getEmail(Session["user"]);
                nameBox.Text = Update_ProfileController.getName(Session["user"]);
                genderRadioButton.SelectedIndex = Update_ProfileController.getGender(Session["user"]); 
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }

            LblError.Visible = false;
            if (!IsPostBack)
            {
                loadBox();
            }
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string name = nameBox.Text;
            string gender = genderRadioButton.SelectedValue;

            LblError.Visible = true;
            LblError.Text = Update_ProfileController.toUpdateProfile(Session["user"], email, name, gender);

            if (LblError.Text == "Update User Profile berhasil dilakukan")
                Response.Redirect("Profile.aspx");

        }
    }
}