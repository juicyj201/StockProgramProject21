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
    public partial class Help : Form
    {
        /// <summary>
        /// This is the help form.
        /// If the user needs help figuring out how to use the program, they can go to this form for additional help.
        /// </summary>
        
        public Help()
        {
            InitializeComponent();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //StartMenu startMenuCall = new StartMenu();
            //startMenuCall.Show();
            FormControl.menu2.Show();
        }

        private void ShowHelp() { 
            
        }
    }
}
