using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProgram.UserControls
{
    public partial class StockTrackingView : UserControl
    {
        private SQLiteConnection con = new SQLiteConnection(@"data source=.\StockDatabase.db;");
        private string dateofuse = null, dateofpurch = null;

        public StockTrackingView()
        {
            InitializeComponent();

            textBox1.Text += "Yer";
        }

        private void StockTrackingView_Load(object sender, EventArgs e)
        { 
            //empty
        }

        private void submitbtn_Click1(object sender, EventArgs e)
        {
            if (nameLbl.Text.Length > 0)
            {
                try
                {
                    con.Open();

                    string sqlstuff = "select DateOfUse, DateOfPurchase from Products where ProdName = '@Name'";
                    SQLiteCommand com = new SQLiteCommand(sqlstuff, con);
                    com.Parameters.AddWithValue("@Name", nameLbl.Text);

                    SQLiteDataReader read = com.ExecuteReader();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                    adapter.SelectCommand = com;
                    DataSet dataset = new DataSet();

                    if (read[0].ToString() != null && read[1].ToString() != null)
                    {
                        MessageBox.Show(read[0].ToString());
                        MessageBox.Show(read[1].ToString());

                        textBox1.Text += read[0].ToString();
                        textBox2.Text += read[1].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Well the database didnt load the values and i have no idea why.");
                    }

                    read.Close();
                    con.Close();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
