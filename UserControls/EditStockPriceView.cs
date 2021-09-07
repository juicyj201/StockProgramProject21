using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StockProgram.UserControls
{
    // Edit Item Price 
    public partial class EditStockPriceView : UserControl
    // Item will selected by using combobox 
    {
        // Connection String to the Local Database//Replace to your local connection
        public static SqlConnection con = new SqlConnection(@"Data Source=CSLID;Initial Catalog=ProductCombobox;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        // 'con' is the name of our connection string t

        // Constructor
        public EditStockPriceView()
        // Initialize Component
        {
            InitializeComponent();
        }
        private void EditStockPriceView_Load(object sender, EventArgs e)
        {
            DataConnection();
        }

        private void cmblistId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select ProdPrice from [pdr].tProducts where ProductId='" + cmbx.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtboxPrice.Text = (dr["ProdPrice"].ToString());

                }
                con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("SelectIndexCombobox threw an exception", ex);
            }
        }


        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method to connect to the database
        public void DataConnection()
        // code to fetch Id from table to the combobox
        {
        //Connection to the DataBase using SQL-Server

            #region
            cmbx.Items.Clear();
            con.Open();
            SqlCommand myCommand = con.CreateCommand();
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandText = "Select ProductId from [pdr].tProducts ";
            myCommand.ExecuteNonQuery();
            DataTable myDataTable = new DataTable();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(myCommand);
            myDataAdapter.Fill(myDataTable);
            foreach (DataRow dataRow in myDataTable.Rows)
            {
                cmbx.Items.Add(dataRow["ProductId"].ToString());
            }
            con.Close();
            #endregion


        }

        private void ClearRow()
        {
            txtboxPrice.Text = "";
        }

        private void btnEditPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
