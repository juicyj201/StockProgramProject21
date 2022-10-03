using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockProgram.UserControls
{
    public partial class UpdateDatabaseView : UserControl
    {
        private SQLiteConnection conn = new SQLiteConnection(@"data source=.\StockDatabase.db");

        //regex
        private Regex regName = new Regex(@"^(\w|\s)+$");
        private Regex regDate = new Regex(@"^(19[0-9][0-9]|2[0-9][0-9][0-9]){0,4}([/- ])([0-9]|1[0-2]){0,2}([/- ])([0-9]|1[0-9]|2[0-9]|3[0-2]){0,2}$");

        public UpdateDatabaseView()
        {
            InitializeComponent();

            //CheckIfItemIsEntered();
        }

        private bool CheckText()
        {
            if (regName.IsMatch(stockBox2.Text) && regDate.IsMatch(stockBox5.Text) && regDate.IsMatch(stockBox6.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CheckIfItemIsEntered() {
            if (stockBox1.Text.Length == 0 && stockBox2.Text.Length == 0 && stockBox3.Text.Length == 0 && stockBox4.Text.Length == 0 && stockBox5.Text.Length == 0 && stockBox6.Text.Length == 0)
            {
                ResetBtn.Enabled = false;
                stockBtn1.Enabled = false;
                stockBtn2.Enabled = false;
                stockBtn3.Enabled = false;
            }
            else if (stockBox1.Text.Length != 0 && stockBox2.Text.Length != 0 && stockBox3.Text.Length != 0 && stockBox4.Text.Length != 0 && stockBox5.Text.Length != 0 && stockBox6.Text.Length != 0)
            {
                ResetBtn.Enabled = true;
                stockBtn1.Enabled = true;
                stockBtn2.Enabled = true;
                stockBtn3.Enabled = true;
            }
        }


        private void openConn()
        {
            conn.Open();
        }

        private void closeConn()
        {
            conn.Close();
        }

        private void stockBtn1_Click_1(object sender, EventArgs e)
        {
            //ADD
            if (stockBox2.Text.Length > 0 && stockBox3.Text.Length > 0 && stockBox4.Text.Length > 0 && stockBox5.Text.Length > 0 && stockBox6.Text.Length > 0 && CheckText())
            {
                try
                {
                    openConn();

                    string sql = "insert into Products (ProdName, ProdPrice, ProdQuantity, DateOfUse, DateOfPurchase) values (@ProdName, @ProdPrice, @ProdQuantity, @DateOfUse, @DateOfPurchase);";
                    SQLiteCommand comm = new SQLiteCommand(sql, conn);

                    comm.Parameters.AddWithValue("@ProdName", stockBox2.Text);
                    comm.Parameters.AddWithValue("@ProdPrice", stockBox3.Text);
                    comm.Parameters.AddWithValue("@ProdQuantity", stockBox4.Text);
                    comm.Parameters.AddWithValue("@DateOfUse", stockBox5.Text);
                    comm.Parameters.AddWithValue("@DateOfPurchase", stockBox6.Text);

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

        private void stockBtn2_Click(object sender, EventArgs e)
        {
            //UPDATE
            if (stockBox2.Text.Length > 0 && stockBox3.Text.Length > 0 && stockBox4.Text.Length > 0 && stockBox5.Text.Length > 0 && stockBox6.Text.Length > 0 && CheckText())
            {
                try
                {
                    openConn();

                    string sql = "update Products set ProdName = @ProdName, ProdPrice = @ProdPrice, ProdQuantity = @ProdQuantity, DateOfUse = @DateOfUse, DateOfPurchase = @DateOfPurchase where ProdName = @ProdName and ProdPrice = @ProdPrice and ProdQuantity = @ProdQuantity and DateOfUse = @DateOfUse and DateOfPurchase = @DateOfPurchase;";
                    SQLiteCommand comm = new SQLiteCommand(sql, conn);

                    comm.Parameters.AddWithValue("@ProdName", stockBox2.Text);
                    comm.Parameters.AddWithValue("@ProdPrice", stockBox3.Text);
                    comm.Parameters.AddWithValue("@ProdQuantity", stockBox4.Text);
                    comm.Parameters.AddWithValue("@DateOfUse", stockBox5.Text);
                    comm.Parameters.AddWithValue("@DateOfPurchase", stockBox6.Text);

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

        private void stockBtn3_Click(object sender, EventArgs e)
        {
            //DELETE
            if (stockBox2.Text.Length > 0 && stockBox3.Text.Length > 0 && stockBox4.Text.Length > 0 && stockBox5.Text.Length > 0 && stockBox6.Text.Length > 0 && CheckText()) {
                try
                {
                    openConn();

                    string sql = "delete from Products where ProdName = @ProdName and ProdPrice = @ProdPrice and ProdQuantity = @ProdQuantity and DateOfUse = @DateOfUse and DateOfPurchase = @DateOfPurchase;";
                    SQLiteCommand comm = new SQLiteCommand(sql, conn);

                    comm.Parameters.AddWithValue("@ProdName", stockBox2.Text);
                    comm.Parameters.AddWithValue("@ProdPrice", stockBox3.Text);
                    comm.Parameters.AddWithValue("@ProdQuantity", stockBox4.Text);
                    comm.Parameters.AddWithValue("@DateOfUse", stockBox5.Text);
                    comm.Parameters.AddWithValue("@DateOfPurchase", stockBox6.Text);

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

        
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            stockBox1.Text = "";
            stockBox2.Text = "";
            stockBox3.Text = "";
            stockBox4.Text = "";
            stockBox5.Text = "";
            stockBox6.Text = "";
        }

        private void UpdateDatabaseView_Load(object sender, EventArgs e)
        {
            //CheckIfItemIsEntered();
        }
    }
}
