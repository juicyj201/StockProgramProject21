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
    public partial class Settings : Form
    {
        /// <summary>
        /// This is an experimental form, that allows the user to change the colour scheme of the program.
        /// There are only two colour themes currently: White and Black.
        /// (In future, I would like to add more settings and more colour themes to the program)
        /// </summary>

        public Settings()
        {
            InitializeComponent();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormControl.menu2.Show();
        }

        private void blackBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (blackBtn.Checked == true && whiteBtn.Checked == false)
            {
                //settings
                Settings.ActiveForm.BackColor = Color.Black;
                Settings.ActiveForm.ForeColor = Color.White;
                settingsLbl.ForeColor = Color.White;
                colourGb.ForeColor = Color.White;
                blackBtn.ForeColor = Color.White;
                whiteBtn.ForeColor = Color.White;
                returnBtn.ForeColor = Color.White;
                returnBtn.FlatStyle = FlatStyle.Flat;

                /**
                //menu
                StartMenu.ActiveForm.BackColor = Color.Black;
                StartMenu.ActiveForm.ForeColor = Color.White;
                StartMenu.menuLbl2.ForeColor = Color.White;
                StartMenu.mainsdatabaseBtn2.ForeColor = Color.White;
                StartMenu.helpBtn2.ForeColor = Color.White;
                StartMenu.helpBtn2.ForeColor = Color.White;
                StartMenu.aboutUsBtn2.ForeColor = Color.White;
                **/
            }
        }
        private void whiteBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (whiteBtn.Checked == true && blackBtn.Checked == false)
            {
                //settings
                Settings.ActiveForm.BackColor = Color.White;
                Settings.ActiveForm.ForeColor = Color.Black;
                settingsLbl.ForeColor = Color.Black;
                colourGb.ForeColor = Color.Black;
                blackBtn.ForeColor = Color.Black;
                whiteBtn.ForeColor = Color.Black;
                returnBtn.ForeColor = Color.Black;
                returnBtn.FlatStyle = FlatStyle.Flat;

                /**
                //menu
                StartMenu.ActiveForm.BackColor = Color.Black;
                StartMenu.ActiveForm.ForeColor = Color.White;
                StartMenu.menuLbl2.ForeColor = Color.White;
                StartMenu.mainsdatabaseBtn2.ForeColor = Color.White;
                StartMenu.helpBtn2.ForeColor = Color.White;
                StartMenu.helpBtn2.ForeColor = Color.White;
                StartMenu.aboutUsBtn2.ForeColor = Color.White;
                StartMenu.settingsBtn2.ForeColor = Color.White
                **/
            }
        }
    }
}
