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
    public partial class _neraca_aktiva_cPiutang : Form
    {
        _neraca_aktiva parent;
        DateTime tahun;
        public _neraca_aktiva_cPiutang(DateTime timeYear, _neraca_aktiva parent)
        {
            InitializeComponent();
            tahun = timeYear;
            RefreshForm();
        }

        private void RefreshForm()
        {
            _idAktiva.Text = "";
            _txtnama.Text = "";
            _txtnota.Text = "";
            _txtjumlah.Text = "";
            _txtYear.Text = tahun.ToString("dd MMMM yyyy");

            _dataAktivaPiutang.DataSource = NeracaAktiva.getIDPiutang();

            _dataAktivaPiutang.Columns["id_allpiutang"].HeaderText = "No.";
            _dataAktivaPiutang.Columns["nama"].HeaderText = "Nama";
            _dataAktivaPiutang.Columns["nota"].HeaderText = "No. Nota";
            _dataAktivaPiutang.Columns["jumlah"].HeaderText = "Jumlah";
            _dataAktivaPiutang.Columns["tahun_aktiva"].HeaderText = "Date";

            _dataAktivaPiutang.Columns["idneraca_aktiva_allpiutang"].Visible = false;

            /*
              _dgvspListSupplier.Columns["products"].Visible = false;
              _dgvspListSupplier.Columns["supplier_transaction"].Visible = false;
             * */
            _dataAktivaPiutang.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            _dataAktivaPiutang.Refresh();
        }

        private void _bbInsert_Click(object sender, EventArgs e)
        {
            if (_idAktiva.Text == "")
            {
                MessageBox.Show("Name cannot be null!");
                return;
            }
            NeracaAktiva.insertAktivaPiutang(_idAktiva.Text, _txtnama.Text, _txtnota.Text, decimal.Parse(_txtjumlah.Text), tahun);
            RefreshForm();
        }

        private void _neraca_aktiva_cPiutang_Load(object sender, EventArgs e)
        {

        }

        private void _bbDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowNow = null;
            if (_dataAktivaPiutang.CurrentCell != null)
            {
                rowNow = _dataAktivaPiutang.SelectedCells[0].OwningRow;
            }
            else if (_dataAktivaPiutang.CurrentRow != null)
            {
                rowNow = _dataAktivaPiutang.SelectedRows[0];
            }
            int aktivaPiuID = (int)rowNow.Cells["idneraca_aktiva_allpiutang"].Value;
            NeracaAktiva.deletePiutang(aktivaPiuID);
            RefreshForm();
        }
    }
}
