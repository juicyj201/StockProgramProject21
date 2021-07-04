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
        public StartMenu()
        {
            InitializeComponent();
        }

        private void maindatabaseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainDatabase mainDatabaseCall = new MainDatabase();
            mainDatabaseCall.Show();
            this.Close();
        }

        private void stockeditingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditPriceStock editStockCall = new EditPriceStock();
            editStockCall.Show();
            this.Close();
        }

        private void stockupdatingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateDatabase updateStockCall = new UpdateDatabase();
            updateStockCall.Show();
            this.Close();
        }

        private void stocktrackingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StockTracking stockTrackingCall = new StockTracking();
            stockTrackingCall.Show();
            this.Close();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            /**
            this.Hide();
            Help helpCall = new Help();
            helpCall.Show();
            this.Close();
            **/
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
