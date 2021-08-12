using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void maindatabaseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainDatabase mainDatabaseCall = new MainDatabase();
            mainDatabaseCall.Show();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help helpCall = new Help();
            helpCall.Show();
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
            this.Hide();
            AboutBox AboutCall = new AboutBox();
            AboutCall.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settingsCall = new Settings();
            settingsCall.Show();
        }
    }
}
