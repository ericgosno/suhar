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
        private bool isConnected;
        public _administrator()
        {
            InitializeComponent();
            isConnected = false;
            //EncryptFile();
            SetDatabaseLocation();
            checkConnection();
            _tConnectionCheck.Enabled = true;
        }

        private void SetDatabaseLocation()
        {
            string output = DecryptFile();
            string[] constring = output.Split(new char[] { ';' });
            string dbHost = constring[0];
            string dbUsername = constring[1];
            string dbPassword = constring[2];
            string dbDatabase = constring[3];

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["stockappsEntities"].ConnectionString = "metadata=res://*/StockApps.csdl|res://*/StockApps.ssdl|res://*/StockApps.msl;provider=MySql.Data.MySqlClient;provider connection string=\"server=" + dbHost + ";User Id=" + dbUsername + ";password=" + dbPassword + ";database=" + dbDatabase +  ";Persist Security Info=True\"";
            connectionStringsSection.ConnectionStrings["stockappsEntities"].ProviderName = "System.Data.EntityClient";
            connectionStringsSection.ConnectionStrings["StockApps.Properties.Settings.stockappsConnectionString"].ConnectionString = "server=" + dbHost + ";User Id=" + dbUsername + ";password=" + dbPassword + ";Persist Security Info=True;database=" + dbDatabase;
            connectionStringsSection.ConnectionStrings["StockApps.Properties.Settings.stockappsConnectionString"].ProviderName = "MySql.Data.MySqlClient";
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            //ConnectionController.ChangeConnectionString(dbHost, dbUsername, dbPassword, dbDatabase); 
        }
        private void EncryptFile()
        {
            string  passPhrase      = "R4nD0mP4sSW0RdH3R3";        // can be any string
            string  saltValue       = "s@1tV4lu3";        // can be any string
            string  hashAlgorithm   = "SHA1";             // can be "MD5"
            int     passwordIterations= 2;                // can be any number
            string  initVector      = "@1B2c3D4e5F6g7H8"; // must be 16 bytes
            int     keySize         = 256;                // can be 192 or 128

            string line;
            List<string> output = new List<string>();

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("localization.3nc");
            while ((line = file.ReadLine()) != null)
            {
                output.Add(RijndaelSecurity.Encrypt(line, passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize));
            }
            file.Close();

            System.IO.File.WriteAllLines("localization.3nc", output);
        }

        private string DecryptFile()
        {
            string passPhrase = "R4nD0mP4sSW0RdH3R3";        // can be any string
            string saltValue = "s@1tV4lu3";        // can be any string
            string hashAlgorithm = "SHA1";             // can be "MD5"
            int passwordIterations = 2;                // can be any number
            string initVector = "@1B2c3D4e5F6g7H8"; // must be 16 bytes
            int keySize = 256;                // can be 192 or 128

            string line;
            string output = "";

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("localization.3nc");
            while ((line = file.ReadLine()) != null)
            {
                output = RijndaelSecurity.Decrypt(line, passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);
            }
            file.Close();

            return output;
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
            SetDatabaseLocation(); 
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
                isConnected = true;
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
                isConnected = false;
                return false;
            }
        }

        private void checkConnection()
        {
            _lConnectionStatus.Text = "Checking Database....";
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

        private void changeDatabaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ChangeDatabase ChangeDB = new _ChangeDatabase();
            ChangeDB.FormClosed += new FormClosedEventHandler(ChangeDBConnection_FormClosed);
            ChangeDB.Show();
        }

        void ChangeDBConnection_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetDatabaseLocation();
            checkConnection();
        }
    }
}
