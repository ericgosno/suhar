using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.EntityClient;
using System.Configuration;
using System.Data.SqlClient;
using StockModel;

namespace StockApps
{
    public partial class _administrator : Form
    {
        public _administrator()
        {
            InitializeComponent();
            checkConnection();
            _tConnectionCheck.Enabled = true;
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
                MessageBox.Show("Login Succesfully!");
                Session.UserLogin = userNow;
                _mainForm mainForm = new _mainForm();
                mainForm.FormClosed += new FormClosedEventHandler(mainForm_FormClosed);
                mainForm.Show();
                this.Hide();
            }
        }
        void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Logout Succesfully!");
            UserController.insertHistoryLogOut(Session.UserLogin.users_id,1);
            Session.UserLogin = null;
            this.Show();
            _tadmPass.Text = "";
            _tadmUser.Text = "";
        }

        private bool TestConnection()
        {
            try
            {
                identity ident = IdentityController.getIdentity();
                _lIdentityCompany.Text = ident.Identity_Company_Name;
                _lIdentityAddress.Text = ident.Identity_Address;
                _lIdentityCity.Text = ident.Identity_City;
                _lIdentityPhone.Text = ident.Identity_Phone;
                _lIdentityAddress.Visible = true;
                _lIdentityCity.Visible = true;
                _lIdentityCompany.Visible = true;
                _lIdentityPhone.Visible = true;
                _tadmPass.Enabled = true;
                _tadmUser.Enabled = true;
                _badmLogin.Enabled = true;
                return true;
            }
            catch (Exception ex)
            {
                _lIdentityAddress.Visible = false;
                _lIdentityCity.Visible = false;
                _lIdentityCompany.Visible = false;
                _lIdentityPhone.Visible = false;
                _tadmPass.Enabled = false;
                _tadmUser.Enabled = false;
                _badmLogin.Enabled = false;
                return false;
            }
        }

        private void checkConnection()
        {
            if (TestConnection())
            {
                _pConnectionStatus.Image = StockApps.Properties.Resources.green_light;
                _lConnectionStatus.Text = "Connect to Database Succesfully!";
            }
            else
            {
                _pConnectionStatus.Image = StockApps.Properties.Resources.red_light;
                _lConnectionStatus.Text = "Database Connection Failed!";
            }
        }
        private void _tConnectionCheck_Tick(object sender, EventArgs e)
        {
            checkConnection();
        }
    }
}
