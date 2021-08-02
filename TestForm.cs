using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using StockProgram.UserControls;

// a test form that will allow us to see how the main database works and if it works

namespace StockProgram
{
    public partial class TestForm : Form
    {
        private SQLiteConnection conn;
        private SQLiteCommand comm;
        private SQLiteDataAdapter dadapter;
        private DataSet set;
        private DataTable table;


        //private List<Product> product { get; set; }
        //private Product product = new Product();

        public TestForm()
        {
            InitializeComponent();

            //open connection
            CreateConnection();
            OpenConnection();

            //adding the user controls to the tab control
            AddControls();

            //loading the database with data
            LoadData();
            
            //close connection
            CloseConnection();
        }

        //the database connection
        private void CreateConnection() {
            conn = new SQLiteConnection(@"Data source=.\TestDatabase.db");
        }

        private void OpenConnection() {
            conn.Open();
        }

        private void CloseConnection() {
            conn.Close();
        }

        private void AddData() {
            //string AddDataText = "INSERT INTO Products(ProdId) VALUES('"++"')";
            string AddDataText = "INSERT INTO Products(ProdId, ProdName, ProdPrice, ProdQuantity) VALUES(1, 'Sugar', 23, 4)";
            ExecuteQuery(AddDataText);
        }

        private void DeleteData() {
            string DeleteDataText = "DELETE FROM Products WHERE ProdId = 1";
            ExecuteQuery(DeleteDataText);
        }

        //query stuff
        private void ExecuteQuery(string query) {
            comm = conn.CreateCommand();
            comm.CommandText = query;
            comm.ExecuteNonQuery();
        }

        //showing the data from the sqlite database
        private void LoadData() {
            set = new DataSet();
            table = new DataTable();

            comm = conn.CreateCommand();
            string CommandText = "SELECT* from Products";
            dadapter = new SQLiteDataAdapter(CommandText, conn);
            set.Reset();
            dadapter.Fill(set);
            table = set.Tables[0];
            dataGridView1.DataSource = table;
        }

        private void AddControls()
        {
            EditStockPriceView editstuff = new EditStockPriceView();
            editstuff.Dock = DockStyle.Fill;
            TabPage EditPriceStockPage = new TabPage();
            EditPriceStockPage.Controls.Add(editstuff);
            EditPriceStockPage.Name = "Editing and Calculations";
            UserControls.TabPages.Add(EditPriceStockPage);

            StockTrackingView stocktrackstuff = new StockTrackingView();
            stocktrackstuff.Dock = DockStyle.Fill;
            TabPage StockTrackingPage = new TabPage();
            StockTrackingPage.Controls.Add(stocktrackstuff);
            StockTrackingPage.Name = "Stock Tracking";
            UserControls.TabPages.Add(StockTrackingPage);

            UpdateDatabaseView updatestuff = new UpdateDatabaseView();
            updatestuff.Dock = DockStyle.Fill;
            TabPage UpdateDatabasePage = new TabPage();
            UpdateDatabasePage.Controls.Add(updatestuff);
            UpdateDatabasePage.Name = "Update Database";
            UserControls.TabPages.Add(UpdateDatabasePage);
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenuCall = new StartMenu();
            startMenuCall.Show();
        }
    }
}
