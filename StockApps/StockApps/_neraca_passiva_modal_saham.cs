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
    public partial class _neraca_passiva_modal_saham : Form
    {
        _neraca_passiva parent;
        DateTime tahun;
        public _neraca_passiva_modal_saham(DateTime timeYear, _neraca_passiva parent)
        {
            InitializeComponent();
            tahun = timeYear;
            RefreshForm();
        }

        private void RefreshForm()
        {
            _nourut.Text = "";
            _txtnama.Text = "";
            _txtjumlah.Text = "";
            _txtYear.Text = tahun.ToString("dd MMMM yyyy");

            _dataPassivaModalSaham.DataSource = NeracaPassiva.getAllPassivaSaham();

            _dataPassivaModalSaham.Columns["nourut"].HeaderText = "No.";
            _dataPassivaModalSaham.Columns["nama"].HeaderText = "Nama";
        
            _dataPassivaModalSaham.Columns["jumlah"].HeaderText = "Jumlah";
            _dataPassivaModalSaham.Columns["tahun_passiva"].HeaderText = "Date";

            _dataPassivaModalSaham.Columns["idneraca_passiva_saham"].Visible = false;

            /*
              _dgvspListSupplier.Columns["products"].Visible = false;
              _dgvspListSupplier.Columns["supplier_transaction"].Visible = false;
             * */
            _dataPassivaModalSaham.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            _dataPassivaModalSaham.Refresh();
        }

        private void _neraca_passiva_modal_saham_Load(object sender, EventArgs e)
        {

        }

        private void _bbInsert_Click(object sender, EventArgs e)
        {
            if (_txtnama.Text == "")
            {
                MessageBox.Show("Name cannot be null!");
                return;
            }
            NeracaPassiva.insertPassivaSaham(_nourut.Text, _txtnama.Text, decimal.Parse(_txtjumlah.Text), tahun);
            RefreshForm();
        }

        private void _bbDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowNow = null;
            if (_dataPassivaModalSaham.CurrentCell != null)
            {
                rowNow = _dataPassivaModalSaham.SelectedCells[0].OwningRow;
            }
            else if (_dataPassivaModalSaham.CurrentRow != null)
            {
                rowNow = _dataPassivaModalSaham.SelectedRows[0];
            }
            int aktivaPiuID = (int)rowNow.Cells["idneraca_passiva_saham"].Value;
            NeracaPassiva.deleteSaham(aktivaPiuID);
            RefreshForm();
        }
    }
}
