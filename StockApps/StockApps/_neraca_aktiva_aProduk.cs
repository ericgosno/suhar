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
    public partial class _neraca_aktiva_aProduk : Form
    {
        _neraca_aktiva parent;
        DateTime tahun;
        public _neraca_aktiva_aProduk(DateTime timeYear, _neraca_aktiva parent)
        {
            InitializeComponent();
            tahun = timeYear;
            RefreshForm();
            
        }
        private void RefreshForm()
        {
            _idAktiva.Text = "";
            _txtnama.Text = "";
            _txtbg.Text = "";
            _txtjumlah.Text = "";
            _txtYear.Text = tahun.ToString("dd MMMM yyyy");

            _dataAktivaProduk.DataSource = NeracaAktiva.getIDProduct();

            _dataAktivaProduk.Columns["id_allproduct"].HeaderText = "No.";
            _dataAktivaProduk.Columns["nama"].HeaderText = "Nama";
            _dataAktivaProduk.Columns["bg"].HeaderText = "BG";
            _dataAktivaProduk.Columns["jumlah"].HeaderText = "Jumlah";
            _dataAktivaProduk.Columns["tahun_aktiva"].HeaderText = "Date";

            _dataAktivaProduk.Columns["idneraca_aktiva_allproduct"].Visible = false;
            

            /*
              _dgvspListSupplier.Columns["products"].Visible = false;
              _dgvspListSupplier.Columns["supplier_transaction"].Visible = false;
             * */
            _dataAktivaProduk.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            _dataAktivaProduk.Refresh();
        }

        private void _bbInsert_Click(object sender, EventArgs e)
        {
            if (_idAktiva.Text == "")
            {
                MessageBox.Show("Cannot be null!");
                return;
            }
            NeracaAktiva.insertAktivaProduct(_idAktiva.Text, _txtnama.Text, _txtbg.Text, decimal.Parse(_txtjumlah.Text),tahun);
            RefreshForm();

       
        }

        private void _neraca_aktiva_aProduk_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(tahun.ToString("dd MMMM yyyy"));
           // _txtYear.Text = tahun;
        }

        private void _bbDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowNow = null;
            if (_dataAktivaProduk.CurrentCell != null)
            {
                rowNow = _dataAktivaProduk.SelectedCells[0].OwningRow;
            }
            else if (_dataAktivaProduk.CurrentRow != null)
            {
                rowNow = _dataAktivaProduk.SelectedRows[0];
            }
            int aktivaProdukID = (int)rowNow.Cells["idneraca_aktiva_allproduct"].Value;
            NeracaAktiva.deleteProduct(aktivaProdukID);
            RefreshForm();
        }

       

     

      

        
        
        
    }
}
