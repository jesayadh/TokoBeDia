using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;

namespace Tokobedia.View
{
    public partial class Change_Password : System.Web.UI.Page
    {  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            LblError.Visible = false;
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void changeButton_Click(object sender, EventArgs e)
        { 
            LblError.Visible = true;

            LblError.Text = Change_PasswordController.toChangePassword(Session["user"], oldBox.Text, newBox.Text, confirmBox.Text);
            if(LblError.Text == "Ganti Password berhasil!")
                Response.Redirect("Profile.aspx");
        }
    }
}