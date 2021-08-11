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
using StockProgram.UserControls;

namespace StockProgram
{
    public partial class MainDatabase : Form
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

            //show controls
            AddControls();

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

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenuCall = new StartMenu();
            startMenuCall.Show();
        }

        private void AddControls() {
            EditStockPriceView editstuff = new EditStockPriceView();
            editstuff.Dock = DockStyle.Fill;
            TabPage EditPriceStockPage = new TabPage();
            EditPriceStockPage.Controls.Add(editstuff);
            EditPriceStockPage.Text = "Editing and Calculations";
            UserControls.TabPages.Add(EditPriceStockPage);
            
            StockTrackingView stocktrackstuff = new StockTrackingView();
            stocktrackstuff.Dock = DockStyle.Fill;
            TabPage StockTrackingPage = new TabPage();
            StockTrackingPage.Controls.Add(stocktrackstuff);
            StockTrackingPage.Text = "Stock Tracking";
            UserControls.TabPages.Add(StockTrackingPage);
            
            UpdateDatabaseView updatestuff = new UpdateDatabaseView();
            updatestuff.Dock = DockStyle.Fill;
            TabPage UpdateDatabasePage = new TabPage();
            UpdateDatabasePage.Controls.Add(updatestuff);
            UpdateDatabasePage.Text = "Update Database";
            UserControls.TabPages.Add(UpdateDatabasePage);
        }

        private void stockView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //stockView.CurrentCell = stockView.Rows[0].Cells[0];
            //stockView.Rows[0].Selected = true;
        }

        private void stockView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //string values = stockView.SelectedRows.ToString();
            //MessageBox.Show(values);
            string namecell = stockView.CurrentCell.OwningRow.Cells[1].Value.ToString();
            string pricecell = stockView.CurrentCell.OwningRow.Cells[2].Value.ToString();
            string quantitycell = stockView.CurrentCell.OwningRow.Cells[3].Value.ToString();

            nameTb.Text = namecell;
            priceTb.Text = pricecell;
            quantityTb.Text = quantitycell;
        }
    }
}
