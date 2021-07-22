using System;
using System.Windows.Forms;

// a test form that will allow us to see how the main database works and if it works

namespace StockProgram
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            //create instance

            MainDatabase maindb = new MainDatabase();
            maindb.OpenConnection();
            maindb.ShowStock();
            maindb.CloseConnection();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenuCall = new StartMenu();
            startMenuCall.Show();
        }
    }
}
