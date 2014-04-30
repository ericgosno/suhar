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
    public partial class _neraca_aktiva_bKas : Form
    {
        _neraca_aktiva parent;
        DateTime tahun;
        public _neraca_aktiva_bKas(DateTime timeYear, _neraca_aktiva parent)
        {
            InitializeComponent();
            tahun = timeYear;
            RefreshForm();
        }

        private void RefreshForm()
        {
            _idAktivakas.Text = "";
            _txtnama.Text = "";
            _txtdollar.Text = "";
            _txtrupiah.Text = "";
            _txtYear.Text = tahun.ToString("dd MMMM yyyy");

            _dataAktivaKas.DataSource = NeracaAktiva.getIDKas();

            _dataAktivaKas.Columns["id_allkas"].HeaderText = "No.";
            _dataAktivaKas.Columns["nama"].HeaderText = "Nama";
            _dataAktivaKas.Columns["dollar"].HeaderText = "Dollar";
            _dataAktivaKas.Columns["rupiah"].HeaderText = "Rupiah";
            _dataAktivaKas.Columns["tahun_aktiva"].HeaderText = "Date";

            _dataAktivaKas.Columns["idneraca_aktiva_allkas"].Visible = false;
            /*
              _dgvspListSupplier.Columns["products"].Visible = false;
              _dgvspListSupplier.Columns["supplier_transaction"].Visible = false;
             * */
            _dataAktivaKas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            _dataAktivaKas.Refresh();
        }

        private void _bbInsert_Click(object sender, EventArgs e)
        {
            if (_idAktivakas.Text == "")
            {
                MessageBox.Show("Cannot be null!");
                return;
            }
            NeracaAktiva.insertAktivaKas(_idAktivakas.Text, _txtnama.Text, decimal.Parse(_txtdollar.Text), decimal.Parse(_txtrupiah.Text),tahun);
            RefreshForm();
        }

        private void _bbDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowNow = null;
            if (_dataAktivaKas.CurrentCell != null)
            {
                rowNow = _dataAktivaKas.SelectedCells[0].OwningRow;
            }
            else if (_dataAktivaKas.CurrentRow != null)
            {
                rowNow = _dataAktivaKas.SelectedRows[0];
            }
            int aktivaKasID = (int)rowNow.Cells["idneraca_aktiva_allkas"].Value;
            NeracaAktiva.deleteKas(aktivaKasID);
            RefreshForm();
        }

        private void _neraca_aktiva_bKas_Load(object sender, EventArgs e)
        {

        }
    }
}
