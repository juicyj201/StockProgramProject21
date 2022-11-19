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
using System.IO;
using System.Text.RegularExpressions;

namespace StockProgram.UserControls
{
    public partial class StockTrackingView : UserControl
    {
        private SQLiteConnection con = new SQLiteConnection(@"data source=.\StockDatabase.db;");
        private List<String> months = new List<String>();
        private List<String> years = new List<String>();

        //regex
        private Regex reg = new Regex("/");
        private bool canGenReport;


        public StockTrackingView()
        {
            InitializeComponent();

            //add all months and years for the combo boxes
            addMonths();
            addYears();
        }

        private void addMonths() {
            for (int i = 0; i <= 12; i++)
            {
                if (months.Contains(i.ToString()))
                {
                    i += 1;
                    monthCb.Items.Add(i.ToString());
                }
                else {
                    monthCb.Items.Add(i.ToString());
                }
            }
        }

        private void addYears() {
            yearCb.Items.Add("2020");
            yearCb.Items.Add("2021");
            yearCb.Items.Add("2022");
        }

        private void yearCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string year = GetDate("year");
            if (yearCb.Items.Contains(year) == false)
            {
                MessageBox.Show("You have selected a year that is not found in the database. Please try again");
                canGenReport = false;
            }
            else {
                canGenReport = true;
            }
        }

        private void monthCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month = GetDate("month");
            if (monthCb.Items.Contains(month) == false)
            {
                MessageBox.Show("You have selected a month that is not found on the database. Please try again");
                canGenReport = false;
            }
            else {
                canGenReport = true;
            }
        }

        private void genReportBtn_Click(object sender, EventArgs e)
        {
            if (canGenReport == true) {
                string[] list = GetData();

                reportText.Text = list.ToString();
            }
        }

        private string[] GetData()
        {
            try
            {
                con.Open();
                string sqlstuff = "select * from Products";

                SQLiteCommand cmd = new SQLiteCommand(sqlstuff, con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    string[] list = new string[6];
                    string id = reader.GetString(0); list.Append(id);
                    string name = reader.GetString(1); list.Append(name);
                    string price = reader.GetString(2); list.Append(price);
                    string quantity = reader.GetString(3); list.Append(quantity);
                    string dateofuse = reader.GetString(4); list.Append(dateofuse);
                    string dateofpurch = reader.GetString(5); list.Append(dateofpurch);

                    return list;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

            return null;
        }
        
    

        private string GetDate(string type) {
            try
            {
                con.Open();
                string sqlstuff = "select DateOfPurchase from Products";

                SQLiteCommand cmd = new SQLiteCommand(sqlstuff, con);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    string dateofpurch = reader.GetString(0);
                    string[] date = reg.Split(dateofpurch);
                    string day = date[0];
                    string month = date[1];
                    string year = date[2];

                    if (type.Equals("month"))
                    {
                        return month;
                    }
                    else if (type.Equals("year"))
                    {
                        return year;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

            return null;
        }
    }
}
