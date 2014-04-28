using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MySqlBackupTestApp
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            lbVersion.Text = "for Version " + MySql.Data.MySqlClient.MySqlBackup.Version;
        }
    }
}
