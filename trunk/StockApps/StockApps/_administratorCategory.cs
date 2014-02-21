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
    public partial class _administratorCategory : Form
    {
        private int selectedID;
        public _administratorCategory()
        {
            InitializeComponent();
            RefreshForm();
        }
        private void RefreshForm()
        {

            _chAC1.Checked = false;
            _chAC2.Checked = false;
            _chAC3.Checked = false;
            _chAC4.Checked = false;
            _chAC5.Checked = false;
            _chAC6.Checked = false;
            _chAC7.Checked = false;
            _chACAll.Checked = false;
            selectedID = -1;
            _tadmACName.Text = "";

            _dataCategoryProduct.DataSource = UserController.getPrivilege();
            var col3 = new DataGridViewTextBoxColumn();
            /*
              col3.HeaderText = "Privilege Authorization";
              col3.Name = "Privilege Authorization";

             _dataCategoryProduct.Columns.AddRange(new DataGridViewColumn[] {col3});
             foreach (DataGridViewRow row in _dataCategoryProduct.Rows)
             {
                 //try
                 //{
                     string auth_str = "";
                     if (row.Cells["Privilege_ID"].Value == null || row.Cells["Privilege_ID"].Value.ToString().Length <= 0) continue;
                     var newCell = new DataGridViewTextBoxCell();
                      _dataCategoryProduct.Rows[row.
                     row.Cells.Add(newCell);

                     var list_auth = UserController.getPrivilegeAuthorization((int)row.Cells["Privilege_ID"].Value);
                     foreach (privilege_authorization priv_auth in list_auth)
                     {
                         if (auth_str != "") auth_str += " , ";
                         auth_str += "Aaa";
                     }
                    
                     row.Cells["privilege_authorization"] = new DataGridViewTextBoxCell();
                     row.Cells["privilege_authorization"].ValueType = typeof(string);
                     row.Cells["privilege_authorization"].Value = "aaa";
                     //MessageBox.Show(row.Cells["privilege_authorization"].Value.ToString());
                 //}
                 //catch (Exception ex) { continue; }
             }*/
              _dataCategoryProduct.Columns["Privilege_Name"].HeaderText = "Privilege Name";
             _dataCategoryProduct.Columns["privilege_authorization"].Visible = false;
             _dataCategoryProduct.Columns["Privilege_ID"].Visible = false;
             _dataCategoryProduct.Columns["users"].Visible = false;
              
             _dataCategoryProduct.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

             _dataCategoryProduct.Refresh();
        }

        private void _chAC8_CheckedChanged(object sender, EventArgs e)
        {
            if (!_chACAll.Checked)
            {
                _chAC1.Checked = false;
                _chAC2.Checked = false;
                _chAC3.Checked = false;
                _chAC4.Checked = false;
                _chAC5.Checked = false;
                _chAC6.Checked = false;
                _chAC7.Checked = false;
            }
            else
            {
                _chAC1.Checked = true;
                _chAC2.Checked = true;
                _chAC3.Checked = true;
                _chAC4.Checked = true;
                _chAC5.Checked = true;
                _chAC6.Checked = true;
                _chAC7.Checked = true;
            }
        }

        private void _badmACInsert_Click(object sender, EventArgs e)
        {
            List<int> listPrivileges = new List<int>();
            if (_chAC1.Checked) listPrivileges.Add(1);
            if (_chAC2.Checked) listPrivileges.Add(2);
            if (_chAC3.Checked) listPrivileges.Add(3);
            if (_chAC4.Checked) listPrivileges.Add(4);
            if (_chAC5.Checked) listPrivileges.Add(5);
            if (_chAC6.Checked) listPrivileges.Add(6);
            if (_chAC7.Checked) listPrivileges.Add(7);
            UserController.insertPrivilege(_tadmACName.Text, listPrivileges);
            RefreshForm();
        }

        private void _badmACDelete_Click(object sender, EventArgs e)
        {
            try
            {
                UserController.deletePrivilege((int)_dataCategoryProduct.SelectedRows[0].Cells["Privilege_ID"].Value);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a Row First!");
            }
        }

        private void _dataCategoryProduct_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var privNow = UserController.getPrivilege((int)_dataCategoryProduct.SelectedRows[0].Cells["Privilege_ID"].Value).First();
                selectedID = privNow.Privilege_ID;
                _tadmACName.Text = privNow.Privilege_name;
                 _chAC1.Checked = false;
                _chAC2.Checked = false;
                _chAC3.Checked = false;
                _chAC4.Checked = false;
                _chAC5.Checked = false;
                _chAC6.Checked = false;
                _chAC7.Checked = false;
                _chACAll.Checked = false;
                foreach (privilege_authorization privAuth in privNow.privilege_authorization)
                {
                    if (privAuth.Authorization_ID == 1) _chAC1.Checked = true;
                    if (privAuth.Authorization_ID == 2) _chAC2.Checked = true;
                    if (privAuth.Authorization_ID == 3) _chAC3.Checked = true;
                    if (privAuth.Authorization_ID == 4) _chAC4.Checked = true;
                    if (privAuth.Authorization_ID == 5) _chAC5.Checked = true;
                    if (privAuth.Authorization_ID == 6) _chAC6.Checked = true;
                    if (privAuth.Authorization_ID == 7) _chAC7.Checked = true;
                }

            }
            catch (Exception ex)
            {
            }
        }

        private void _badmACReset_Click(object sender, EventArgs e)
        {
            _chAC1.Checked = false;
            _chAC2.Checked = false;
            _chAC3.Checked = false;
            _chAC4.Checked = false;
            _chAC5.Checked = false;
            _chAC6.Checked = false;
            _chAC7.Checked = false;
            _chACAll.Checked = false;
            selectedID = -1;
            _tadmACName.Text = "";
        }

        private void _badmACUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("You must select a Row First!");
                return;
            }
            List<int> listPrivileges = new List<int>();
            if (_chAC1.Checked) listPrivileges.Add(1);
            if (_chAC2.Checked) listPrivileges.Add(2);
            if (_chAC3.Checked) listPrivileges.Add(3);
            if (_chAC4.Checked) listPrivileges.Add(4);
            if (_chAC5.Checked) listPrivileges.Add(5);
            if (_chAC6.Checked) listPrivileges.Add(6);
            if (_chAC7.Checked) listPrivileges.Add(7);
            UserController.updatePrivilege(selectedID, _tadmACName.Text, listPrivileges);
            RefreshForm();
        }

    }
}
