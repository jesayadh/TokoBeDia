using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;

namespace Tokobedia.View
{
    public partial class AddtoCart : System.Web.UI.Page
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
                if (Insert_CartController.getUserRoleID(Session["user"]))
                {
                    Response.Redirect("Home.aspx");
                }
            }
            if (Request.QueryString["id"] == null)
                Response.Redirect("Home.aspx");
            else
                updateID = Int32.Parse(Request.QueryString["id"]);

            currentGrid.DataSource = Insert_CartController.getProductByID(updateID);
            currentGrid.DataBind();
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void BtnInsertCart_Click(object sender, EventArgs e)
        {
            int stock = Insert_CartController.getStock(updateID);
            int quantity = 0;
            quantity = Int32.Parse(quantityBox.Text.ToString());
            if (CartController.checkCart(updateID))
            {
                int LastQuantity = Insert_CartController.getQuantity(updateID);
                int newQuantity = LastQuantity + quantity;
                if (newQuantity > stock)
                {
                    QuantityError.Text = "Stock of the product is " + stock + " and in you have add to your cart " + LastQuantity + " pieces";
                }
                else
                {
                    Update_CartController.addQuantity(updateID, LastQuantity + quantity);
                    Response.Redirect("Cart.aspx");
                }
            }
            else
            {
                QuantityError.Text = CartController.checkQuantity(stock, quantity);

                if (CartController.insertCartSuccess(ProfileController.getID(Session["user"]), updateID, stock, quantity))
                {
                    Response.Redirect("Cart.aspx");
                }
            }    
        }
    }
}