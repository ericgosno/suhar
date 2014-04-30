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
    public partial class _neraca_aktiva : Form
    {
        public _neraca_aktiva()
        {
            InitializeComponent();
            //RefreshForm();
        }
        /*
        private void RefreshForm()
        {
        

            _dataAktiva.DataSource = NeracaAktiva.getAllAktiva();

            _dataAktiva.Columns["tahun_aktiva"].HeaderText = "Tahun Laporan";
            _dataAktiva.Columns["all_produk"].HeaderText = "ID PRODUCT";
            _dataAktiva.Columns["all_kas"].HeaderText = "ID KAS";
            _dataAktiva.Columns["all_piutang"].HeaderText = "ID PIUTANG";
            _dataAktiva.Columns["all_inventaris"].HeaderText = "ID INVENTARIS";


          
            _dataAktiva.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            _dataAktiva.Refresh();
        }
    */
        void suratJalan_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("TEST");

        }

   
        private void _btnAddProduk_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(_dateTime.Value.ToString("dd MMMM yyyy"));
            _neraca_aktiva_aProduk NeracaReportProduct = new _neraca_aktiva_aProduk(_dateTime.Value, this);
            NeracaReportProduct.Show(this);
            //sellingReportSJ_bForm_RptViewer nextForm = new sellingReportSJ_bForm_RptViewer(listBox1.SelectedValue.ToString());
            //NeracaReportProduct.FormClosed += new FormClosedEventHandler(suratJalan_FormClosed);
        }

        private void _neraca_aktiva_Load(object sender, EventArgs e)
        {
            var productList = NeracaAktiva.getIDProduct();
            //_cbproduct.DataSource = productList;
            //_cbproduct.DisplayMember = "id_allproduct";
            //_cbproduct.ValueMember = "id_allproduct";

            var kasList = NeracaAktiva.getIDKas();
            //_cbcash.DataSource = kasList;
            //_cbcash.DisplayMember = "id_allkas";
            //_cbcash.ValueMember = "id_allkas";

            var piutangList = NeracaAktiva.getIDPiutang();
           // _cbpiutang.DataSource = piutangList;
           // _cbpiutang.DisplayMember = "id_allpiutang";
            //_cbpiutang.ValueMember = "id_allpiutang";

            var inventList = NeracaAktiva.getIDInventaris();
            //_cbinventaris.DataSource = inventList;
           // _cbinventaris.DisplayMember = "id_allinventaris";
           // _cbinventaris.ValueMember = "id_allinventaris";
        }

        private void _btnAddKas_Click(object sender, EventArgs e)
        {
            _neraca_aktiva_bKas NeracaReportKas = new _neraca_aktiva_bKas(_dateTime.Value, this);
            NeracaReportKas.Show(this);
            //sellingReportSJ_bForm_RptViewer nextForm = new sellingReportSJ_bForm_RptViewer(listBox1.SelectedValue.ToString());
            //NeracaReportKas.FormClosed += new FormClosedEventHandler(suratJalan_FormClosed);
        }

        private void _btnAddPiutang_Click(object sender, EventArgs e)
        {
            _neraca_aktiva_cPiutang NeracaReportPiutang = new _neraca_aktiva_cPiutang(_dateTime.Value, this);
            NeracaReportPiutang.Show(this);
            //sellingReportSJ_bForm_RptViewer nextForm = new sellingReportSJ_bForm_RptViewer(listBox1.SelectedValue.ToString());
           // NeracaReportPiutang.FormClosed += new FormClosedEventHandler(suratJalan_FormClosed);
        }

        private void _btnAddInvetaris_Click(object sender, EventArgs e)
        {
            _neraca_aktiva_dInvetaris NeracaReportInventaris = new _neraca_aktiva_dInvetaris(_dateTime.Value, this);
            NeracaReportInventaris.Show(this);
            //sellingReportSJ_bForm_RptViewer nextForm = new sellingReportSJ_bForm_RptViewer(listBox1.SelectedValue.ToString());
           // NeracaReportInventaris.FormClosed += new FormClosedEventHandler(suratJalan_FormClosed);
        }
        /*
        private void _bbInsert_Click(object sender, EventArgs e)
        {
            //NeracaAktiva.insertAktiva(_dateTime.Value,_cbproduct.SelectedItem.ToString, _cbcash.SelectedItem.ToString, _cbpiutang.SelectedItem.ToString, _cbinventaris.SelectedItem.ToString);
            NeracaAktiva.insertAktiva(_dateTime.Value, _cbproduct.SelectedValue.ToString(), _cbcash.SelectedValue.ToString(), _cbpiutang.SelectedValue.ToString(), _cbinventaris.SelectedValue.ToString());
            RefreshForm();
        }
         * */


        private void _bbSReport_Click(object sender, EventArgs e)
        {
            //String akhirTahun = _dateTime.Value.ToString("yyyy-MM-dd");
            //MessageBox.Show(akhirTahun); 
            _neracaReport NeracaReport = new _neracaReport(_dateTime.Value, this);
            NeracaReport.Show(this);
        }

    
       
        
     
    }
}
