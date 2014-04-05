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
    public partial class sellingReportListSJ : Form
    {
        sellingReport parent;
        String Cus_ID;
        public sellingReportListSJ(String transID, sellingReport parent)
        {
            InitializeComponent();
            Cus_ID = transID;
            var transList = CustomerTransaction.getCustomer(int.Parse(transID));
            listBox1.DataSource = transList;
            listBox1.DisplayMember = "Customer_Transaction_Note_Number";
            listBox1.ValueMember = "Customer_Transaction_ID";
            this.parent = parent;
        }

        private void _btnProcess_Click(object sender, EventArgs e)
        {
            //this.parent.suratJalanID = listBox1.SelectedValue.ToString();
            //this.Close();
            sellingReportSuratJalan nextForm = new sellingReportSuratJalan(listBox1.SelectedValue.ToString(),Cus_ID);
            //nextForm.FormClosed += new FormClosedEventHandler(suratJalan_FormClosed);
            nextForm.Show();
        }

        private void sellingReportListSJ_Load(object sender, EventArgs e)
        {

        }

       
    }
}
