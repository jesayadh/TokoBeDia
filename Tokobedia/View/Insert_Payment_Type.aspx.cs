using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tokobedia.View
{
    public partial class Insert_Payment_Type : System.Web.UI.Page
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
            LabelError.Visible = false;
        }

        protected void S_Button_Click(object sender, EventArgs e)
        {
            int typeID = Int32.Parse(IDBox.Text.ToString());
            string typeName = TypeBox.Text;

            LabelError.Visible = true;
            LabelError.Text = Insert_Payment_TypeController.toInsertPaymentType(typeID, typeName);
        }

        protected void H_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}