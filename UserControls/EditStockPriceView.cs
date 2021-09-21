using System;
using System.Collections.Generic;
using System.Collections;
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
        private List<int> comboList = new List<int>();

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

            try
            {
                con.Open();
                string stuff = "select ProdId from Products";

                SQLiteCommand cmd = new SQLiteCommand(stuff, con);
                //cmd.CommandText = "select ProdPrice from Products where ProductId='" + cmbx.SelectedItem.ToString() + "'";

                SQLiteDataReader reader = cmd.ExecuteReader();

                int id = 0, price = 0;

                while (reader.Read() == true)
                {
                    if (!cmbx.Items.Contains(comboList))
                    {
                        id = reader.GetInt32(0);

                        cmbx.Items.Add(id);

                        if (cmbx.Items.Contains(id))
                        {
                            string pricestuff = "select ProdPrice from Products where ProdId = @ProdId";
                            SQLiteCommand pricecmd = new SQLiteCommand(pricestuff, con);
                            pricecmd.Parameters.AddWithValue("@ProdId", cmbx.Items.Contains(id));
                            SQLiteDataReader reader2 = pricecmd.ExecuteReader();
                            while (reader2.Read() == true)
                            {
                                price = reader2.GetInt32(0);
                                txtboxPrice.Text = price.ToString();
                            }
                        }
                    }
                }

                for (int i = 0; i <= cmbx.MaxLength; i++) {
                    comboList.Add(cmbx.Items.IndexOf(i));
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

        private void cmblistId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string stuff = "select ProdId from Products";

                SQLiteCommand cmd = new SQLiteCommand(stuff, con);
                //cmd.CommandText = "select ProdPrice from Products where ProductId='" + cmbx.SelectedItem.ToString() + "'";

                SQLiteDataReader reader = cmd.ExecuteReader();

                int id, price;

                while (reader.Read() == true) {
                    id = reader.GetInt32(0);
                    
                    cmbx.Items.Add(id);

                    if (cmbx.Items.Contains(id)) {
                        string pricestuff = "select ProdPrice from Products where ProdId = @ProdId";
                        SQLiteCommand pricecmd = new SQLiteCommand(pricestuff, con);
                        pricecmd.Parameters.AddWithValue("@ProdId", cmbx.Items.Contains(id));
                        SQLiteDataReader reader2 = pricecmd.ExecuteReader();
                        while (reader2.Read() == true) {
                            price = reader2.GetInt32(0);
                            txtboxPrice.Text = price.ToString();
                        }
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

        private void txtboxPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
