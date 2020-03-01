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
    public partial class frmMain : Form
    {
        MssqlOperation mssqlOperation;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            DBHelper.ServerName = cbServer.Text;
            DBHelper.DatabaseName = "master";
            DBHelper.Username = txtUsername.Text;
            DBHelper.Password = txtPassword.Text;
            DBHelper.Authentication = cbAuthentication.SelectedIndex;

            string ConnectionStatus = DBHelper.Connect();
            if (ConnectionStatus.Equals("OK"))
            {
                FillDBCombobox();
            }
            else
                MessageBox.Show(this, "Test failed!\r\n" + ConnectionStatus, "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FillDBCombobox()
        {
            cbDatabase.Items.Clear();

            mssqlOperation = new MssqlOperation(DBHelper.con);
            var dtDBs = mssqlOperation.getDatabases();
            for (int i = 0; i < dtDBs.Rows.Count; i++)
                cbDatabase.Items.Add(dtDBs.Rows[i]["name"]);
            cbDatabase.SelectedIndex = 0;
        }

        private void cboAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsername.Enabled = cbAuthentication.SelectedIndex == 1;
            txtPassword.Enabled = cbAuthentication.SelectedIndex == 1;
        }

        private void cbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            mssqlOperation.ChangeDB(cbDatabase.Text);
            FillDBInfo();
            FillTables();
            FillViews();
            FillSPs();
            FillFunctions();
            FillTriggers();
        }

        private void FillDBInfo()
        {
            txtDBName.Text = cbDatabase.Text;
            var dbInfo = mssqlOperation.GetDatabaseInfo(txtDBName.Text);
            txtDBOwner.Text = dbInfo.Rows[0]["owner"].ToString();
            txtCompatibilityLevel.Text = dbInfo.Rows[0]["cmptlevel"].ToString() +
                                        mssqlOperation.getCompatibilityLevel(Convert.ToInt16(dbInfo.Rows[0]["cmptlevel"].ToString()));
            txtCreationDate.Text = dbInfo.Rows[0]["crdate"].ToString();
            var dbSizeInfo = mssqlOperation.getDBSizeInfo();
            txtTotalDbSize.Text = dbSizeInfo.Tables[0].Rows[0]["database_size"].ToString();
            txtUsedByData.Text = dbSizeInfo.Tables[1].Rows[0]["data"].ToString();
            txtUsedByIndices.Text = dbSizeInfo.Tables[1].Rows[0]["index_size"].ToString();
            txtUnusedSpace.Text = dbSizeInfo.Tables[1].Rows[0]["unused"].ToString();

            dgvDatafiles.DataSource = mssqlOperation.getDatafiles();
        }

        private void FillTables()
        {
            clbTable.Items.Clear();
            var dtTables = mssqlOperation.getTables();
            for (int i = 0; i < dtTables.Rows.Count; i++)
                clbTable.Items.Add(dtTables.Rows[i]["TABLE_NAME"]);
        }

        private void FillViews()
        {
            clbView.Items.Clear();
            var dtViews = mssqlOperation.getViews();
            for (int i = 0; i < dtViews.Rows.Count; i++)
                clbView.Items.Add(dtViews.Rows[i]["TABLE_NAME"]);
        }

        private void FillSPs()
        {
            clbSP.Items.Clear();
            var dtSPs = mssqlOperation.getSPs();
            for (int i = 0; i < dtSPs.Rows.Count; i++)
                clbSP.Items.Add(dtSPs.Rows[i]["name"]);
        }

        private void FillFunctions()
        {
            clbFunction.Items.Clear();
            var dtFunctions = mssqlOperation.getFunctions();
            for (int i = 0; i < dtFunctions.Rows.Count; i++)
                clbFunction.Items.Add(dtFunctions.Rows[i]["name"]);
        }

        private void FillTriggers()
        {
            clbTrigger.Items.Clear();
            var dtTriggers = mssqlOperation.getTriggers();
            for (int i = 0; i < dtTriggers.Rows.Count; i++)
                clbTrigger.Items.Add(dtTriggers.Rows[i]["name"]);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cbServer.SelectedIndex = 0;
            cbAuthentication.SelectedIndex = 0;
        }

        private void chkAllNoneTable_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbTable.Items.Count; i++)
                clbTable.SetItemChecked(i, chkAllNoneTable.Checked);
        }

        private void toolStripStatusLabel1_TextChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void contextMenuTable_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.ToString().Equals("Table Size Info"))
            {
                if (clbTable.SelectedIndex == -1)
                    MessageBox.Show("Fisrt select a table");
                else
                {
                    DataTable dtTableSizeInfo = mssqlOperation.TableSizeInfo(clbTable.SelectedItem.ToString());
                    frmShowInfo frmShowInfo = new frmShowInfo(dtTableSizeInfo, "Table " + clbTable.SelectedItem.ToString() + " size information");
                    frmShowInfo.ShowDialog();
                }
            }
            else if (e.ClickedItem.ToString().Equals("All Table Size Info"))
            {
                DataTable dtTAllableSizeInfo = mssqlOperation.AllTableSizeInfo();
                frmShowInfo frmShowInfo = new frmShowInfo(dtTAllableSizeInfo, "All Table size information");
                frmShowInfo.ShowDialog();
            }


        }

        private void showDatabasePartitionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dtTPartitionInfo = mssqlOperation.ShowPartitionInfo();
            frmShowInfo frmShowInfo = new frmShowInfo(dtTPartitionInfo, "Show Partition of Database");
            frmShowInfo.ShowDialog();
        }

        private void showDuplicateIndiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dtDuplicateIndex = mssqlOperation.ShowDuplicateIndex();
            frmShowInfo frmShowInfo = new frmShowInfo(dtDuplicateIndex, "Show duplicate index in Database");
            frmShowInfo.ShowDialog();
        }

        private void shrinkDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Shrinking Database, Please wait...";
            mssqlOperation.ShrinkDatabase();
            toolStripStatusLabel1.Text = "Shrinking Database is done.";
        }

        private void shrinkFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Shrinking Files, Please wait...";
            mssqlOperation.ShrinkFiles();
            toolStripStatusLabel1.Text = "Shrinking Files is done.";
        }

        private void enableCLRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mssqlOperation.EnableCLR();
        }

        private void emptyDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Disabling Constraint";
            mssqlOperation.NoCheckConstraint();
            for (int i = 0; i < clbTable.Items.Count; i++)
            {
                if (!clbTable.GetItemChecked(i))
                {
                    toolStripStatusLabel1.Text = "Deleting " + clbTable.Items[i].ToString() + " table";
                    mssqlOperation.DeleteTable(clbTable.Items[i].ToString());
                    mssqlOperation.ReseedTable(clbTable.Items[i].ToString());
                }
            }
            toolStripStatusLabel1.Text = "Enabling Constraint";
            mssqlOperation.CheckConstraint();
            toolStripStatusLabel1.Text = "The operation of making database empty is done";
        }

        private void renameDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenameDB frmRenameDB = new frmRenameDB(mssqlOperation);
            frmRenameDB.ShowDialog();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                var dtResult = DBHelper.ExecuteDT(fastColoredTextBox1.Text);
                if (dtResult != null && dtResult.Rows.Count > 0)
                {
                    gridResult.DataSource = dtResult;
                    gridResult.DefaultView.PopulateColumns();
                    ultraStatusBar1.Appearance.ForeColor = Color.Black;                
                    //ultraStatusBar1.Text = "Query was successful";
                }
                else
                {
                    ultraStatusBar1.Appearance.ForeColor = Color.Red;
                    ultraStatusBar1.Text = "Error ";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchATextInsideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchInSPFX frmSearchInSPFX = new frmSearchInSPFX(mssqlOperation);
            frmSearchInSPFX.ShowDialog();
        }

        private void missingIndicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dtDuplicateIndex = mssqlOperation.ShowMissingIndex();
            frmShowInfo frmShowInfo = new frmShowInfo(dtDuplicateIndex, "Show missing index in Database");
            frmShowInfo.ShowDialog();
        }

        private void chkAllNoneView_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbView.Items.Count; i++)
                clbView.SetItemChecked(i, chkAllNoneView.Checked);
        }

        private void chkAllNoneSP_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbSP.Items.Count; i++)
                clbSP.SetItemChecked(i, chkAllNoneSP.Checked);
        }

        private void chkAllNoneFx_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbFunction.Items.Count; i++)
                clbFunction.SetItemChecked(i, chkAllNoneFx.Checked);
        }

        private void chkAllNoneTrigger_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbTrigger.Items.Count; i++)
                clbTrigger.SetItemChecked(i, chkAllNoneTrigger.Checked);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridResult.ShowRibbonPrintPreview();
            //gridResult.ShowPrintPreview();
        }

        private void btnRightToLeft_Click(object sender, EventArgs e)
        {
            if(gridResult.RightToLeft != System.Windows.Forms.RightToLeft.Yes)
                gridResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            else
                gridResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            //gridResult.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
        }

        private void btnExecuteEXport_Click(object sender, EventArgs e)
        {
            try
            {
                var dtResult = DBHelper.ExecuteDT(fastColoredTextBox1.Text);
                if (dtResult != null && dtResult.Rows.Count > 0)
                {
                    ReportHelper.ExportToExcel(ref dtResult, "d:\\11122t.xls", false, true, false, false);

                    //gridResult.DataSource = dtResult;
                    //gridResult.DefaultView.PopulateColumns();
                    //ultraStatusBar1.Appearance.ForeColor = Color.Black;
                    //ultraStatusBar1.Text = "Query was successful";
                }
                else
                {
                    ultraStatusBar1.Appearance.ForeColor = Color.Red;
                    ultraStatusBar1.Text = "Error ";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindServer_Click(object sender, EventArgs e)
        {
            frmInstance fi = new frmInstance();
            fi.ShowDialog();
            if (!string.IsNullOrEmpty(fi.ServerName))
                cbServer.Text = fi.ServerName;                 
        }

        

    


    }
}
