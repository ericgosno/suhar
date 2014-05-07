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
    public partial class _ChangeDatabase : Form
    {
        private string dbSecurityCode;
        public _ChangeDatabase()
        {
            InitializeComponent();
            string output = DecryptFile();
            string[] constring = output.Split(new char[] { ';' });
            string dbHost = constring[0];
            string dbUsername = constring[1];
            string dbPassword = constring[2];
            string dbDatabase = constring[3];
            dbSecurityCode = constring[5];
            string dbSecurityHint = constring[4];
            _tHost.Text = dbHost;
            _tUsername.Text = dbUsername;
            _tDatabase.Text = dbDatabase;
            _lSecurityHint.Text = dbSecurityHint;
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
                //output = RijndaelSecurity.Decrypt(line, passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);
            }
            file.Close();

            return output;
        }

        private void EncryptFile(string newDBHost, string newDBUsername, string newDBPassword,string newDBDatabase, string newDBSecurityHint,string newDBSecurityCode)
        {
            string passPhrase = "R4nD0mP4sSW0RdH3R3";        // can be any string
            string saltValue = "s@1tV4lu3";        // can be any string
            string hashAlgorithm = "SHA1";             // can be "MD5"
            int passwordIterations = 2;                // can be any number
            string initVector = "@1B2c3D4e5F6g7H8"; // must be 16 bytes
            int keySize = 256;                // can be 192 or 128

            string line;
            List<string> output = new List<string>();
            string newConString = newDBHost + ";" + newDBUsername + ";" + newDBPassword + ";" + newDBDatabase + ";" + newDBSecurityHint + ";" + newDBSecurityCode;
            //output.Add(RijndaelSecurity.Encrypt(newConString, passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize));

            System.IO.File.WriteAllLines("localization.3nc", output);
        }

        private void _bUpdate_Click(object sender, EventArgs e)
        {
            if (_tDatabase.Text == "" || _tHost.Text == "" || _tPassword.Text == "" || _tSecurityCheck.Text == "" || _tSecurityCode.Text == "")
            {
                MessageBox.Show("All data must be filled!");
                return;
            }
            if (_tSecurityCheck.Text.ToLower() != dbSecurityCode.ToLower())
            {
                MessageBox.Show("Security Code Mismatch!");
                return;
            }
            EncryptFile(_tHost.Text, _tUsername.Text, _tPassword.Text, _tDatabase.Text, _tSecurityHint.Text, _tSecurityCode.Text);
            MessageBox.Show("Update Database Connection Success! Restart Application may be Needed to Refresh Connection");
            this.Close();
        }

    }
}
