using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace StockProgram
{
    public partial class Login : Form
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" && textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fiels", "Error");
            }
            else {
                string query = "SELECT * FROM users WHERE email = @textBox1 AND password = @textBox2";
                SQLiteConnection conn = new SQLiteConnection("Data Source = Login.db; Version = 3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@textBox1", textBox1.Text);
                cmd.Parameters.AddWithValue("@textBox2", textBox2.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >0)
                {
                    MessageBox.Show("You are Logged in", "Login successful");
                }
                else
                {
                    MessageBox.Show("Login Failed", "An error occurs");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }   
}
