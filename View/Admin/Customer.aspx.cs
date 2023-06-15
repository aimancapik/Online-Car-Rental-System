using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRent.View.Admin
{
    public partial class Customer : System.Web.UI.Page
    {
        Models.Function conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Models.Function();
            ShowCustomer();

        }
        private void ShowCustomer()
        {
            string Query = "SELECT * from CustomerTable";
            customerlist.DataSource = conn.GetData(Query);
            customerlist.DataBind();

        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
    }
}