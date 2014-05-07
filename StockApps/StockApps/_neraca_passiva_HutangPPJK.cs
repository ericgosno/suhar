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
    public partial class _neraca_passiva_HutangPPJK : Form
    {
        _neraca_passiva parent;
        DateTime tahun;
        public _neraca_passiva_HutangPPJK(DateTime timeYear, _neraca_passiva parent)
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

            _dataPassivaHutangPPJK.DataSource = NeracaPassiva.getAllPassivaPPJK();

            _dataPassivaHutangPPJK.Columns["nourut_ppjk"].HeaderText = "No.";
            _dataPassivaHutangPPJK.Columns["nota_ppjk"].HeaderText = "Nota";
            _dataPassivaHutangPPJK.Columns["nama_ppjk"].HeaderText = "Nama";
            _dataPassivaHutangPPJK.Columns["jumlah_ppjk"].HeaderText = "Jumlah";
            _dataPassivaHutangPPJK.Columns["tahun_passiva"].HeaderText = "Date";

            _dataPassivaHutangPPJK.Columns["idneraca_passiva_ppjk"].Visible = false;

            /*
              _dgvspListSupplier.Columns["products"].Visible = false;
              _dgvspListSupplier.Columns["supplier_transaction"].Visible = false;
             * */
            _dataPassivaHutangPPJK.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            _dataPassivaHutangPPJK.Refresh();
        }

        private void _neraca_passiva_HutangPPJK_Load(object sender, EventArgs e)
        {

        }

        private void _bbInsert_Click(object sender, EventArgs e)
        {
            if (_txtnama.Text == "")
            {
                MessageBox.Show("Name cannot be null!");
                return;
            }
            NeracaPassiva.insertPassivaPPJK(_nourut.Text, _txtnota.Text, _txtnama.Text, decimal.Parse(_txtjumlah.Text), tahun);
            RefreshForm();
        }

        private void _bbDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowNow = null;
            if (_dataPassivaHutangPPJK.CurrentCell != null)
            {
                rowNow = _dataPassivaHutangPPJK.SelectedCells[0].OwningRow;
            }
            else if (_dataPassivaHutangPPJK.CurrentRow != null)
            {
                rowNow = _dataPassivaHutangPPJK.SelectedRows[0];
            }
            int aktivaPiuID = (int)rowNow.Cells["idneraca_passiva_ppjk"].Value;
            NeracaPassiva.deletePPJK(aktivaPiuID);
            RefreshForm();
        }
    }
}
