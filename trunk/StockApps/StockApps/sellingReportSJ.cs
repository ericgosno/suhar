using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockModel;


namespace StockApps
{
    public partial class sellingReportSJ : Form
    {

        public sellingReportSJ(String transID)
        {
            InitializeComponent();
            var transList = CustomerTransaction.getCustomer(int.Parse(transID));
            listBox1.DataSource = transList;
            listBox1.DisplayMember = "Customer_Transaction_Note_Number";
            listBox1.ValueMember = "Customer_Transaction_ID";
        }

        private void _btnProcess_Click(object sender, EventArgs e)
        {

        }
    }
}
