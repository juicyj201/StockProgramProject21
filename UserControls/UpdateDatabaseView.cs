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
    public partial class UpdateDatabaseView : UserControl
    {
        private SQLiteConnection conn = new SQLiteConnection(@"data source=.\StockDatabase.db");

        public UpdateDatabaseView()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UPDATE

            try
            {
                openConn();

                string sql = "insert into products (ProdName, ProdPrice, ProdQuantity, DateOfUse, DateOfPurchase) values(@ProdName, @ProdPrice, @ProdQuantity, @DateOfUse, @DateOfPurchase);";
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
                    MessageBox.Show("No item has been added. Please try again. ");
                }

                closeConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ADD

            try
            {
                openConn();

                string sql = "insert into products (ProdName, ProdPrice, ProdQuantity, DateOfUse, DateOfPurchase) values(@ProdName, @ProdPrice, @ProdQuantity, @DateOfUse, @DateOfPurchase);";
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

        private void openConn() {
            conn.Open();
        }

        private void closeConn() {
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //DELETE

            try
            {
                openConn();

                string sql = "insert into products (ProdName, ProdPrice, ProdQuantity, DateOfUse, DateOfPurchase) values(@ProdName, @ProdPrice, @ProdQuantity, @DateOfUse, @DateOfPurchase);";
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
}
