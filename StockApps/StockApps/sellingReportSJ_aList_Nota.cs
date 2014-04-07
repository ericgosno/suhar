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
    public partial class sellingReportSJ_aList_Nota : Form
    {
        sellingReport parent;
        String Cus_ID;
        int Status_Check;
        public sellingReportSJ_aList_Nota(String Customer_ID, int Status, sellingReport parent)
        {
            InitializeComponent();
            Cus_ID = Customer_ID;
            Status_Check = Status;
            var transList = CustomerTransaction.getCustomer(int.Parse(Customer_ID));
            listBox1.DataSource = transList;
            listBox1.DisplayMember = "Customer_Transaction_Note_Number";
            listBox1.ValueMember = "Customer_Transaction_ID";
            this.parent = parent;
        }

        private void _btnProcess_Click(object sender, EventArgs e)
        {
            if (Status_Check == 0)
            {
                //this.parent.suratJalanID = listBox1.SelectedValue.ToString();
                //this.Close();
                sellingReportSJ_bForm_RptViewer nextForm = new sellingReportSJ_bForm_RptViewer(listBox1.SelectedValue.ToString());
                //nextForm.FormClosed += new FormClosedEventHandler(suratJalan_FormClosed);
                nextForm.Show();
            }
            else if (Status_Check == 1)
            {
                sellingReportFP_bForm_RptViewer nextForm = new sellingReportFP_bForm_RptViewer(listBox1.SelectedValue.ToString());
                nextForm.Show();
            }
            else if (Status_Check == 2)
            {
                sellingReportFPajak_bForm_RptViewer nextForm = new sellingReportFPajak_bForm_RptViewer(listBox1.SelectedValue.ToString());
                nextForm.Show();
            }
     
        }

        private void sellingReportSJ_aList_Nota_Load(object sender, EventArgs e)
        {

        }

    
      
    }
}
