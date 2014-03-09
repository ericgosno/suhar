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
    public partial class _supplierList : Form
    {
        public _supplierList()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void RefreshForm()
        {
            _tspName.Text = "";
            _tspAddress.Text = "";
            _tspEmail.Text = "";
            _tspPhone.Text = "";
            _dgvspListSupplier.DataSource = SupplierController.getSupplier();
            _dgvspListSupplier.Columns["Supplier_Name"].HeaderText = "Name";
            _dgvspListSupplier.Columns["Supplier_Address"].HeaderText = "Address";
            _dgvspListSupplier.Columns["Supplier_Email"].HeaderText = "Email";
            _dgvspListSupplier.Columns["Supplier_Phone"].HeaderText = "Phone";
            _dgvspListSupplier.Columns["Supplier_NPWP"].HeaderText = "NPWP";

            _dgvspListSupplier.Columns["Supplier_Status"].Visible = false;
            _dgvspListSupplier.Columns["Supplier_ID"].Visible = false;
            _dgvspListSupplier.Columns["products"].Visible = false;
            _dgvspListSupplier.Columns["supplier_transaction"].Visible = false;
            _dgvspListSupplier.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            _dgvspListSupplier.Refresh();
        }

        private void _bspInsert_Click(object sender, EventArgs e)
        {
            if (_tspName.Text == "")
            {
                MessageBox.Show("Name cannot be null!");
                return;
            }
            SupplierController.insertSupplier(_tspName.Text, _tspAddress.Text, _tspEmail.Text, _tspPhone.Text,_tspNPWP.Text);
            RefreshForm();
        }

        private void _bspDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierController.deleteSupplier((int)_dgvspListSupplier.SelectedRows[0].Cells["Supplier_ID"].Value);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a Row First!");
            }
        }

        private void _dgvspListSupplier_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var rowNow = _dgvspListSupplier.Rows[e.RowIndex];
            SupplierController.editSupplier((int)rowNow.Cells["Supplier_ID"].Value, rowNow.Cells["Supplier_Name"].Value.ToString(), rowNow.Cells["Supplier_Address"].Value.ToString(), rowNow.Cells["Supplier_Email"].Value.ToString(), rowNow.Cells["Supplier_Phone"].Value.ToString(),rowNow.Cells["Supplier_NPWP"].Value.ToString());
            _dgvspListSupplier.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void _bspDetail_Click(object sender, EventArgs e)
        {
           // try
            //{
                _supplierListPopUp1 detailSupplier = new _supplierListPopUp1(SupplierController.getSupplier((int)_dgvspListSupplier.SelectedRows[0].Cells["Supplier_ID"].Value).First());
                detailSupplier.Show();
           //}
            //catch (Exception ex)
           // {
            //    MessageBox.Show("You must select a Row First!");
           //}
        }
    }
}
