using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;

namespace Tokobedia.View
{
    public partial class View_Product : System.Web.UI.Page
    {
        protected void hideButton()
        {
            viewCart.Visible = false;
            insertProductButton.Visible = false;
            viewProductGrid.Columns[0].Visible = false;
            viewProductGrid.Columns[1].Visible = false;
            viewProductGrid.Columns[2].Visible = false;
        }

        protected void showButton()
        {
            insertProductButton.Visible = true;
            viewProductGrid.Columns[1].Visible = true;
            viewProductGrid.Columns[2].Visible = true;
        }
        
        protected void showButtonCart()
        {
            viewCart.Visible = true;
            viewProductGrid.Columns[0].Visible = true;
        }

        protected void listItem()
        {
            viewProductGrid.DataSource = View_ProductController.listItem();
            viewProductGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            hideButton();
            LblError.Visible = false;

            if (Session["user"] != null)
            {
                if (View_ProductController.getUserRoleID(Session["user"]) == 1)
                {
                    showButton();
                }
                if(View_ProductController.getUserRoleID(Session["user"]) == 2)
                {
                    showButtonCart();
                }
            }
            listItem();
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void insertProductButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert_Product.aspx");
        }

        protected void viewProductGrid_RowInserting(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex;
            rowIndex = Convert.ToInt32(e.CommandArgument.ToString());
            string productID = viewProductGrid.Rows[rowIndex].Cells[3].Text;
            Response.Redirect("AddtoCart.aspx?id=" + productID);
        }

        protected void viewProductGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string productID = viewProductGrid.Rows[rowIndex].Cells[3].Text;
            Response.Redirect("Update_Product.aspx?id=" + productID);
        }

        protected void viewProductGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int productID = Int32.Parse(viewProductGrid.Rows[rowIndex].Cells[3].Text);

            LblError.Visible = true; 
            LblError.Text = View_ProductController.removeProduct(productID);
              
            listItem();
        }

        protected void Cart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }

        protected void viewProductGrid_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            int rowIndex = e.NewSelectedIndex;
            string productID = viewProductGrid.Rows[rowIndex].Cells[3].Text;
            Response.Redirect("AddtoCart.aspx?id=" + productID);
        }

        protected void viewProductGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int rowIndex = e.NewEditIndex;
            string productID = viewProductGrid.Rows[rowIndex].Cells[3].Text;
            Response.Redirect("AddtoCart.aspx?id=" + productID);
        }
    }
}