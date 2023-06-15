using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace OnlineCarRent.Models
{
    public class Function
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private DataTable dt;
        private string ConnStr;
        private SqlDataAdapter sda;

        public Function()
        {
            ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\khair\OneDrive\Documents\CarRentalSystemDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            conn = new SqlConnection(ConnStr); 
            cmd= new SqlCommand();
            cmd.Connection = conn;
        }
        public DataTable GetData(string Query)
        {
            dt= new DataTable();
            sda = new SqlDataAdapter(Query,ConnStr);
            sda.Fill(dt);
            return dt;
        }
        public int SetData(string Query) 
        {
            int rcnt =0;
            if(conn.State ==ConnectionState.Closed)
            {
                conn.Open();
            }
            cmd.CommandText= Query;
            rcnt = cmd.ExecuteNonQuery();
            conn.Close();
            return rcnt;
        }
    }
}