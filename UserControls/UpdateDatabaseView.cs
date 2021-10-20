using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProgram.UserControls
{
    public partial class UpdateDatabaseView : UserControl
    {
        private SQLiteConnection conn = new SQLiteConnection(@"data source=.\StockDatabase.db");
        private Thread t;

        public UpdateDatabaseView()
        {
            InitializeComponent();

            //CheckIfItemIsEntered();
        }

        private void CheckIfItemIsEntered() {
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0 && textBox3.Text.Length == 0 && textBox4.Text.Length == 0 && textBox5.Text.Length == 0 && textBox6.Text.Length == 0)
            {
                ResetBtn.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0 && textBox6.Text.Length != 0)
            {
                ResetBtn.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UPDATE
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0 && textBox6.Text.Length > 0)
            {
                try
                {
                    openConn();

                    string sql = "update Products set ProdName = @ProdName, ProdPrice = @ProdPrice, ProdQuantity = @ProdQuantity, DateOfUse = @DateOfUse, DateOfPurchase = @DateOfPurchase where ProdName = @ProdName and ProdPrice = @ProdPrice and ProdQuantity = @ProdQuantity and DateOfUse = @DateOfUse and DateOfPurchase = @DateOfPurchase;";
                    SQLiteCommand comm = new SQLiteCommand(sql, conn);

                    comm.Parameters.AddWithValue("@ProdName", textBox2.Text);
                    comm.Parameters.AddWithValue("@ProdPrice", textBox3.Text);
                    comm.Parameters.AddWithValue("@ProdQuantity", textBox4.Text);
                    comm.Parameters.AddWithValue("@DateOfUse", textBox5.Text);
                    comm.Parameters.AddWithValue("@DateOfPurchase", textBox6.Text);

                    int ok = 0;
                    ok = comm.ExecuteNonQuery();

                    if (ok > 0)
                    {
                        MessageBox.Show("Item successfully updated.");
                    }
                    else
                    {
                        MessageBox.Show("No item has been updated. Please try again. ");
                    }

                    closeConn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void openConn() {
            conn.Open();
        }

        private void closeConn() {
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DELETE
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0 && textBox6.Text.Length > 0) {
                try
                {
                    openConn();

                    string sql = "delete from Products where ProdName = @ProdName and ProdPrice = @ProdPrice and ProdQuantity = @ProdQuantity and DateOfUse = @DateOfUse and DateOfPurchase = @DateOfPurchase;";
                    SQLiteCommand comm = new SQLiteCommand(sql, conn);

                    comm.Parameters.AddWithValue("@ProdName", textBox2.Text);
                    comm.Parameters.AddWithValue("@ProdPrice", textBox3.Text);
                    comm.Parameters.AddWithValue("@ProdQuantity", textBox4.Text);
                    comm.Parameters.AddWithValue("@DateOfUse", textBox5.Text);
                    comm.Parameters.AddWithValue("@DateOfPurchase", textBox6.Text);

                    int ok = 0;
                    ok = comm.ExecuteNonQuery();

                    if (ok > 0)
                    {
                        MessageBox.Show("Item successfully deleted.");
                    }
                    else
                    {
                        MessageBox.Show("No item has been deleted. Please try again. ");
                    }

                    closeConn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0 && textBox6.Text.Length > 0)
            {
                try
                {
                    openConn();

                    string sql = "insert into Products (ProdName, ProdPrice, ProdQuantity, DateOfUse, DateOfPurchase) values (@ProdName, @ProdPrice, @ProdQuantity, @DateOfUse, @DateOfPurchase);";
                    SQLiteCommand comm = new SQLiteCommand(sql, conn);

                    comm.Parameters.AddWithValue("@ProdName", textBox2.Text);
                    comm.Parameters.AddWithValue("@ProdPrice", textBox3.Text);
                    comm.Parameters.AddWithValue("@ProdQuantity", textBox4.Text);
                    comm.Parameters.AddWithValue("@DateOfUse", textBox5.Text);
                    comm.Parameters.AddWithValue("@DateOfPurchase", textBox6.Text);

                    int ok = 0;
                    ok = comm.ExecuteNonQuery();

                    if (ok > 0)
                    {
                        MessageBox.Show("Item successfully added.");
                    }
                    else
                    {
                        MessageBox.Show("No item has been added. Please try again. ");
                    }

                    closeConn();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void UpdateDatabaseView_Load(object sender, EventArgs e)
        {
            //CheckIfItemIsEntered();
        }
    }
}
