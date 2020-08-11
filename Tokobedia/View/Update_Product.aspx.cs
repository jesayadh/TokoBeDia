using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;

namespace Tokobedia.View
{
    public partial class Update_Product : System.Web.UI.Page
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
                if (Update_ProductController.getUserRoleID(Session["user"]))
                {
                    Response.Redirect("Home.aspx");
                }
            }
            LblError.Visible = false;
            if(Request.QueryString["id"] == null)
                Response.Redirect("Home.aspx");
            else
                updateID = Int32.Parse(Request.QueryString["id"]);
                
            currentGrid.DataSource = Update_ProductController.getProductByID(updateID);
            currentGrid.DataBind();
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            int price = Int32.Parse(priceBox.Text.ToString());
            int stock = Int32.Parse(stockBox.Text.ToString());
            LblError.Visible = true;
            
            LblError.Text = Update_ProductController.updateProduct(updateID, name, stock, price);
            
            if (LblError.Text == "Success!")
            { 
                Response.Redirect("View_Product.aspx");
            }
        }
    }
}