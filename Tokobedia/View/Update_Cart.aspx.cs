using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;

namespace Tokobedia.View
{
    public partial class Update_Cart : System.Web.UI.Page
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
                if (Update_CartController.getUserRoleID(Session["user"]))
                {
                    Response.Redirect("Home.aspx");
                }
            }
            LblError.Visible = false;
            if (Request.QueryString["id"] == null)
                Response.Redirect("Home.aspx");
            else
                updateID = Int32.Parse(Request.QueryString["id"]);

            currentGrid.DataSource = Update_CartController.getCartByID(updateID);
            currentGrid.DataBind();
        }

        protected void updateCartButton_Click(object sender, EventArgs e)
        {
            int quantity = Int32.Parse(quantityBox.Text.ToString());
            LblError.Visible = true;
            int stock = Insert_CartController.getStock(Update_CartController.getProductID(updateID));
            LblError.Text = Update_CartController.updateCart(updateID, stock, quantity);

            if (LblError.Text == "Success!")
            {
                Response.Redirect("Cart.aspx");
            }
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}