﻿using System;
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
            _tspCompany.Text = "";
            _tspNPWP.Text = "";
            _dgvspListSupplier.DataSource = SupplierController
                .getSupplier();

            _dgvspListSupplier.Columns["Supplier_Name"].HeaderText = "Name";
            _dgvspListSupplier.Columns["Supplier_Address"].HeaderText = "Address";
            _dgvspListSupplier.Columns["Supplier_Email"].HeaderText = "Email";
            _dgvspListSupplier.Columns["Supplier_Phone"].HeaderText = "Phone";
            _dgvspListSupplier.Columns["Supplier_NPWP"].HeaderText = "NPWP";
            _dgvspListSupplier.Columns["Supplier_Company_Name"].HeaderText = "Company Name";

            _dgvspListSupplier.Columns["Supplier_Regional"].Visible = false;
            _dgvspListSupplier.Columns["Supplier_Credit_Dollar"].Visible = false;
            _dgvspListSupplier.Columns["Supplier_Credit_Rupiah"].Visible = false;
            _dgvspListSupplier.Columns["Supplier_Status"].Visible = false;
            _dgvspListSupplier.Columns["Supplier_Payment"].Visible = false;
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
            SupplierController.insertSupplier(_tspName.Text, _tspAddress.Text, _tspEmail.Text, _tspPhone.Text, _tspNPWP.Text, _tspCompany.Text, _cbspRegional.SelectedIndex+1);
            RefreshForm();
        }

        private void _bspDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;
            try
            {
                DataGridViewRow rowNow = null;
                if (_dgvspListSupplier.CurrentCell != null)
                {
                    rowNow = _dgvspListSupplier.SelectedCells[0].OwningRow;
                }
                else if (_dgvspListSupplier.CurrentRow != null)
                {
                    rowNow = _dgvspListSupplier.SelectedRows[0];
                }
                int SupplierID = (int)rowNow.Cells["Supplier_ID"].Value;
                if (SupplierTransaction.getSupplierTransaction(SupplierID).Count() > 0)
                {
                    MessageBox.Show("Can't delete supplier, Only supplier with no transaction can be deleted!");
                    return;
                }
                SupplierController.deleteSupplier(SupplierID);
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
            SupplierController.editSupplier(Convert.ToInt32(rowNow.Cells["Supplier_ID"].Value), rowNow.Cells["Supplier_Name"].Value.ToString(), rowNow.Cells["Supplier_Address"].Value.ToString(), rowNow.Cells["Supplier_Email"].Value.ToString(), rowNow.Cells["Supplier_Phone"].Value.ToString(), rowNow.Cells["Supplier_NPWP"].Value.ToString(), rowNow.Cells["Supplier_Company_Name"].Value.ToString(), _cbspRegional.SelectedIndex + 1);
            _dgvspListSupplier.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void _bspDetail_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow rowNow = null;
                if (_dgvspListSupplier.CurrentCell != null)
                {
                    rowNow = _dgvspListSupplier.SelectedCells[0].OwningRow;
                }
                else if (_dgvspListSupplier.CurrentRow != null)
                {
                    rowNow = _dgvspListSupplier.SelectedRows[0];
                }
                _supplierListPopUp1 detailSupplier = new _supplierListPopUp1(SupplierController.getSupplier(Convert.ToInt32(rowNow.Cells["Supplier_ID"].Value)).First());
                detailSupplier.Show();
           }
           catch (Exception ex)
           {
                MessageBox.Show("You must select a Row First!");
           }
        }

        private void _supplierList_Load(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(StockApps.Properties.Resources.corner);
            pictureBox1.Image = pic;
            Bitmap pic2 = new Bitmap(StockApps.Properties.Resources.cvusaha);
            pictureBox2.Image = pic2;
        }

     
    }
}
