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
    public partial class _identityForm : Form
    {
        public _identityForm()
        {
            InitializeComponent();
            identity identityNow = IdentityController.getIdentity();
            _tOwnerAdd.Text = identityNow.Identity_Address;
            _tOwnerCity.Text = identityNow.Identity_City;
            _tOwnerComp.Text = identityNow.Identity_Company_Name;
            _tOwnerFax.Text = identityNow.Identity_Fax;
            _tOwnerName.Text = identityNow.Identity_Name;
            _tOwnerNPWP.Text = identityNow.Identity_NPWP;
            _tOwnerPhone.Text = identityNow.Identity_Phone;
            _tOwnerPostal.Text = identityNow.Identity_Postal_Code;
        }

        private void _tOwnerUpdate_Click(object sender, EventArgs e)
        {
            IdentityController.updateIdentity(_tOwnerName.Text, _tOwnerComp.Text, _tOwnerAdd.Text, _tOwnerPhone.Text, _tOwnerFax.Text, _tOwnerCity.Text, _tOwnerNPWP.Text, _tOwnerPostal.Text);
            MessageBox.Show("Update Succesfully!");
        }

    }
}
