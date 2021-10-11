using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockProgram;

namespace StockProgram
{
    public partial class StartMenu : Form
    {
        /// <summary>
        /// This is the menu form that holds all of the buttons for each of the seperate forms.
        /// When the user clicks on a button the form is hidden (and not closed), and a new instance of another form is created and called.
        /// </summary>
 
        public StartMenu()
        {
            InitializeComponent();

            if (logg.loggedGet == true) {
                loginBtn.Enabled = false;
                loginBtn.Visible = false;
            }
        }

        private void maindatabaseBtn_Click(object sender, EventArgs e)
        {
            FormControl.main2.Show();
            this.Hide();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            FormControl.help2.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            this.Dispose();
            Application.Exit();
        }
        private void aboutUsBtn_Click(object sender, EventArgs e)
        {
            FormControl.about2.Show();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            FormControl.register2.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            FormControl.login2.Show();
            this.Hide();
        }

        private void StartMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Close();
            this.Dispose();
            Application.Exit();
        }
    }
}
