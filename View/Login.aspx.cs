using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRent.View
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Function conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Models.Function();
        }
        public static string CustomerName= "";
        public static int CustomerId;
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AdminRadio.Checked)
            {
                if (UserNameTb.Value == "Admin" && PasswordTb.Value == "Admin")
                {
                    Response.Redirect("Admin/HomePage.aspx");
                }
                else
                {
                    InfoMsg.InnerText = "Invalid Admin!";
                }
            }
            else
            {
                
                string sql = "SELECT CustomerName, CustomerPassword, CustomerId FROM CustomerTable WHERE CustomerName = '{0}' AND CustomerPassword = '{1}' ";
                sql = string.Format(sql, UserNameTb.Value, PasswordTb.Value);
                DataTable dt = conn.GetData(sql);
                if (dt.Rows.Count == 0)
                {
                    InfoMsg.InnerText = "Invalid Customer!";
                }
                else
                {
                    CustomerName = dt.Rows[0][0].ToString();
                    CustomerId = Convert.ToInt32(dt.Rows[0][2].ToString());
                    InfoMsg.InnerText = CustomerId+"||"+CustomerName;
                    Session["CustomerID"] = CustomerId;
                    Response.Redirect("Customer/Cars.aspx");
                   
                }
            }
        }

    }
}