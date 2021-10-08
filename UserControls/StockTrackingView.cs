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
        private SQLiteConnection con = new SQLiteConnection(@"data source=.\StockDatabase.db");
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

                    string sqlstuff = "SELECT DateOfUse, DateOfPurchase from Products WHERE ProdName = '" + nameLbl.Text + "';";
                    SQLiteCommand com = new SQLiteCommand(sqlstuff, con);

                    SQLiteDataReader read = com.ExecuteReader();

                    read.Read();
                    dateofuse = read.GetString(0);
                    dateofpurch = read.GetString(1);
                    MessageBox.Show(dateofuse);
                    MessageBox.Show(dateofpurch);

                    while (read.Read())
                    {
                        MessageBox.Show(read.GetString(0));
                        MessageBox.Show(read.GetString(1));

                        textBox1.Text += read.GetString(0);
                        textBox2.Text += read.GetString(0);
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
