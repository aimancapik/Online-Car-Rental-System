using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRent.View.Admin
{
    public partial class Rentals : System.Web.UI.Page
    {
        Models.Function conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn= new Models.Function();
            ShowRents();
        }

        private void ShowRents()
        {
            string Query = "SELECT * from RentTable";
            rentallist.DataSource = conn.GetData(Query);
            rentallist.DataBind();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }
        string plateNumber;
        protected void rentallist_SelectedIndexChanged(object sender, EventArgs e)
        {
            plateNumber = rentallist.SelectedRow.Cells[1].Text;
        }

        private void Updatecar()
        {
            try
            {
                string Status = "Available";
                string Query = "update CarTable set Status = '{0}' where CarPlateNumber = '{1}' ";
                Query = string.Format(Query, Status,rentallist.SelectedRow.Cells[2].Text);
                conn.SetData(Query);
            }
            catch (Exception ex)
            {
                errorMessage.Text = ex.Message;
            }
        }
        private void ReturnCar()
        {
            try
            {
               
                    string Query = "Delete from RentTable where RentId={0}";
                    Query = string.Format(Query, rentallist.SelectedRow.Cells[1].Text);
                    conn.SetData(Query);
                errorMessage.Text = "Car Rented";
                
            }
            catch (Exception ex)
            {
                errorMessage.Text = ex.Message;
            }
        }
        protected void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (rentallist.SelectedRow.Cells[1].Text == "")
                {
                    errorMessage.Text = "Select a Rent";
                }
                else
                {
                    string Query = "set dateformat dmy; INSERT into ReturnTable values ('{0}',{1},cast('{2}' as datetime),{3},{4}) ";
                    Query = String.Format(Query, rentallist.SelectedRow.Cells[2].Text, rentallist.SelectedRow.Cells[3].Text, System.DateTime.Today.Date, tbdelay.Text,tbfine.Text);
                    conn.SetData(Query);
                    Updatecar();
                    ReturnCar();
                    ShowRents();
                    errorMessage.Text = "Car Returned!";
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