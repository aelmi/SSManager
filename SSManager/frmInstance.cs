using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSManager
{
    public partial class frmInstance : Form
    {
        private string serverName;
        public string ServerName { get { return serverName; } }
        public frmInstance()
        {
            InitializeComponent();
        }

        private void btnLocalInstance_Click(object sender, EventArgs e)
        {
            RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey key = baseKey.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL");

            if (lbInstance.Items.Count > 0)
                lbInstance.Items.Clear();

            foreach (string s in key.GetValueNames())
                lbInstance.Items.Add(s);

            key.Close();
            baseKey.Close();
         }

        private void btnOk_Click(object sender, EventArgs e)
        {
            serverName = lbInstance.SelectedItem.ToString();
            this.Close();
        }

      
    }
}
