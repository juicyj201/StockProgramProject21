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

namespace StockProgram
{
    public partial class StockTracking : Form
    {

        public StockTracking()
        {
            InitializeComponent();

            MainDatabase maindb = new MainDatabase();

            maindb.OpenConnection();
            maindb.ShowStock();
            maindb.CloseConnection();
        }

        
        private void openConnection()
        {
            //conn.Open();
        }

        private void closeConnection()
        {
            //conn.Close();
        }

        private void viewDatabase() { 
            
        }
    }
}
