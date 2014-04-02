﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using StockModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace StockApps
{
    public partial class sellingReport : Form
    {
        public sellingReport()
        {
            InitializeComponent();
        }

        private void _bsellView_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(_cbNama.SelectedValue.ToString());
            string connectionString = "server=119.235.248.242; database=stockapps; uid=eric; pwd=eric;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            ReportDocument rptDoc = new ReportDocument();
            dsSelling ds = new dsSelling(); // .xsd file name
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adapter;
            MySqlCommand cmd2 = new MySqlCommand();
            MySqlDataAdapter adapter2;
            MySqlCommand cmd3 = new MySqlCommand();
            MySqlDataAdapter adapter3;
            //string query = "SELECT * from admin_history";
            //string query = "SELECT a.users_id,u.users_username,a.log_type,a.time_log FROM stockapps.admin_history a,stockapps.users u where a.users_id = u.users_id";
            //string query2 = "SELECT users_id,users_username from users";
            string query3="";
            if (_cbCus.Checked == true && _cbDateChecker.Checked == true)
            {
               
            }
            else if (_cbCus.Checked == true && _cbDateChecker.Checked == false)
            {
                 query3 = "SELECT * FROM stockapps.customer_transaction where Customer_ID =" + _cbNama.SelectedValue.ToString();
          
            }
            else if (_cbCus.Checked == false && _cbDateChecker.Checked == true)
            {
                _cbDateTrans.Format = DateTimePickerFormat.Custom;
                _cbDateTrans.CustomFormat = "dd-MM-yyyy";
                query3 = "SELECT * FROM stockapps.customer_transaction where DATE_FORMAT(Customer_Transaction_Date,'%d-%m-%Y') = '" + _cbDateTrans.Text + "'";
          
            }
            else
            {
              
            }
            
            
            
            
            
             
            try
            {/*
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                cmd2 = new MySqlCommand(query2, connection);
                adapter2 = new MySqlDataAdapter(cmd2);
                adapter2.Fill(dt2);
              * */
                cmd3 = new MySqlCommand(query3, connection);
                adapter3 = new MySqlDataAdapter(cmd3);
                adapter3.Fill(dt3);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }

            ds.Tables[0].Merge(dt);
            ds.Tables[1].Merge(dt2);
            ds.Tables[2].Merge(dt3);
            // Your .rpt file path will be below

            //rptDoc.Load(Application.StartupPath + @"adminReport.rpt");
            rptDoc.Load(@"C:\Users\Stefanus\Desktop\suhar\StockApps\StockApps\sellingReportSuratJalan.rpt");
            //rptDoc.Load(@"C:\Users\3nc\Documents\Visual Studio 2010\Projects\Suhar\StockApps\StockApps\adminReport.rpt");

            //set dataset to the report viewer.
            rptDoc.SetDataSource(ds);
            _rptSelling.ReportSource = rptDoc;
        }

        private void sellingReport_Load(object sender, EventArgs e)
        {
            RefreshForm();
            var listCustomer = CustomerController.getCustomer();
            _cbNama.DataSource = listCustomer;
            _cbNama.DisplayMember = "Customer_Company_Name";
            _cbNama.ValueMember = "Customer_ID";
        }

        private void _cbCus_CheckedChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void _cbDateChecker_CheckedChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            if (_cbCus.Checked == true && _cbDateChecker.Checked == true)
            {
                _cbDateTrans.Enabled = true;
                _cbNama.Enabled = true;
            }
            else if(_cbCus.Checked == true && _cbDateChecker.Checked == false)
            {
                _cbDateTrans.Enabled = false;
                _cbNama.Enabled = true;
            }
            else if (_cbCus.Checked == false && _cbDateChecker.Checked == true)
            {
                _cbDateTrans.Enabled = true;
                _cbNama.Enabled = false;
            }
            else
            {
                _cbDateTrans.Enabled = true;
                _cbNama.Enabled = true;
            }
        }

      
    }
}

    


    

       