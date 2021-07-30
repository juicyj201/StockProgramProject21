using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

// a test form that will allow us to see how the main database works and if it works

namespace StockProgram
{
    public partial class TestForm : Form
    {
        private SQLiteConnection conn;
        // new SQLiteConnection(@"Data source=.\TestDatabase.db");
        private SQLiteCommand comm;
        private SQLiteDataAdapter adapter;
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

            LoadData();

            AddData();
            
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
            adapter = new SQLiteDataAdapter(CommandText, conn);
            set.Reset();
            adapter.Fill(set);
            table = set.Tables[0];
            dataGridView1.DataSource = table;
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



        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenuCall = new StartMenu();
            startMenuCall.Show();
        }
    }
}
