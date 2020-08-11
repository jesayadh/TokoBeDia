using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tokobedia.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void buttonAdd(int role_id)
        {
            logButton.Text = "Logout"; 
            viewProfileButton.Visible = true;
            ViewTransactionHistoryButton.Visible = true;
            LblName.Text = HomeController.getUserName(Session["user"]);
            if (role_id == 1)
            {
                viewUserButton.Visible = true;
                insertProductButton.Visible = true;
                updateProductButton.Visible = true;
                viewProductTypeButton.Visible = true;
                insertProductTypeButton.Visible = true;
                updateProductTypeButton.Visible = true;
                viewProductGrid.Visible = false;
                InsertPaymentTypeButton.Visible = true;
                UpdatePaymentTypeButton.Visible = true;
                viewPaymentTypeButton.Visible = true;
            }else
            {
                CartButton.Visible = true;
            }
        }

        protected void buttonRemove()
        {
            LblName.Text = "Guest";
            logButton.Text = "Login";
            viewProfileButton.Visible = false;
            viewUserButton.Visible = false;
            insertProductButton.Visible = false;
            updateProductButton.Visible = false;
            viewProductTypeButton.Visible = false;
            insertProductButton.Visible = false;
            updateProductTypeButton.Visible = false;
            InsertPaymentTypeButton.Visible = false;
            UpdatePaymentTypeButton.Visible = false;
            viewPaymentTypeButton.Visible = false;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                var fill = HomeController.listItemGU();
                viewProductGrid.DataSource = fill;
                viewProductGrid.DataBind();
                buttonRemove();
            }else
            {
                buttonAdd(HomeController.getUserRoleID(Session["user"]));
                var fill = HomeController.listItemGU();
                viewProductGrid.DataSource = fill;
                viewProductGrid.DataBind();
            }
        }

        protected void logButton_Click(object sender, EventArgs e)
        {
            if(logButton.Text == "Logout")
            {
                Session.Abandon();
                HttpCookie cookie = Response.Cookies.Get("user");
                cookie.Expires = DateTime.Now.AddHours(-1);
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void insertProductButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert_Product.aspx");
        }

        protected void viewProductButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Product.aspx");
        }

        protected void viewProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void viewUserButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_User.aspx");
        }

        protected void updateProductButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Product.aspx");
        }

        protected void viewProductTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Product_Type.aspx");
        }

        protected void insertProductTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert_Product_Type.aspx");
        }

        protected void updateProductTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Product_Type.aspx");
        }
         
        protected void cartButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }

        protected void ViewButtonClick(object sender, EventArgs e)
        {
            Response.Redirect("View_Transaction_History.aspx");
        }

        protected void UpdatePaymentTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Payment.aspx");
        }

        protected void InsertPaymentTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert_Payment_Type.aspx");
        }

        protected void viewPaymentTypeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Payment.aspx");
        }
    }
}