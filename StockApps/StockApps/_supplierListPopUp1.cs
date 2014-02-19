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
    public partial class _supplierListPopUp1 : Form
    {
        public _supplierListPopUp1(supplier supplierNow)
        {
            InitializeComponent();
            _tspDName.Text = supplierNow.Supplier_Name;
            RefreshForm();
        }
        private void RefreshForm()
        {
            /*
            _dataDetailSupplier.DataSource = 
            _dataDetailSupplier.Columns["Supplier_Name"].HeaderText = "Name";
            _dataDetailSupplier.Columns["Supplier_Address"].HeaderText = "Address";
            _dataDetailSupplier.Columns["Supplier_Email"].HeaderText = "Email";
            _dataDetailSupplier.Columns["Supplier_Phone"].HeaderText = "Phone";

            _dataDetailSupplier.Columns["Supplier_Status"].Visible = false;
            _dataDetailSupplier.Columns["Supplier_ID"].Visible = false;
            _dataDetailSupplier.Columns["products"].Visible = false;
            _dataDetailSupplier.Columns["supplier_transaction"].Visible = false;
            _dataDetailSupplier.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            */
            _dataDetailSupplier.Refresh();
        }
    }
}
