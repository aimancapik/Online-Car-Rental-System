using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRent.View.Customer
{
    public partial class PendingRentals : System.Web.UI.Page
    {
        Models.Function Conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Function();
            ShowCars();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowCars()
        {
          //  string Query = "select * from RentTable  ";
          string Query = "select * from RentTable where customer = '" + Session["CustomerID"] + "' ";
            CarList.DataSource = Conn.GetData(Query);
            CarList.DataBind();
        }
    }
}