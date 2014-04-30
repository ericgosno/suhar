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
    public partial class _customerList : Form
    {
        public _customerList()
        {
            InitializeComponent();
            RefreshForm();
        }
        private void RefreshForm()
        {
            _tcusName.Text = "";
            _tcusAddress.Text = "";
            _tcusEmail.Text = "";
            _tcusPhone.Text = "";
            _tcusNPWP.Text = "";
            _tcusCompany.Text = "";
            _tcusCity.Text = "";
            _dataCustomer.DataSource = CustomerController.getCustomer();
            _dataCustomer.Columns["Customer_Company_Name"].HeaderText = "Company Name";
            _dataCustomer.Columns["Customer_Name"].HeaderText = "Name";
            _dataCustomer.Columns["Customer_Address"].HeaderText = "Address";
            _dataCustomer.Columns["Customer_Email"].HeaderText = "Email";
            _dataCustomer.Columns["Customer_Phone"].HeaderText = "Phone";
            _dataCustomer.Columns["Customer_NPWP"].HeaderText = "NPWP";
            _dataCustomer.Columns["Customer_City"].HeaderText = "City";


            _dataCustomer.Columns["Customer_Status"].Visible = false;
            _dataCustomer.Columns["Customer_ID"].Visible = false;
            _dataCustomer.Columns["Customer_Payment"].Visible = false;
            _dataCustomer.Columns["Customer_Debt1"].Visible = false;
            _dataCustomer.Columns["Customer_Debt_Rupiah"].Visible = false;
            _dataCustomer.Columns["Customer_Debt_Dollar"].Visible = false;
            _dataCustomer.Columns["customer_transaction"].Visible = false;
            _dataCustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            _dataCustomer.Refresh();
        }

        private void _bcusInsert_Click(object sender, EventArgs e)
        {
            if (_tcusName.Text == "")
            {
                MessageBox.Show("Name must not be null!");
                return;
            }

            CustomerController.insertCustomer(_tcusName.Text, _tcusAddress.Text, _tcusEmail.Text, _tcusPhone.Text,_tcusNPWP.Text,_tcusCompany.Text,_tcusCity.Text);
            RefreshForm();
        }

        private void _bcusDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;
            try
            {
                DataGridViewRow rowNow = null;
                if (_dataCustomer.CurrentCell != null)
                {
                    rowNow = _dataCustomer.SelectedCells[0].OwningRow;
                }
                else if (_dataCustomer.CurrentRow != null)
                {
                    rowNow = _dataCustomer.SelectedRows[0];
                }
                int CustID = (int)rowNow.Cells["Customer_ID"].Value;
                if (CustomerTransaction.getCustomerTransaction(CustID).Count() > 0)
                {
                    MessageBox.Show("Can't delete this customer, Only customer with no transaction can be deleted!");
                    return;
                }
                CustomerController.deleteCustomer(CustID);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a Row First!");
            }
        }

        private void _dataCustomer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var rowNow = _dataCustomer.Rows[e.RowIndex];
            CustomerController.editCustomer((int)rowNow.Cells["Customer_ID"].Value, rowNow.Cells["Customer_Name"].Value.ToString(), rowNow.Cells["Customer_Address"].Value.ToString(), rowNow.Cells["Customer_Email"].Value.ToString(), rowNow.Cells["Customer_Phone"].Value.ToString(), rowNow.Cells["Customer_NPWP"].Value.ToString(), rowNow.Cells["Customer_Company_Name"].Value.ToString(), rowNow.Cells["Customer_City"].Value.ToString());
            _dataCustomer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void _customerList_Load(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(StockApps.Properties.Resources.corner);
            pictureBox1.Image = pic;
            Bitmap pic2 = new Bitmap(StockApps.Properties.Resources.cvusaha);
            pictureBox2.Image = pic2;
        }
    }
}
