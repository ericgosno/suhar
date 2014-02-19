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
                Session.UserLogin = userNow;
                _mainForm mainForm = new _mainForm();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
