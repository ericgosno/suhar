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
    public partial class _purchasing_biaya_lain : Form
    {
        public _purchasing_biaya_lain()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtkategori.Text == "")
            {
                MessageBox.Show("Name cannot be null!");
                return;
            }
            ControllerBiayaLain.insertBiayaLain(txtkategori.Text);
            RefreshForm();
        }

        private void RefreshForm()
        {
            txtkategori.Text = "";
           
            dgvKategori.DataSource = ControllerBiayaLain
                .getKategori();

            dgvKategori.Columns["nama_biaya_lain"].HeaderText = "Name";
            dgvKategori.Columns["Kategori_lain_ID"].Visible = false;
            dgvKategori.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            dgvKategori.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;
            try
            {
                DataGridViewRow rowNow = null;
                if (dgvKategori.CurrentCell != null)
                {
                    rowNow = dgvKategori.SelectedCells[0].OwningRow;
                }
                else if (dgvKategori.CurrentRow != null)
                {
                    rowNow = dgvKategori.SelectedRows[0];
                }
                int SupplierID = (int)rowNow.Cells["Kategori_lain_ID"].Value;
      
                ControllerBiayaLain.deleteKategori(SupplierID);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a Row First!");
            }
        }
    }
}
