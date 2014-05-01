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
    public partial class _neraca_passiva_HPajak : Form
    {
        _neraca_passiva parent;
        DateTime tahun;
        public _neraca_passiva_HPajak(DateTime timeYear, _neraca_passiva parent)
        {
            InitializeComponent();
            tahun = timeYear;
            RefreshForm();
        }

        private void RefreshForm()
        {
            _nourut.Text = "";
            _txtket.Text = "";
            _txtjumlah.Text = "";
            _txtYear.Text = tahun.ToString("dd MMMM yyyy");

            _dataPassivaHutangPajak.DataSource = NeracaPassiva.getAllPassivaPajak ();

            _dataPassivaHutangPajak.Columns["nourut"].HeaderText = "No.";
            _dataPassivaHutangPajak.Columns["keterangan"].HeaderText = "Keterangan";

            _dataPassivaHutangPajak.Columns["jumlah"].HeaderText = "Jumlah";
            _dataPassivaHutangPajak.Columns["tahun_passiva"].HeaderText = "Date";

            _dataPassivaHutangPajak.Columns["idneraca_passiva_pajak"].Visible = false;

            /*
              _dgvspListSupplier.Columns["products"].Visible = false;
              _dgvspListSupplier.Columns["supplier_transaction"].Visible = false;
             * */
            _dataPassivaHutangPajak.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            _dataPassivaHutangPajak.Refresh();
        }


        private void _neraca_passiva_HPajak_Load(object sender, EventArgs e)
        {

        }

        private void _bbInsert_Click(object sender, EventArgs e)
        {
            if (_txtket.Text == "")
            {
                MessageBox.Show("Cannot be null!");
                return;
            }
            NeracaPassiva.insertPassivaHPajak(_nourut.Text, _txtket.Text, decimal.Parse(_txtjumlah.Text), tahun);
            RefreshForm();
        }

        private void _bbDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowNow = null;
            if (_dataPassivaHutangPajak.CurrentCell != null)
            {
                rowNow = _dataPassivaHutangPajak.SelectedCells[0].OwningRow;
            }
            else if (_dataPassivaHutangPajak.CurrentRow != null)
            {
                rowNow = _dataPassivaHutangPajak.SelectedRows[0];
            }
            int aktivaPiuID = (int)rowNow.Cells["idneraca_passiva_pajak"].Value;
            NeracaPassiva.deleteHPajak(aktivaPiuID);
            RefreshForm();
        }
    }
}
