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
        private int loaded = 0;
        int id = 0, price = 0;

        // Connection String to the Local Database//Replace to your local connection
        public static SQLiteConnection con = new SQLiteConnection(@"Data Source=.\StockDatabase.db");
        // 'con' is the name of our connection string t

        // Constructor
        public EditStockPriceView()
        // Initialize Component
        {
            InitializeComponent();

            loaded += 1;
        }
        private void EditStockPriceView_Load(object sender, EventArgs e)
        {
            DataConnection();

            if (loaded == 1) {
                try
                {
                    con.Open();
                    string stuff = "select ProdId from Products";

                    SQLiteCommand cmd = new SQLiteCommand(stuff, con);
                    //cmd.CommandText = "select ProdPrice from Products where ProductId='" + cmbx.SelectedItem.ToString() + "'";

                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read() == true)
                    {
                        id = reader.GetInt32(0);
                        cmbx.Items.Add(id);
                    }

                    /**
                    for (int i = 0; i <= cmbx.MaxLength; i++)
                    {
                        string pricestuff = "select ProdPrice from Products where ProdId = @ProdId";
                        SQLiteCommand pricecmd = new SQLiteCommand(pricestuff, con);
                        pricecmd.Parameters.AddWithValue("@ProdId", cmbx.Items.IndexOf(i));
                        SQLiteDataReader reader2 = pricecmd.ExecuteReader();
                        while (reader2.Read() == true)
                        {
                            price = reader2.GetInt32(0);
                            txtboxPrice.Text = price.ToString();
                        }
                    }
                    **/

                    //Serge's original not working code

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

        private void txtboxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditStockPriceView_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                con.Open();
                string stuff = "select ProdPrice from Products where ProdId = "+cmbx.SelectedItem+"";

                SQLiteCommand cmd = new SQLiteCommand(stuff, con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true) {
                    price = reader.GetInt32(0);
                    txtboxPrice.Text = price.ToString();
                }

                con.Close();
            }
            catch (SQLiteException ex){
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
