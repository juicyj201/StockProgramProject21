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
        private SQLiteConnection con = new SQLiteConnection(@"data source=.\StockDatabase.db; Version = 3;");

        public StockTrackingView()
        {
            InitializeComponent();
        }

        private void StockTrackingView_Load(object sender, EventArgs e)
        {
           
        }

        private void submitbtn_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void submitbtn_Click1(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                //string sqlstuff = "SELECT * from Products WHERE ProdName = '" + nameLbl.Text + "'";
                string sqlstuff = "SELECT * from Products WHERE ProdName = @ProdName";
                SQLiteCommand com = new SQLiteCommand(sqlstuff, con);

                com.Parameters.AddWithValue("@ProdName", nameLbl.Text);

                SQLiteDataReader read = com.ExecuteReader();

                while (read.Read() == true)
                {
                    string dateofuse = (string)read["DateOfUse"].ToString();
                    string dateofpurch = (string)read["DateOfPurchase"].ToString();
                    label1.Text = dateofuse;
                    label2.Text = dateofpurch;

                    /**
                    string use = read.GetString(4);
                    string purch = read.GetString(5);
                    label1.Text = use;
                    label2.Text = purch;
                    //label1.Text = read.GetString(4);
                    //label2.Text = read.GetString(5);
                    **/
                }

                con.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
