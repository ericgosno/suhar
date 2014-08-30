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
    public partial class _purchasingTrans : Form
    {
        Decimal ttlBiayaLain = 0;
        Double ttlBiayaLainItu = 0;
        public _purchasingTrans()
        {
            InitializeComponent();
            var listSupplier = SupplierController.getSupplier();
            _cbpurNama.DataSource = listSupplier;
            _cbpurNama.DisplayMember = "Supplier_Company_Name";
            _cbpurNama.ValueMember = "Supplier_ID";
            _cbpurKurs.DataSource = CurrencyController.getCurrency();
            _cbpurKurs.DisplayMember = "Currency_Name";
            _cbpurKurs.ValueMember = "Currency_ID";
            comboKategori.DataSource = ControllerBiayaLain.getKategori();
            comboKategori.DisplayMember = "Nama_biaya_lain";
            comboKategori.ValueMember = "Kategori_lain_ID";
            refreshListProduct();
            RefreshForm();
        }

        private void refreshListProduct()
        {
            try
            {
                _dataSupTransaction.Rows.Clear();
                _lpurDollar.Text = "0";
                _lpurRp.Text = "0";
                var listProduct = ProductController.getProductBySupplierID(Convert.ToInt32((_cbpurNama.SelectedValue)));
                (_dataSupTransaction.Columns["Product"] as DataGridViewComboBoxColumn).DataSource = listProduct;
                (_dataSupTransaction.Columns["Product"] as DataGridViewComboBoxColumn).DisplayMember = "Product_Name";
                (_dataSupTransaction.Columns["Product"] as DataGridViewComboBoxColumn).ValueMember = "Product_ID";
            }
            catch (Exception ex) { }
        }
        private void _purchasingTrans_Load(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(StockApps.Properties.Resources.corner);
            pictureBox1.Image = pic;
            Bitmap pic2 = new Bitmap(StockApps.Properties.Resources.cvusaha);
            pictureBox2.Image = pic2;
        }

        private void _cbpurNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshListProduct();
        }

        private void RefreshData()
        {
            double totalRupiah = 0;
            double totalDollar = 0;
            for (int i = 0; i < _dataSupTransaction.Rows.Count; i++)
            {
                try
                {
                    int prodId = Convert.ToInt32((_dataSupTransaction.Rows[i].Cells["Product"] as DataGridViewComboBoxCell).Value);
                    var list = ProductController.getProductByProductID(prodId);
                    if (list.Count() <= 0) 
                        continue;
                    var prodNow = list.First();
                    int quantity = Convert.ToInt32(_dataSupTransaction.Rows[i].Cells["Quantity_Kg"].Value);
                    double priceperkg = Convert.ToDouble(prodNow.Product_Buy_Price);
                    _dataSupTransaction.Rows[i].Cells["Package_Quantity"].Value = Math.Ceiling(Convert.ToDouble(quantity) / Convert.ToDouble(prodNow.Product_Packing_Kilogram)).ToString() + " " + prodNow.Product_Packing_Name;
                    _dataSupTransaction.Rows[i].Cells["Price_Kg"].Value = prodNow.Product_Buy_Price.ToString() + " " + prodNow.currency.Currency_Name;
                    double dollar = 0;
                    double rupiah = 0;
                    if (prodNow.Currency_ID == 1)
                    {
                        dollar = priceperkg * quantity;
                        rupiah = dollar * Convert.ToDouble(_tpurKurs.Text);
                    }
                    else
                    {
                        rupiah = priceperkg * quantity;
                        dollar = rupiah / Convert.ToDouble(_tpurKurs.Text);
                    }

                    totalRupiah += rupiah;
                    totalDollar += dollar;
                    _dataSupTransaction.Rows[i].Cells["Subtotal_Dollar"].Value = dollar.ToString("C2");
                    _dataSupTransaction.Rows[i].Cells["Subtotal_Rupiah"].Value = rupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
                }
                catch (Exception ex) { continue; }
            }
            _lpurRp.Text = totalRupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID")); 
            _lpurDollar.Text = totalDollar.ToString("C2");
            _lpurPPNRupiah.Text = (totalRupiah * 0.1).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            _lpurPPNDollar.Text = (totalDollar * 0.1).ToString("C2");
            _lpurTotalPPNDollar.Text = (totalDollar * 1.1).ToString("C2");
            _lpurTotalPPNRupiah.Text = (totalRupiah * 1.1).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            ttlseluruh.Text = (totalRupiah * 1.1 + Convert.ToDouble(ttlBiayaLain)).ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
         
        }
        private void _dataSupTransaction_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            RefreshData();
        }

        private void _tpurKurs_TextChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void _bpurPay_Click(object sender, EventArgs e)
        {
            double totalDollar = 0;
            double totalRupiah = 0;

            List<supplier_transaction_product> prod = new List<supplier_transaction_product>();
            for (int i = 0; i < _dataSupTransaction.Rows.Count; i++)
            {
                try
                {
                    supplier_transaction_product newProduct = new supplier_transaction_product();
                    int prodID = Convert.ToInt32((_dataSupTransaction.Rows[i].Cells["Product"] as DataGridViewComboBoxCell).Value);
                    var list = ProductController.getProductByProductID(prodID);
                    if (list.Count() <= 0) continue;
                    var prodNow = list.First();
                    newProduct.Product_ID = prodID;
                    int quantity = Convert.ToInt32(_dataSupTransaction.Rows[i].Cells["Quantity_Kg"].Value);
                    double priceperkg = Convert.ToDouble(prodNow.Product_Buy_Price);
                    _dataSupTransaction.Rows[i].Cells["Package_Quantity"].Value = Math.Ceiling(Convert.ToDouble(quantity) / Convert.ToDouble(prodNow.Product_Packing_Kilogram)).ToString() + " " + prodNow.Product_Packing_Name;
                    _dataSupTransaction.Rows[i].Cells["Price_Kg"].Value = prodNow.Product_Buy_Price.ToString() + " " + prodNow.currency.Currency_Name;
                    double dollar = 0;
                    double rupiah = 0;
                    if (prodNow.Currency_ID == 1)
                    {
                        dollar = priceperkg * quantity;
                        rupiah = dollar * Convert.ToDouble(_tpurKurs.Text);
                    }
                    else
                    {
                        rupiah = priceperkg * quantity;
                        dollar = rupiah / Convert.ToDouble(_tpurKurs.Text);
                    }
                    newProduct.Supplier_Transaction_Product_Price_Dollar = Convert.ToDecimal(dollar);
                    newProduct.Supplier_Transaction_Product_Price_Rupiah = Convert.ToDecimal(dollar);;
                    newProduct.Supplier_Transaction_Product_Quantity = quantity;
                    totalRupiah += rupiah;
                    totalDollar += dollar;
                    _dataSupTransaction.Rows[i].Cells["Subtotal_Dollar"].Value = dollar.ToString("C2");
                    _dataSupTransaction.Rows[i].Cells["Subtotal_Rupiah"].Value = rupiah.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
                    prod.Add(newProduct);
                }
                catch (Exception ex) { continue; }
            }
            try
            {
                decimal kurs = Convert.ToDecimal(_tpurKurs.Text);
            }
            catch(Exception ex) 
            { 
                MessageBox.Show("Kurs must be nominal!");
                return;
            }
            //totalRupiah += ttlBiayaLainItu;
            supplier_transaction newTrans = SupplierTransaction.insertSupplierTransaction(_dtTransDate.Value,Convert.ToInt32(_cbpurNama.SelectedValue), totalDollar, totalRupiah, _tpurDescription.Text, prod,_tpurNoteNum.Text,_tpurInvoice.Text,Convert.ToInt32(_cbpurKurs.SelectedValue),Convert.ToDecimal(_tpurKurs.Text));
            foreach (supplier_transaction_product stp in prod)
            {
                product productStp = ProductController.getProductByProductID(stp.Product_ID).First();
                PriceHistoryController.insertPriceHistory(stp.Product_ID, Convert.ToDecimal(productStp.Product_Buy_Price), _dtTransDate.Value, stp.Supplier_Transaction_Product_Quantity, Convert.ToInt32(productStp.Currency_ID));
            }
            String Cek = "";
            Cek = newTrans.Supplier_Transaction_ID;
            ControllerBiayaLain.UpdateIdBiaya(Cek);
            _purchasingTrans2 nextForm = new _purchasingTrans2(newTrans,ttlBiayaLain);
      
            nextForm.FormClosed += new FormClosedEventHandler(prodForm_FormClosed);
            nextForm.Show();
            this.Hide();
        }
        
        void prodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        void prodForm_FormClosedRefresh(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            comboKategori.DataSource = ControllerBiayaLain.getKategori();
            comboKategori.DisplayMember = "nama_biaya_lain";
            comboKategori.ValueMember = "Kategori_lain_ID";
        }

        private void _bpurDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow rowNow = null;
                if (_dataSupTransaction.CurrentCell != null)
                {
                    rowNow = _dataSupTransaction.SelectedCells[0].OwningRow;
                }
                else if (_dataSupTransaction.CurrentRow != null)
                {
                    rowNow = _dataSupTransaction.SelectedRows[0];
                }
                _dataSupTransaction.Rows.Remove(rowNow);
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a Row First!");
            }
        }

        private void _cbpurKurs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _purchasing_biaya_lain detailNamaBiaya = new _purchasing_biaya_lain();
            detailNamaBiaya.Show(this);
            detailNamaBiaya.FormClosed += new FormClosedEventHandler(prodForm_FormClosedRefresh);
        }

        private void btnTambahLain_Click(object sender, EventArgs e)
        {
            if (txtjmllain.Text == "")
            {
                MessageBox.Show("Jumlah cannot be null!");
                return;
            }
            ControllerBiayaLain.insertSupBiayaLain(Convert.ToInt32(comboKategori.SelectedValue), "Null1", Convert.ToDecimal(txtjmllain.Text));
            ttlBiayaLain += Convert.ToDecimal(txtjmllain.Text);
            ttlBiayaLainItu += Convert.ToDouble(txtjmllain.Text);
            RefreshForm();
        }

        private void RefreshForm()
        {
            txtjmllain.Text = "";

            dgvLainlain.DataSource = ControllerBiayaLain
                .getsupKategoriSpec();

            dgvLainlain.Columns["Kategori_lain_ID"].HeaderText = "ID KATEGORI";
            dgvLainlain.Columns["Supplier_Transaction_ID"].HeaderText = "Supplier Trans ID";
            dgvLainlain.Columns["Harga_Biaya"].HeaderText = "Harga";
            dgvLainlain.Columns["supplier_biaya_laincol"].Visible = false;
            dgvLainlain.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            dgvLainlain.Refresh();
            label31.Text = ttlBiayaLain.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("id-ID"));
            RefreshData();
        }

        private void btnDelB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;
            try
            {
                DataGridViewRow rowNow = null;
                if (dgvLainlain.CurrentCell != null)
                {
                    rowNow = dgvLainlain.SelectedCells[0].OwningRow;
                }
                else if (dgvLainlain.CurrentRow != null)
                {
                    rowNow = dgvLainlain.SelectedRows[0];
                }
                int SupplierID = (int)rowNow.Cells["supplier_biaya_laincol"].Value;

                ControllerBiayaLain.deleteKategoriBiaya(SupplierID);
                RefreshForm();
            }
            catch
            {

            }
        }
    }
}
