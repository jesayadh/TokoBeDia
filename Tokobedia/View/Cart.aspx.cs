using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;
using Tokobedia.Model;

namespace Tokobedia.View
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void listItem(int userID)
        {
            viewCartGrid.DataSource = CartController.listItem(userID);
            viewCartGrid.DataBind();
            LblGTotal.Text = "0";
            for (int i = 0; i < viewCartGrid.Rows.Count; i++)
            {
                LblGTotal.Text = Convert.ToString(double.Parse(LblGTotal.Text) + double.Parse(viewCartGrid.Rows[i].Cells[6].Text));
            }
            if (LblGTotal.Text == "0")
            {
                LblError.Visible = true;
                LblError.Text = "Your Cart is Empty";
            }
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LblError.Visible = false;
                if (Session["user"] == null)
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    if (Insert_CartController.getUserRoleID(Session["user"]))
                    {
                        Response.Redirect("Home.aspx");
                    }
                }
                listItem(ProfileController.getID(Session["user"]));
                List<PaymentType> payment = CartController.getAllPaymentType();
                List<String> paymentIDList = CartController.convert(payment);
                paymentRadioButton.DataSource = paymentIDList;
                paymentRadioButton.DataBind();
            }
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void viewCartGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string cartID = viewCartGrid.Rows[rowIndex].Cells[2].Text;
            Response.Redirect("Update_Cart.aspx?id=" + cartID);
        }

        protected void viewCartGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int cartID = Int32.Parse(viewCartGrid.Rows[rowIndex].Cells[2].Text);

            LblError.Visible = true;
            LblError.Text = CartController.removeCart(cartID);

            listItem(ProfileController.getID(Session["user"]));
        }

        protected void CheckoutButton_Click(object sender, EventArgs e)
        {
            if (LblGTotal.Text == "0")
            {
                LblError.Visible = true;
                LblError.Text = "Your Cart is empty.";
            }
            else if(paymentRadioButton.SelectedIndex == -1)
            {
                LblError.Visible = true;
                LblError.Text = "You must choose any Payment Type";
            }
            else
            {
                CartController.checkoutClicked(((Model.User)Session["user"]).UserID, Int32.Parse(paymentRadioButton.SelectedValue));
                Response.Redirect("View_Transaction_History.aspx");
            }
        }
    }
}