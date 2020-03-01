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
    public partial class frmSearchInSPFX : Form
    {
        MssqlOperation mssqlOperation;

        public frmSearchInSPFX()
        {
            InitializeComponent();
        }

        public frmSearchInSPFX(MssqlOperation sqlOperation)
        {
            InitializeComponent();
            mssqlOperation = sqlOperation;
        }



        private void btnFind_Click(object sender, EventArgs e)
        {            
            List<string> DBobjects = new List<string>();

            if (chkSP.Checked)
                DBobjects.Add("'P'");
            if (chkTableValuedFunction.Checked)
                DBobjects.Add("'TF'");
            if (chkScalarValuedFunction.Checked)
                DBobjects.Add("'FN'");
            if (chkTrigger.Checked)
                DBobjects.Add("'TR'");
            if (chkView.Checked)
                DBobjects.Add("'V'");

            if (DBobjects.Count == 0)
            {
                MessageBox.Show("Select some object(s)");
                return;
            }

            var dtResult = mssqlOperation.FindStringInsideObjects(txtSearch.Text, string.Join(",", DBobjects));
            if (dtResult != null && dtResult.Rows.Count > 0)
            {
                frmShowInfo frmShowInfo = new frmShowInfo(dtResult, "Show result of search inside object(s)");
                frmShowInfo.ShowDialog();
            }           

        }
    }
}
