using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Tokobedia.View
{
    public partial class Insert_Product : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }else
            { 
                if(Insert_ProductController.getUserRoleID(Session["user"]))
                {
                    Response.Redirect("Home.aspx");
                }
                LblError.Visible = false;
            }
        }
        
        protected void insertButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            int stock = Int32.Parse(stockBox.Text.ToString());
            int price = Int32.Parse(priceBox.Text.ToString());
            int ptID = Int32.Parse(productTypeIDBox.Text.ToString());
            
            LblError.Visible = true;
            LblError.Text = Insert_ProductController.toInsertProduct(name, stock, price, ptID);
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}