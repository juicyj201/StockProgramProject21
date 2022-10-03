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
using System.Collections;

namespace StockProgram
{
    public partial class MainDatabase : Form
    {
        /// <summary>
        ///     <para>
        ///         These are the global variables for the MainDatabase class
        ///     </para>
        /// </summary>
        private SQLiteConnection conn = new SQLiteConnection(@"data source=.\StockDatabase.db");
        private DataTable table = new DataTable();

        private EditStockPriceView edit;
        private StockTrackingView stocktrack;
        private UpdateDatabaseView updateprod;
        private UpdateCustListView updatecust;

        private ArrayList tablelist = new ArrayList();

        public MainDatabase()
        {
            ///init method call 
            InitializeComponent();

            OpenConnection();
            ShowTables();
            AddControls();
            CloseConnection();
        }

        /// <summary>
        ///     <para>
        ///         These are the methods used for opening and closing the connection to the sqlite database.
        ///     </para>
        /// </summary>
        public void OpenConnection() {
            conn.Open();
        }

        public void CloseConnection() {
            conn.Close();
        }

        /// <summary>
        ///     <para>
        ///         This method is used to retrieve Product table data directly from the sqlite database
        ///     </para>
        /// </summary>
        public void ShowStock() {

            //the command object used to retrieve all the rows in the database
            string selectStock = "select * from Products";
            SQLiteCommand selectComm = new SQLiteCommand(selectStock, conn);

            //the data adapter used to fill the table
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectComm);
            adapter.Fill(table);

            //putting the datagrid in the table
            stockView.DataSource = table;
        }

        /// <summary>
        ///     <para>
        ///         This method is used to retrieve CustomerList table data directly from the sqlite database
        ///     </para>
        /// </summary>
        public void ShowCustList() {

            //the command object used to retrieve all the rows in the database
            string selectCustomer = "select * from CustomerList";
            SQLiteCommand selectComm = new SQLiteCommand(selectCustomer, conn);

            //the data adapter used to fill the table
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectComm);
            adapter.Fill(table);

            //putting the datagrid in the table
            stockView.DataSource = table;
        }

        /// <summary>
        ///     <para>
        ///         This Method is used to show either CustomerList or Product tables respectively        
        ///     </para>
        /// </summary>
        private void ShowTables() {
            //retrieving all the tables from the database
            tablelist.Add("Products");
            tablelist.Add("CustomerList");

            listBox1.Items.Add(tablelist[0]);
            listBox1.Items.Add(tablelist[1]);
        }

        /// <summary>
        ///     <para>
        ///         This is a method used to add the user controls, to the tab control in the MainDatabase form
        ///     </para>
        /// </summary>
        private void AddControls() {
            UserControls.SizeMode = TabSizeMode.FillToRight;
            UserControls.Appearance = TabAppearance.Normal;

            edit = new EditStockPriceView();
            edit.Dock = DockStyle.Fill;
            TabPage EditPriceStockPage = new TabPage();
            EditPriceStockPage.Controls.Add(edit);
            EditPriceStockPage.Text = "Editing and Calculations";
            EditPriceStockPage.ForeColor = Color.White;
            EditPriceStockPage.BackColor = Color.FromArgb(11, 23, 42);
            UserControls.TabPages.Add(EditPriceStockPage);

            stocktrack = new StockTrackingView();
            stocktrack.Dock = DockStyle.Fill;
            TabPage StockTrackingPage = new TabPage();
            StockTrackingPage.Controls.Add(stocktrack);
            StockTrackingPage.Text = "Stock Tracking";
            StockTrackingPage.ForeColor = Color.White;
            StockTrackingPage.BackColor = Color.FromArgb(11, 23, 42);
            UserControls.TabPages.Add(StockTrackingPage);

            updateprod = new UpdateDatabaseView();
            updateprod.Dock = DockStyle.Fill;
            TabPage UpdateDatabasePage = new TabPage();
            UpdateDatabasePage.Controls.Add(updateprod);
            UpdateDatabasePage.Text = "Update Database";
            UpdateDatabasePage.ForeColor = Color.White;
            UpdateDatabasePage.BackColor = Color.FromArgb(11, 23, 42);
            UserControls.TabPages.Add(UpdateDatabasePage);

            updatecust = new UpdateCustListView();
            updatecust.Dock = DockStyle.Fill;
            TabPage UpdateCustListPage = new TabPage();
            UpdateCustListPage.Controls.Add(updatecust);
            UpdateCustListPage.Text = "Update Customer List";
            UpdateCustListPage.ForeColor = Color.White;
            UpdateCustListPage.BackColor = Color.FromArgb(11, 23, 42);
            UserControls.TabPages.Add(UpdateCustListPage);
        }


        /// <summary>
        ///     <para>
        ///         This button method returns the user to the menu screen
        ///     </para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormControl.menu2.Show();
        }

        private void TableUpdater(object sender)
        {
            ListBox box = (ListBox)sender;
            SQLiteDataAdapter prodadapter = new SQLiteDataAdapter(new SQLiteCommand("select * from Products", conn));
            SQLiteDataAdapter custadapter = new SQLiteDataAdapter(new SQLiteCommand("select * from CustomerList", conn));

            //table.Reset();
            stockView.DataSource = table;

            if (box.SelectedIndex == tablelist.IndexOf(0))
            {
                
                prodadapter.Fill(table);
            }
            else if (box.SelectedIndex == tablelist.IndexOf(1))
            {
                custadapter.Fill(table);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableUpdater(sender);
        }
    }
}
