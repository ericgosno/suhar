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
    public partial class _neraca_passiva_HU : Form
    {
        _neraca_passiva parent;
        DateTime tahun;
        public _neraca_passiva_HU(DateTime timeYear, _neraca_passiva parent)
        {
            InitializeComponent();
            tahun = timeYear;
            RefreshForm();
        }
        private void RefreshForm()
        {
            _nourut.Text = "";
            _txtnota.Text = "";
            _txtnama.Text = "";
            _txtjumlah.Text = "";
            _txtYear.Text = tahun.ToString("dd MMMM yyyy");

            _dataPassivaHutangUsaha.DataSource = NeracaPassiva.getAllPassivaUsaha();

            _dataPassivaHutangUsaha.Columns["nourut_usaha"].HeaderText = "No.";
            _dataPassivaHutangUsaha.Columns["nota_usaha"].HeaderText = "Nota";
            _dataPassivaHutangUsaha.Columns["nama_usaha"].HeaderText = "Nama";
            _dataPassivaHutangUsaha.Columns["jumlah_usaha"].HeaderText = "Jumlah";
            _dataPassivaHutangUsaha.Columns["tahun_passiva"].HeaderText = "Date";

            _dataPassivaHutangUsaha.Columns["idneraca_passiva_usaha"].Visible = false;

            /*
              _dgvspListSupplier.Columns["products"].Visible = false;
              _dgvspListSupplier.Columns["supplier_transaction"].Visible = false;
             * */
            _dataPassivaHutangUsaha.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            _dataPassivaHutangUsaha.Refresh();
        }

        private void _neraca_passiva_HU_Load(object sender, EventArgs e)
        {

        }

        private void _bbInsert_Click(object sender, EventArgs e)
        {
            if (_txtnama.Text == "")
            {
                MessageBox.Show("Name cannot be null!");
                return;
            }
            NeracaPassiva.insertPassivaHU(_nourut.Text, _txtnota.Text, _txtnama.Text, decimal.Parse(_txtjumlah.Text), tahun);
            RefreshForm();
        }

        private void _bbDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowNow = null;
            if (_dataPassivaHutangUsaha.CurrentCell != null)
            {
                rowNow = _dataPassivaHutangUsaha.SelectedCells[0].OwningRow;
            }
            else if (_dataPassivaHutangUsaha.CurrentRow != null)
            {
                rowNow = _dataPassivaHutangUsaha.SelectedRows[0];
            }
            int aktivaPiuID = (int)rowNow.Cells["idneraca_passiva_usaha"].Value;
            NeracaPassiva.deleteHUsaha(aktivaPiuID);
            RefreshForm();
        }
    }
}
