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
using System.IO;

namespace StockProgram.UserControls
{
    public partial class StockTrackingView : UserControl
    {
        private SQLiteConnection con = new SQLiteConnection(@"data source=.\StockDatabase.db;");
        private string dateofuse = null, dateofpurch = null;
        string name;

        public StockTrackingView()
        {
            InitializeComponent();
        }

        private void StockTrackingView_Load(object sender, EventArgs e)
        {
                try
                {
                    con.Open();
                    string sqlstuff = "select ProdName from Products";

                    SQLiteCommand cmd = new SQLiteCommand(sqlstuff, con);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read() == true)
                    {
                        name = reader.GetString(0);
                        nameCb.Items.Add(name);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
        }

        private void nameCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlstuff = "select DateOfUse, DateOfPurchase from Products where ProdName = '" + nameCb.SelectedItem + "' and DateOfUse is not null and DateOfPurchase is not null;";

                SQLiteCommand cmd = new SQLiteCommand(sqlstuff, con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    dateofuse = reader.GetString(0);
                    textBox1.Text = dateofuse.ToString();

                    dateofpurch = reader.GetString(1);
                    textBox2.Text = dateofpurch.ToString();
                }

                con.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void submitbtn_Click1(object sender, EventArgs e)
        {
            /**
            if (nameLbl.Text.Length > 0)
            {
                try
                {
                    con.Open();

                    string sqlstuff = "select DateOfUse, DateOfPurchase from Products where ProdName = '@Name'";
                    SQLiteCommand com = new SQLiteCommand(sqlstuff, con);
                    com.Parameters.AddWithValue("@Name", nameLbl.Text);

                    SQLiteDataReader read = com.ExecuteReader();

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
            **/
        }
    }
}
