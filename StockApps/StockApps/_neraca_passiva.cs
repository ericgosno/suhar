using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockApps
{
    public partial class _neraca_passiva : Form
    {
        public _neraca_passiva()
        {
            InitializeComponent();
        }

        private void _neraca_passiva_Load(object sender, EventArgs e)
        {

        }

        private void _btnAddProduk_Click(object sender, EventArgs e)
        {
            _neraca_passiva_HU NeracaReportHU = new _neraca_passiva_HU(_dateTime.Value, this);
            NeracaReportHU.Show(this);
        }

        private void _btnAddPPJK_Click(object sender, EventArgs e)
        {
            _neraca_passiva_HutangPPJK NeracaReportPPJK = new _neraca_passiva_HutangPPJK(_dateTime.Value, this);
            NeracaReportPPJK.Show(this);
        }

        private void _btnAddPajak_Click(object sender, EventArgs e)
        {
            _neraca_passiva_HPajak NeracaReportPajak = new _neraca_passiva_HPajak(_dateTime.Value, this);
            NeracaReportPajak.Show(this);
        }

        private void _btnAddSaham_Click(object sender, EventArgs e)
        {
            _neraca_passiva_modal_saham NeracaReportMS = new _neraca_passiva_modal_saham(_dateTime.Value, this);
            NeracaReportMS.Show(this);
        }

        private void _bbSReport_Click(object sender, EventArgs e)
        {
            passiva_report NeracaReport = new passiva_report(_dateTime.Value, this);
            NeracaReport.Show(this);
        }
    }
}
