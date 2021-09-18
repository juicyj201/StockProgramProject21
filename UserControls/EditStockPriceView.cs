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
using System.Data.SQLite;

namespace StockProgram.UserControls
{
    // Edit Item Price 
    public partial class EditStockPriceView : UserControl
    // Item will selected by using combobox 
    {
        // Connection String to the Local Database//Replace to your local connection
        public static SQLiteConnection con = new SQLiteConnection(@"Data Source=.\StockDatabase.db");
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
                string stuff = "select ProdId, ProdPrice from Products";

                SQLiteCommand cmd = new SQLiteCommand(stuff, con);
                //cmd.CommandText = "select ProdPrice from Products where ProductId='" + cmbx.SelectedItem.ToString() + "'";

                SQLiteDataReader reader = cmd.ExecuteReader();

                int id, price, counter = 0; 

                while (reader.Read() == true) {
                    id = reader.GetInt32(0);
                    price = reader.GetInt32(1);
                    counter += 1;
                    cmbx.Items.Add(id);

                    if (cmbx.SelectedItem.Equals(counter))
                    {
                        txtboxPrice.Text = price.ToString();
                    }
                }

                /**
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtboxPrice.Text = (dr["ProdPrice"].ToString());

                }
                **/


                con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("SelectIndexCombobox threw an exception", ex);
            }
        }

        // Method to connect to the database
        public void DataConnection()
        // code to fetch Id from table to the combobox
        {
        //Connection to the DataBase using SQL-Server


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
