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

        public StockTrackingView()
        {
            InitializeComponent();
        }

        private void StockTrackingView_Load(object sender, EventArgs e)
        {

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (nameLbl.Text != null)
            {
                try {
                    con.Open();

                    string sqlstuff = "SELECT * from Products WHERE ProdName = '"+nameLbl.Text+"'";
                    SQLiteCommand com = new SQLiteCommand(sqlstuff, con);

                    SQLiteDataReader read = com.ExecuteReader();

                    while (read.Read() == true) {
                        label1.Text = read.GetString(4);
                        label2.Text = read.GetString(5);
                    }

                    con.Close();
                }
                catch (SQLiteException ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
