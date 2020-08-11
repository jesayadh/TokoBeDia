using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;

namespace Tokobedia.View
{
    public partial class View_Product_Type : System.Web.UI.Page
    {
        protected void listType()
        { 
            gridProductType.DataSource = View_Product_TypeController.listType();
            gridProductType.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                if (View_Product_TypeController.getUserRoleID(Session["user"]))
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
            Response.Redirect("Insert_Product_Type.aspx");
        }

        protected void updateTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Update_Product_Type.aspx");
        }
        
        protected void gridProductType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string typeName = gridProductType.Rows[rowIndex].Cells[3].Text;
            
            LblError.Visible = true;
            LblError.Text = View_Product_TypeController.removeProduct(typeName);

            listType();
        }

        protected void gridProductType_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string updateID = gridProductType.Rows[rowIndex].Cells[2].Text;
            Response.Redirect("Update_Product_Type.aspx?id=" + updateID);
        }
    }
}