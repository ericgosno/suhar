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
    public partial class _neraca_aktiva_dInvetaris : Form
    {
        _neraca_aktiva parent;
        DateTime tahun;
        public _neraca_aktiva_dInvetaris(DateTime timeYear, _neraca_aktiva parent)
        {
            InitializeComponent();
            tahun = timeYear;
            RefreshForm();
        }

        private void RefreshForm()
        {
            _idAktiva.Text = "";
            _txtnama.Text = "";
            _txtjumlah.Text = "";
            _txtYear.Text = tahun.ToString("dd MMMM yyyy");

            _dataAktivaInventaris.DataSource = NeracaAktiva.getIDInventaris();

            _dataAktivaInventaris.Columns["id_allinventaris"].HeaderText = "No.";
            _dataAktivaInventaris.Columns["nama"].HeaderText = "Nama";
            _dataAktivaInventaris.Columns["jumlah"].HeaderText = "Jumlah";
            _dataAktivaInventaris.Columns["status"].HeaderText = "Status";
            _dataAktivaInventaris.Columns["tahun_aktiva"].HeaderText = "Date";

            _dataAktivaInventaris.Columns["idneraca_aktiva_allinventaris"].Visible = false;

            /*
              _dgvspListSupplier.Columns["products"].Visible = false;
              _dgvspListSupplier.Columns["supplier_transaction"].Visible = false;
             * */
            _dataAktivaInventaris.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            _dataAktivaInventaris.Refresh();
        }

        private void _bbInsert_Click(object sender, EventArgs e)
        {
            if (_idAktiva.Text == "")
            {
                MessageBox.Show("Name cannot be null!");
                return;
            }
            int mystat = 0;
            if (_cbstatus.SelectedItem == "Ditambah")
            {
                mystat = 1;
            }
            NeracaAktiva.insertAktivainventaris(_idAktiva.Text, _txtnama.Text, decimal.Parse(_txtjumlah.Text), mystat, tahun);
            RefreshForm();
        }

        private void _neraca_aktiva_dInvetaris_Load(object sender, EventArgs e)
        {

        }

        private void _bbDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowNow = null;
            if (_dataAktivaInventaris.CurrentCell != null)
            {
                rowNow = _dataAktivaInventaris.SelectedCells[0].OwningRow;
            }
            else if (_dataAktivaInventaris.CurrentRow != null)
            {
                rowNow = _dataAktivaInventaris.SelectedRows[0];
            }
            int aktivainventID = (int)rowNow.Cells["idneraca_aktiva_allinventaris"].Value;
            NeracaAktiva.deleteInventaris(aktivainventID);
            RefreshForm();
        }
    }
}
