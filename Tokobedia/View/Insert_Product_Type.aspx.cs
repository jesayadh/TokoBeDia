using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 

namespace Tokobedia.View
{
    public partial class Insert_Product_Type : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            { 
                if (Insert_Product_TypeController.getUserRoleID(Session["user"]))
                {
                    Response.Redirect("Home.aspx");
                }
            }
            LblError.Visible = false;
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void insertButton_Click(object sender, EventArgs e)
        {
            LblError.Visible = true;
            string typeName = inputTypeNameBox.Text;
            string description = inputDescriptionBox.Text;

            LblError.Text = Insert_Product_TypeController.toInsertProductType(typeName, description);
        }
    }
}