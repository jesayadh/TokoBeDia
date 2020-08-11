using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller; 

namespace Tokobedia.View
{
    public partial class Register : System.Web.UI.Page
    {  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            string email = registerEmailBox.Text;
            string name = registerNameBox.Text;
            string password = registerPasswordBox.Text;
            string confirm = registerConfirmPasswordBox.Text;
            string gender = genderListRadioButton.SelectedValue;

            emailLblError.Text = RegisterController.checkEmail(email);
            nameLblError.Text = RegisterController.checkName(name);
            passwordLblError.Text = RegisterController.checkPassword(password);
            confirmLblError.Text = RegisterController.checkConfirm(password, confirm);
            genderLblError.Text = RegisterController.checkGender(gender);

            if (RegisterController.registerComplete(email, name, password, confirm, gender))
            { 
                Response.Redirect("Login.aspx");
            }

        }
    }
}