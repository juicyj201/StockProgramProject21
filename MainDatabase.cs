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
        /// <summary>
        /// These are the global variables for the MainDatabase class
        /// </summary>
        private SQLiteConnection conn = new SQLiteConnection(@"data source=.\StockDatabase.db");
        private DataTable table = new DataTable();

        private EditStockPriceView editstuff;
        private StockTrackingView stocktrackstuff;
        private UpdateDatabaseView updatestuff;

        public MainDatabase()
        {
            ///<summary>
            /// We initialise the components and reference the methods that the program uses, inside this constructor
            ///<summary>
            InitializeComponent();

            OpenConnection();
            ShowStock();
            AddControls();
            CloseConnection();
        }

        /// <summary>
        /// These are the methods used for opening and closing the connection to the sqlite database.
        /// </summary>
        public void OpenConnection() {
            conn.Open();
        }

        public void CloseConnection() {
            conn.Close();
        }

        /// <summary>
        /// This is a method used to show the items inside the sqlite database
        /// </summary>
        public void ShowStock() {
            //the command object
            string selectStock = "SELECT* from Products";
            SQLiteCommand selectComm = new SQLiteCommand(selectStock, conn);

            //the adapter
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectComm);
            adapter.Fill(table);

            //actually putting it in the form
            stockView.DataSource = table;

            stockView.RowsDefaultCellStyle.BackColor = Color.White;
            stockView.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            stockView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            stockView.DefaultCellStyle.SelectionBackColor = Color.Black;
            stockView.DefaultCellStyle.SelectionForeColor = Color.White;
            stockView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            stockView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            stockView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            stockView.AllowUserToResizeColumns = false;
            stockView.SuspendLayout();
            
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormControl.menu2.Show();
        }

        /// <summary>
        /// This is a method used to add the user controls, to the tab control in the MainDatabase form
        /// </summary>
        private void AddControls() {
            UserControls.SizeMode = TabSizeMode.FillToRight;
            UserControls.Appearance = TabAppearance.Normal;

            editstuff = new EditStockPriceView();
            editstuff.Dock = DockStyle.Fill;
            TabPage EditPriceStockPage = new TabPage();
            EditPriceStockPage.Controls.Add(editstuff);
            EditPriceStockPage.Text = "Editing and Calculations";
            UserControls.TabPages.Add(EditPriceStockPage);
            
            stocktrackstuff = new StockTrackingView();
            stocktrackstuff.Dock = DockStyle.Fill;
            TabPage StockTrackingPage = new TabPage();
            StockTrackingPage.Controls.Add(stocktrackstuff);
            StockTrackingPage.Text = "Stock Tracking";
            UserControls.TabPages.Add(StockTrackingPage);
            
            updatestuff = new UpdateDatabaseView();
            updatestuff.Dock = DockStyle.Fill;
            TabPage UpdateDatabasePage = new TabPage();
            UpdateDatabasePage.Controls.Add(updatestuff);
            UpdateDatabasePage.Text = "Update Database";
            UserControls.TabPages.Add(UpdateDatabasePage);
        }

        /// <summary>
        /// This is a method used to display an item in a selected row.
        /// If you double click on a row in the dataGridView, then the item information will be displayed in seperate text boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stockView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string id = stockView.CurrentCell.OwningRow.Cells[1].Value.ToString();
            string namecell = stockView.CurrentCell.OwningRow.Cells[2].Value.ToString();
            string pricecell = stockView.CurrentCell.OwningRow.Cells[3].Value.ToString();
            string quantitycell = stockView.CurrentCell.OwningRow.Cells[4].Value.ToString();

            updatestuff.gettextBox1.Text = id;
            updatestuff.gettextBox2.Text = namecell;
            updatestuff.gettextBox3.Text = pricecell;
            updatestuff.gettextBox4.Text = quantitycell;
             

            //nameTb.Text = namecell;
            //priceTb.Text = pricecell;
            //quantityTb.Text = quantitycell;
        }

        private void stockView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
