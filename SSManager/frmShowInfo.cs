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
    public partial class frmShowInfo : Form
    {
        private DataTable source;

        public frmShowInfo()
        {
            InitializeComponent();
        }

        public frmShowInfo(DataTable source, string Title)
        {
            InitializeComponent();
            this.source = source;
            this.Text = Title;
        }

        private void frmShowInfo_Load(object sender, EventArgs e)
        {
            dgvInfo.DataSource = source;

        }
    }
}
