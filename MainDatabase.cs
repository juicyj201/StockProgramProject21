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
    public partial class MainDatabase : Form
    {
        //global variables
        private SQLiteConnection conn {
            get {
                return conn;
            }
            set { 
                new SQLiteConnection(@"data source=database\StockDatabase.sqlite");
            }

        } 
        private DataTable table
        {
            get {
                return table;
            }
            set { new DataTable(); 
            }
        } 

        public MainDatabase()
        {
            InitializeComponent();

            openConnection();
            showStock();
            closeConnection();
        }

        protected void openConnection() { 
            conn.Open();
        }

        protected void closeConnection() {
            conn.Close();
        }

        protected void showStock() { 
            //the command object
            string selectStock = "SELECT* from Products";
            SQLiteCommand selectComm = new SQLiteCommand(selectStock, conn);

            //the adapter
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectComm);
            adapter.Fill(table);

            //actually putting it in the form
            stockView.DataSource = table;
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            //the command object
            string sortStock = "SELECT* from Products ORDER BY ProductId";
            SQLiteCommand sortComm = new SQLiteCommand(sortStock, conn);

            //the adapter
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sortComm);
            adapter.Fill(table);

            //actually putting it in the form
            stockView.DataSource = table;
        }

        private void sortNameBtn_Click(object sender, EventArgs e)
        {
            //the command object
            string sortStock = "SELECT* from Products ORDER BY Name";
            SQLiteCommand sortNameComm = new SQLiteCommand(sortStock, conn);

            //the adapter
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sortNameComm);
            adapter.Fill(table);

            //actually putting it in the form
            stockView.DataSource = table;
        }
    }
}
