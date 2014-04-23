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
    public partial class _administrator : Form
    {
        public _administrator()
        {
            InitializeComponent();
            identity ident = IdentityController.getIdentity();
            _lIdentityCompany.Text = ident.Identity_Company_Name;
            _lIdentityAddress.Text = ident.Identity_Address;
            _lIdentityCity.Text = ident.Identity_City;
            _lIdentityPhone.Text = ident.Identity_Phone;
        }

        private void _badmLogin_Click(object sender, EventArgs e)
        {
            user userNow = UserController.Login(_tadmUser.Text, _tadmPass.Text);
            if (userNow == null)
            {
                MessageBox.Show("Wrong Username/Password!");
            }
            else
            {
                MessageBox.Show("User Berhasil Login!");
                Session.UserLogin = userNow;
                _mainForm mainForm = new _mainForm();
                mainForm.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
                mainForm.Show();
                this.Hide();
            }
        }
        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("User Berhasil Logout!");
            UserController.insertHistoryLogOut(Session.UserLogin.users_id,1);
            Session.UserLogin = null;
            this.Show();
            _tadmPass.Text = "";
            _tadmUser.Text = "";
        }

        private void _administrator_Load(object sender, EventArgs e)
        {

        }


    }
}
