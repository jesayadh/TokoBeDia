using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;

namespace Tokobedia.View
{
    public partial class Update_Product_Type : System.Web.UI.Page
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
                if (Update_ProductTypeController.getUserRoleID(Session["user"]))
                {
                    Response.Redirect("Home.aspx");
                }
            }

            LblError.Visible = false;
            if (Request.QueryString["id"] == null)
                Response.Redirect("Home.aspx");
            else
                updateID = Int32.Parse(Request.QueryString["id"]);

            currentGrid.DataSource = Update_ProductTypeController.getProductTypeByID(updateID);
            currentGrid.DataBind();
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            string typeName = typeBox.Text;
            string description = descriptionBox.Text;

            LblError.Visible = true;
            LblError.Text = Update_ProductTypeController.updateProductType(updateID, typeName, description);

            if (LblError.Text == "Success!")
            {
                Response.Redirect("View_Product_Type.aspx");
            }  
        }
    }
}