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
    public partial class MainDatabase : System.Windows.Forms.Form
    {
        //global variables
        private SQLiteConnection conn;
        private DataTable table;

        public MainDatabase()
        {
            InitializeComponent();

            //initialising (or setting) the connection variable as well as the table variable
            SetConn();
            SetTable();

            //open connection to database
            OpenConnection();

            //show stock
            ShowStock();

            //close connection to database
            CloseConnection();
        }

        //methods for opening and closing database
        public void OpenConnection() {
            GetConn().Open();
        }

        public void CloseConnection() {
            GetConn().Close();
        }

        //method for showing the database
        public void ShowStock() {
            //the command object
            string selectStock = "SELECT* from Products";
            SQLiteCommand selectComm = new SQLiteCommand(selectStock, conn);

            //the adapter
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectComm);
            adapter.Fill(table);

            //actually putting it in the form
            stockView.DataSource = table;
        }

        //method for sorting name by product id
        private void sortBtn_Click(object sender, EventArgs e)
        {
            //the command object
            string sortStock = "SELECT* from Products ORDER BY Id";
            SQLiteCommand sortComm = new SQLiteCommand(sortStock, conn);

            //the adapter
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sortComm);
            adapter.Fill(table);

            //actually putting it in the form
            stockView.DataSource = table;
        }

        //method for sorting name alphabetically
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

        //methods for initialising the connection and table variables
        public SQLiteConnection GetConn() {
            return conn;
        }

        private void SetConn() {
            conn = new SQLiteConnection(@"data source=.\StockDatabase.db");
        }

        public DataTable GetTable() {
            return table;
        }

        private void SetTable() {
            table = new DataTable();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        //add method to check items into the stock database
        private void SubmitStockBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(enterIdTb.Text))
            {
                string enterId;
                enterId = enterIdTb.Text;
                SQLiteCommand enterIdComm = new SQLiteCommand("INSERT into Products(Id) VALUES(?)");
                enterIdComm.Parameters.Add(enterId);
                SQLiteDataAdapter enterIdAdpt = new SQLiteDataAdapter(enterIdComm);
                enterIdAdpt.Update(table);
            }
            if (!String.IsNullOrEmpty(enterNameTb.Text))
            {
                string enterName;
                enterName = enterNameTb.Text;
                SQLiteCommand enterNameComm = new SQLiteCommand("INSERT into Products(Name) VALUES(?)");
                enterNameComm.Parameters.Add(enterName);
                SQLiteDataAdapter enterNameAdpt = new SQLiteDataAdapter(enterNameComm);
                enterNameAdpt.Update(table);
            }
            if (!String.IsNullOrEmpty(enterPriceTb.Text))
            {
                string enterPrice;
                enterPrice = enterPriceTb.Text;
                SQLiteCommand enterPriceComm = new SQLiteCommand("INSERT into Products(Price) VALUES(?)");
                enterPriceComm.Parameters.Add(enterPrice);
                SQLiteDataAdapter enterPriceAdpt = new SQLiteDataAdapter(enterPriceComm);
                enterPriceAdpt.Update(table);
            }
            if (!String.IsNullOrEmpty(enterQuantityTb.Text))
            {
                string enterQuant;
                enterQuant = enterQuantityTb.Text;
                SQLiteCommand enterQuantComm = new SQLiteCommand("INSERT into Products(Quantity) VALUES(?)");
                enterQuantComm.Parameters.Add(enterQuant);
                SQLiteDataAdapter enterQuantAdpt = new SQLiteDataAdapter(enterQuantComm);
                enterQuantAdpt.Update(table);
            }
        }
    }
}
