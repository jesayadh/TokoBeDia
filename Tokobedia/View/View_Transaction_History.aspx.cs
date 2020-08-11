using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;
using Tokobedia.Model;
using Tokobedia.Repository;

namespace Tokobedia.View
{
    public partial class View_Transaction_History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null)
            {
                Response.Redirect("Home.aspx");
            }
            if (UserRepository.getUserRoleID(Session["user"]) == 1)
                transactionReportButton.Visible = true;

            var fill = View_TransactionHistoryController.listTransactionHistory(View_TransactionHistoryController.getUserID(Session["user"]));
            var filter = fill.Select(p => new
            {
                p.HeaderTransaction.TransactionDate,
                p.HeaderTransaction.PaymentType.PaymentTypeName,
                p.Product.Name,
                p.Quantity
            });
            transactionHistoryGrid.DataSource = filter;
            transactionHistoryGrid.DataBind();
            int subtotal = View_TransactionHistoryController.getSubTotal(fill);
            subTotalLbl.Text = subtotal.ToString();
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void transactionReportButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Transaction_Report.aspx");
        }
        

    }
}