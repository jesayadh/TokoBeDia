using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller; 

namespace Tokobedia.View
{
    public partial class View_User : System.Web.UI.Page
    { 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            else
            { 
                if (View_UserController.getUserRoleID(Session["user"]))
                {
                    Response.Redirect("Home.aspx");
                }

                LblError.Visible = false;
                userGrid.DataSource = View_UserController.getAllUser();
                userGrid.DataBind();
            }
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void userGrid_RowUpdating(object sender, GridViewUpdateEventArgs e) // change status
        {
            int rowIndex = e.RowIndex; 
            int choosenID = Int32.Parse(userGrid.Rows[rowIndex].Cells[2].Text);

            LblError.Visible = true;
            LblError.Text = View_UserController.changeStatus(Session["user"], choosenID);
             
            if (LblError.Text == "Success!")
            {
                Response.Redirect("View_User.aspx");
            } 
        }

        protected void userGrid_RowEditing(object sender, GridViewEditEventArgs e) // change role
        {
            int rowIndex = e.NewEditIndex; 
            int choosenID = Int32.Parse(userGrid.Rows[rowIndex].Cells[2].Text); 

            LblError.Visible = true;
            LblError.Text = View_UserController.changeRole(Session["user"], choosenID);
              
            if (LblError.Text == "Success!")
            {
                Response.Redirect("View_User.aspx");
            }
        }
    }
}