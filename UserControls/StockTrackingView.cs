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

            label1.Text = "";
            label2.Text = "";
        }

        private void StockTrackingView_Load(object sender, EventArgs e)
        {

        }

        private void submitbtn_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void submitbtn_Click1(object sender, EventArgs e)
        {
            if (nameLbl.Text != null)
            {
                try
                {
                    con.Open();

                    string sqlstuff = "SELECT DateOfUse from Products WHERE ProdName = '" + nameLbl.Text + "'";
                    SQLiteCommand com = new SQLiteCommand(sqlstuff, con);

                    SQLiteDataReader read = com.ExecuteReader();
                    
                    var type = read.GetFieldType(0);

                    if (type.ToString() != null) {
                        while (read.Read() == true)
                        {
                            string dateofuse = read.GetString(0);
                            string dateofpurch = read.GetString(1);

                            label1.Text = dateofuse;
                            label2.Text = dateofpurch;
                        }
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
}
