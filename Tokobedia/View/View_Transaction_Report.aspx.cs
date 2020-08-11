using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tokobedia.Controller;
using Tokobedia.Model;
using Tokobedia.Report;

namespace Tokobedia.View
{
    public partial class View_Transaction_Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("Home.aspx");

            if (!View_TransactionReportController.isAdmin(Session["user"]))
                Response.Redirect("Home.aspx");

            TransactionReport report = new TransactionReport();
            TransReport.ReportSource = report;

            LoadReport(report);
        }

        private void LoadReport(TransactionReport report)
        {
            DataSet1 dataset = View_TransactionReportController.getDatasetForReport();
            report.SetDataSource(dataset);
        }
    }
}