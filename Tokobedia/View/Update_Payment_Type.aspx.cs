using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;

namespace Tokobedia.View
{
    public partial class Update_Payment_Type : System.Web.UI.Page
    {
        private int updateID;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                if (Update_Payment_TypeController.getUserRoleID(Session["user"]))
                {
                    Response.Redirect("Home.aspx");
                }
            }
            ErrorLabel.Visible = false;
            if (Request.QueryString["id"] == null)
                Response.Redirect("Home.aspx");
            else
                updateID = Int32.Parse(Request.QueryString["id"]);

            PaymentTGV.DataSource = Update_Payment_TypeController.getPaymentTypeByID(updateID);
            PaymentTGV.DataBind();
        }
            protected void S_Button_Click(object sender, EventArgs e)
            {
            string typeName = PaymentTypeBox.Text;

            ErrorLabel.Visible = true;
            ErrorLabel.Text = Update_Payment_TypeController.updatePaymentType(updateID, typeName);

            if (ErrorLabel.Text == "Success!")
            {
                Response.Redirect("View_Payment.aspx");
            }
        }
    }
}