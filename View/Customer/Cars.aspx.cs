using OnlineCarRent.View.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRent.View.Customer
{
    public partial class Cars : System.Web.UI.Page
    {
        Models.Function conn;
        string LNumber, RentDate, RetDate;
        int Fees, DPrice, Customer;

        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowCars()
        {
            string st = "Available";
            string Query = "select * from CarTable where Status = '" + st + "' ";
            CarList.DataSource = conn.GetData(Query);
            CarList.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Models.Function();
            ShowCars();
            //CustName.Text = Login.CustomerName;
            
        }
        private void Updatecar()
        {
            try
            {
                string Status = "Booked";
                string Query = "update CarTable set Status = '{0}' where CarPlateNumber = '{1}' ";
                Query = string.Format(Query, Status, CarList.SelectedRow.Cells[1].Text);
                conn.SetData(Query);
                ShowCars();
            }
            catch (Exception ex)
            {
                InfoMsg.InnerText = ex.Message;
            }
        }

        protected void BookBtn_Click(object sender, EventArgs e)
        {
           
            TimeSpan DDays = Convert.ToDateTime(ReturnDate.Value) - DateTime.Today.Date;
            int Days = DDays.Days;
            int DPrice;
            DPrice = Convert.ToInt32(CarList.SelectedRow.Cells[4].Text);
            int Fees = DPrice * Days;

            try
            {
                if (CarList.SelectedRow.Cells[1].Text == "")
                {
                    InfoMsg.InnerText = "Missing Information";
                }
                else
                {
                    string Query = "set dateformat dmy; insert into RentTable values( '{0}' , {1} , cast('{2}' as datetime) , cast('{3}' as datetime) , {4} )";
                    Query = string.Format(Query, CarList.SelectedRow.Cells[1].Text, Session["CustomerID"], System.DateTime.Today.Date, Convert.ToDateTime(ReturnDate.Value), Fees);
                    conn.SetData(Query);
                    Updatecar();
                    ShowCars();
                    InfoMsg.InnerText = "Car Rented";
                }
            }
            catch (Exception ex)
            {
                InfoMsg.InnerText = "||" + ex.Message + "||" + CarList.SelectedRow.Cells[1].Text + "||" + Customer + "||"+ System.DateTime.Today.Date+"||"+ Convert.ToDateTime(ReturnDate.Value) + "||"+Fees;
            }
        }

        protected void CarList_SelectedIndexChanged1(object sender, EventArgs e)
        {
            LNumber = CarList.SelectedRow.Cells[1].Text;
            RentDate = System.DateTime.Today.Date.ToString();
            RetDate = ReturnDate.Value;
            DPrice = Convert.ToInt32(CarList.SelectedRow.Cells[4].Text);
        }
    }
}