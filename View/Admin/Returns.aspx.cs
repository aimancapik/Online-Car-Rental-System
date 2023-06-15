using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRent.View.Admin
{
    public partial class Returns : System.Web.UI.Page
    {
        Models.Function conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Models.Function();
            ShowReturn();
        }

        private void ShowReturn()
        {
            string Query = "SELECT * from ReturnTable";
            returnlist.DataSource = conn.GetData(Query);
            returnlist.DataBind();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
    }
}