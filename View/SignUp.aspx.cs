using OnlineCarRent.View.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRent.View
{
    public partial class SignUp : System.Web.UI.Page
    {
        Models.Function conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Models.Function();
        }


        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblName.Text == "" || tbPassword.Text == "" || tbphoneNumber.Text == "" || tbaddress.Text == "")
                {
                    errorMessage.Text = "Missing Information";
                }
                else
                {
                    string name = tblName.Text;
                    string password = tbPassword.Text;
                    string phoneNumber = tbphoneNumber.Text;
                    string address = tbaddress.Text;
                    string Query = "INSERT into CustomerTable values ('{0}','{1}','{2}','{3}') ";
                    Query = String.Format(Query, name, address, phoneNumber,password);
                    conn.SetData(Query);
                    errorMessage.Text = "Your acount successfully been registered!";
                    Response.Redirect("Login.aspx");
                }
            }
            catch (Exception Ex)
            {
                //throw;
                errorMessage.Text = Ex.Message;
            }
        }
    }
}