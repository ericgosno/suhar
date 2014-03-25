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
    public partial class _administratorList : Form
    {
        private int selectedID;
        public _administratorList()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void RefreshForm()
        {
            selectedID = -1;
            _tadmCEmail.Text = "";
            _tadmCName.Text = "";
            _tadmCPass.Text = "";
            _tadmCPassConf.Text = "";
            _cbadmCCategory.SelectedIndex=-1;
            var privList = UserController.getPrivilege();
            _cbadmCCategory.DataSource = privList;
            _cbadmCCategory.DisplayMember = "Privilege_Name";
            _cbadmCCategory.ValueMember = "Privilege_ID";
            
            var userList = UserController.getUser();
            
            var list = userList.Join(privList,
                                user => user.Privilege_ID,
                                privilege => privilege.Privilege_ID,
                                (user, privilege) =>
                                    new { users_id = user.users_id, users_username = user.users_username, users_email = user.users_email, privilege_name = privilege.Privilege_name });
            
            _dataAdministrator.DataSource = list;
            _dataAdministrator.Columns["users_username"].HeaderText = "Username";
            _dataAdministrator.Columns["users_email"].HeaderText = "Email";
            _dataAdministrator.Columns["privilege_name"].HeaderText = "Category";
            _dataAdministrator.Columns["users_id"].Visible = false;
            _dataAdministrator.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void _administratorList_Load(object sender, EventArgs e)
        {

        }

        private void _badmCInsert_Click(object sender, EventArgs e)
        {
            if (_tadmCPass.Text.Equals(_tadmCPassConf.Text))
            {
                UserController.insertUser(_tadmCName.Text, _tadmCPass.Text, Convert.ToInt32(_cbadmCCategory.SelectedValue), _tadmCEmail.Text);
                RefreshForm();
            }
            else MessageBox.Show("Wrong Password Confirmation");

        }

        private void _badmCDelete_Click(object sender, EventArgs e)
        {
            try
            {
                UserController.deleteUser((int)_dataAdministrator.SelectedRows[0].Cells["users_id"].Value);
                RefreshForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You must select a Row First!");
            }
        }

        private void _badmCReset_Click(object sender, EventArgs e)
        {
            selectedID = -1;
            _tadmCEmail.Text = "";
            _tadmCName.Text = "";
            _tadmCPass.Text = "";
            _tadmCPassConf.Text = "";
            _cbadmCCategory.SelectedIndex = -1;
        }

        private void _dataAdministrator_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var userNow = UserController.getUser((int)_dataAdministrator.SelectedRows[0].Cells["users_id"].Value).First();
                selectedID = userNow.users_id;
                _tadmCName.Text = userNow.users_username;
                _tadmCEmail.Text = userNow.users_email;
                _tadmCPass.Text = "";
                _tadmCPassConf.Text = "";
                _cbadmCCategory.SelectedValue = userNow.privilege.Privilege_ID;
            }
            catch (Exception ex)
            {
            }
        }

        private void _badmCUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == -1)
            {
                MessageBox.Show("You must select a Row First!");
                return;
            }
            if (_tadmCPass.Text == "" || _tadmCPass.Text.Equals(_tadmCPassConf.Text))
            {
                UserController.updateUser(selectedID, _tadmCName.Text, _tadmCPass.Text, _tadmCEmail.Text, Convert.ToInt32(_cbadmCCategory.SelectedValue));
                RefreshForm();
            }
            else MessageBox.Show("Wrong Password Confirmation");
        }

    }
}
