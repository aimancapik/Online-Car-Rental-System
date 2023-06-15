using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRent.View.Admin
{
    public partial class Cars : System.Web.UI.Page
    {
        Models.Function conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new Models.Function();
            ShowCars();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowCars()
        {
            string Query = "SELECT * from CarTable";
            carlist.DataSource = conn.GetData(Query);
            carlist.DataBind();

        }
        protected void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblicenceNum.Text == "" || tbbrandName.Text == "" || tbmodel.Text == "" || tbPrice.Text == "" || tbcolor.Text == "")
                {
                    errorMessage.Text = "Missing Information";
                }
                else
                {
                    string plateNumber = tblicenceNum.Text;
                    string brand = tbbrandName.Text;
                    string model = tbmodel.Text;
                    int price = Convert.ToInt32(tbPrice.Text.ToString());
                    string color = tbcolor.Text;
                    string status = DDAvailability.SelectedValue;
                    string Query = "INSERT into CarTable values ('{0}','{1}','{2}','{3}','{4}','{5}') ";
                    Query = String.Format(Query, plateNumber, brand, model, price, color, status);
                    conn.SetData(Query);
                    ShowCars();
                    errorMessage.Text = "Car information Added!";
                }
            }
            catch (Exception Ex)
            {
                //throw;
                errorMessage.Text = Ex.Message;
            }
        }
        string Key = "";
        protected void carlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblicenceNum.Text = carlist.SelectedRow.Cells[1].Text;
            tbbrandName.Text = carlist.SelectedRow.Cells[2].Text;
            tbmodel.Text = carlist.SelectedRow.Cells[3].Text;
            tbPrice.Text = carlist.SelectedRow.Cells[4].Text;
            tbcolor.Text = carlist.SelectedRow.Cells[5].Text;
            DDAvailability.Text = carlist.SelectedRow.Cells[5].Text;
        }

        protected void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblicenceNum.Text == "")
                {
                    errorMessage.Text = "Missing Information";
                }
                else
                {
                    string plateNumber = tblicenceNum.Text.ToString();
                    string Query = "DELETE from CarTable where CarPlateNumber ='{0}'";
                    Query = String.Format(Query, plateNumber);
                    conn.SetData(Query);
                    ShowCars();
                    errorMessage.Text = "Car information Deleted!";
                }
            }
            catch (Exception Ex)
            {
                //throw;
                errorMessage.Text = Ex.Message;
            }
        }

        protected void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblicenceNum.Text == "" || tbbrandName.Text == "" || tbmodel.Text == "" || tbPrice.Text == "" || tbcolor.Text == "")
                {
                    errorMessage.Text = "Missing Information";
                }
                else
                {
                    string plateNumber = tblicenceNum.Text.ToString();
                    string brand = tbbrandName.Text;
                    string model = tbmodel.Text;
                    int price = Convert.ToInt32(tbPrice.Text.ToString());
                    string color = tbcolor.Text;
                    string status = DDAvailability.SelectedValue;
                    string Query = "UPDATE CarTable set Brand = '{0}', Model = '{1}', Price = {2}, Color = '{3}', Status = '{4}' where CarPlateNumber = '{5}' ";
                    Query = String.Format(Query, brand, model, price, color, status, plateNumber);
                    conn.SetData(Query);

                    errorMessage.Text = "Car information Edited!";
                    ShowCars();
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