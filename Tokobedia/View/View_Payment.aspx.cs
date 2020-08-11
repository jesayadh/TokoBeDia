using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;

namespace Tokobedia.View
{
    public partial class View_Payment : System.Web.UI.Page
    {
        protected void listType()
        {
            PaymentTGV.DataSource = View_Payment_TypeController.listType();
            PaymentTGV.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                if (View_Payment_TypeController.getUserRoleID(Session["user"]))
                {
                    Response.Redirect("Home.aspx");
                }
            }
            listType();
            LblError.Visible = false;
        }
        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void insertTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert_Payment_Type.aspx");
        }

        protected void updateTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Update_Payment_Type.aspx");
        }

        protected void gridPaymentType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string typeName = PaymentTGV.Rows[rowIndex].Cells[3].Text;

            LblError.Visible = true;
            LblError.Text = View_Payment_TypeController.removePayment(typeName);

            listType();
        }

        protected void gridPaymentType_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string updateID = PaymentTGV.Rows[rowIndex].Cells[2].Text;
            Response.Redirect("Update_Payment_Type.aspx?id=" + updateID);
        }

        protected void PaymentTGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}