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
    public partial class frmRenameDB : Form
    {
        MssqlOperation mssqlOperation;

        public frmRenameDB(MssqlOperation mssql)
        {
            InitializeComponent();
            this.mssqlOperation = mssql;
            txtOldDBName.Text = mssql.DatabaseName;            
        }

        private void btnForceRename_Click(object sender, EventArgs e)
        {
            mssqlOperation.ForceRenameDB(txtOldDBName.Text, txtNewDBName.Text);
            MessageBox.Show("Database is successfully renamed", "Done");
        }

        private void frmRenameDB_Load(object sender, EventArgs e)
        {
            txtNewDBName.Select();
        }

  
    }
}
