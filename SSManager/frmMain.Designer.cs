namespace SSManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Information");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Recovery");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("ANSI");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("SQL");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Auto");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Cursor");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Advanced");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Options", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Data files");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Log Files");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Filegroups");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabConnection = new System.Windows.Forms.TabControl();
            this.Connection = new System.Windows.Forms.TabPage();
            this.gbDatabaseInformation = new System.Windows.Forms.GroupBox();
            this.tcDBInfo = new System.Windows.Forms.TabControl();
            this.tInformation = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreationDate = new System.Windows.Forms.TextBox();
            this.txtCompatibilityLevel = new System.Windows.Forms.TextBox();
            this.txtUnusedSpace = new System.Windows.Forms.TextBox();
            this.txtUsedByIndices = new System.Windows.Forms.TextBox();
            this.txtUsedByData = new System.Windows.Forms.TextBox();
            this.txtTotalDbSize = new System.Windows.Forms.TextBox();
            this.txtDBOwner = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.tDatafiles = new System.Windows.Forms.TabPage();
            this.dgvDatafiles = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAuthentication = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Operations = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkAllNoneTrigger = new System.Windows.Forms.CheckBox();
            this.clbTrigger = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAllNoneFx = new System.Windows.Forms.CheckBox();
            this.clbFunction = new System.Windows.Forms.CheckedListBox();
            this.gbSP = new System.Windows.Forms.GroupBox();
            this.chkAllNoneSP = new System.Windows.Forms.CheckBox();
            this.clbSP = new System.Windows.Forms.CheckedListBox();
            this.gbView = new System.Windows.Forms.GroupBox();
            this.chkAllNoneView = new System.Windows.Forms.CheckBox();
            this.clbView = new System.Windows.Forms.CheckedListBox();
            this.gbTable = new System.Windows.Forms.GroupBox();
            this.chkAllNoneTable = new System.Windows.Forms.CheckBox();
            this.clbTable = new System.Windows.Forms.CheckedListBox();
            this.contextMenuTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemTableSizeInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAllTableSizeInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFieldsInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.partitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partitionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showDatabasePartitionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDuplicateIndiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missingIndicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.enableCLRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.emptyDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.renameDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.searchATextInsideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.Query = new System.Windows.Forms.TabPage();
            this.gridResult = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRightToLeft = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExecuteEXport = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnFindServer = new System.Windows.Forms.Button();
            this.tabConnection.SuspendLayout();
            this.Connection.SuspendLayout();
            this.gbDatabaseInformation.SuspendLayout();
            this.tcDBInfo.SuspendLayout();
            this.tInformation.SuspendLayout();
            this.tDatafiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatafiles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Operations.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbSP.SuspendLayout();
            this.gbView.SuspendLayout();
            this.gbTable.SuspendLayout();
            this.contextMenuTable.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Query.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Help.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.Connection);
            this.tabConnection.Controls.Add(this.Operations);
            this.tabConnection.Controls.Add(this.Query);
            this.tabConnection.Controls.Add(this.Help);
            this.tabConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConnection.Location = new System.Drawing.Point(0, 0);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.SelectedIndex = 0;
            this.tabConnection.Size = new System.Drawing.Size(1214, 561);
            this.tabConnection.TabIndex = 1;
            // 
            // Connection
            // 
            this.Connection.Controls.Add(this.gbDatabaseInformation);
            this.Connection.Controls.Add(this.groupBox1);
            this.Connection.Location = new System.Drawing.Point(4, 22);
            this.Connection.Name = "Connection";
            this.Connection.Padding = new System.Windows.Forms.Padding(3);
            this.Connection.Size = new System.Drawing.Size(1206, 535);
            this.Connection.TabIndex = 0;
            this.Connection.Text = "Connection";
            this.Connection.UseVisualStyleBackColor = true;
            // 
            // gbDatabaseInformation
            // 
            this.gbDatabaseInformation.Controls.Add(this.tcDBInfo);
            this.gbDatabaseInformation.Controls.Add(this.treeView1);
            this.gbDatabaseInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatabaseInformation.Location = new System.Drawing.Point(303, 3);
            this.gbDatabaseInformation.Name = "gbDatabaseInformation";
            this.gbDatabaseInformation.Size = new System.Drawing.Size(900, 529);
            this.gbDatabaseInformation.TabIndex = 2;
            this.gbDatabaseInformation.TabStop = false;
            this.gbDatabaseInformation.Text = "Database Information";
            // 
            // tcDBInfo
            // 
            this.tcDBInfo.Controls.Add(this.tInformation);
            this.tcDBInfo.Controls.Add(this.tDatafiles);
            this.tcDBInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDBInfo.Location = new System.Drawing.Point(205, 16);
            this.tcDBInfo.Name = "tcDBInfo";
            this.tcDBInfo.SelectedIndex = 0;
            this.tcDBInfo.Size = new System.Drawing.Size(692, 510);
            this.tcDBInfo.TabIndex = 1;
            // 
            // tInformation
            // 
            this.tInformation.Controls.Add(this.label19);
            this.tInformation.Controls.Add(this.label18);
            this.tInformation.Controls.Add(this.label14);
            this.tInformation.Controls.Add(this.label13);
            this.tInformation.Controls.Add(this.label12);
            this.tInformation.Controls.Add(this.label11);
            this.tInformation.Controls.Add(this.label10);
            this.tInformation.Controls.Add(this.label9);
            this.tInformation.Controls.Add(this.label8);
            this.tInformation.Controls.Add(this.label7);
            this.tInformation.Controls.Add(this.label1);
            this.tInformation.Controls.Add(this.txtCreationDate);
            this.tInformation.Controls.Add(this.txtCompatibilityLevel);
            this.tInformation.Controls.Add(this.txtUnusedSpace);
            this.tInformation.Controls.Add(this.txtUsedByIndices);
            this.tInformation.Controls.Add(this.txtUsedByData);
            this.tInformation.Controls.Add(this.txtTotalDbSize);
            this.tInformation.Controls.Add(this.txtDBOwner);
            this.tInformation.Controls.Add(this.txtDBName);
            this.tInformation.Location = new System.Drawing.Point(4, 22);
            this.tInformation.Name = "tInformation";
            this.tInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tInformation.Size = new System.Drawing.Size(684, 484);
            this.tInformation.TabIndex = 0;
            this.tInformation.Text = "Information";
            this.tInformation.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 346);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Creation Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 312);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Compatibility level";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Unused space";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Used space";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Total Transaction log size";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Unused space";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Used by indices";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Used by data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Database size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Database owner";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dtabase Name";
            // 
            // txtCreationDate
            // 
            this.txtCreationDate.BackColor = System.Drawing.SystemColors.Info;
            this.txtCreationDate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCreationDate.Location = new System.Drawing.Point(176, 346);
            this.txtCreationDate.Name = "txtCreationDate";
            this.txtCreationDate.ReadOnly = true;
            this.txtCreationDate.Size = new System.Drawing.Size(278, 20);
            this.txtCreationDate.TabIndex = 0;
            // 
            // txtCompatibilityLevel
            // 
            this.txtCompatibilityLevel.BackColor = System.Drawing.SystemColors.Info;
            this.txtCompatibilityLevel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCompatibilityLevel.Location = new System.Drawing.Point(176, 309);
            this.txtCompatibilityLevel.Name = "txtCompatibilityLevel";
            this.txtCompatibilityLevel.ReadOnly = true;
            this.txtCompatibilityLevel.Size = new System.Drawing.Size(278, 20);
            this.txtCompatibilityLevel.TabIndex = 0;
            // 
            // txtUnusedSpace
            // 
            this.txtUnusedSpace.BackColor = System.Drawing.SystemColors.Info;
            this.txtUnusedSpace.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUnusedSpace.Location = new System.Drawing.Point(176, 176);
            this.txtUnusedSpace.Name = "txtUnusedSpace";
            this.txtUnusedSpace.ReadOnly = true;
            this.txtUnusedSpace.Size = new System.Drawing.Size(278, 20);
            this.txtUnusedSpace.TabIndex = 0;
            // 
            // txtUsedByIndices
            // 
            this.txtUsedByIndices.BackColor = System.Drawing.SystemColors.Info;
            this.txtUsedByIndices.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUsedByIndices.Location = new System.Drawing.Point(176, 144);
            this.txtUsedByIndices.Name = "txtUsedByIndices";
            this.txtUsedByIndices.ReadOnly = true;
            this.txtUsedByIndices.Size = new System.Drawing.Size(278, 20);
            this.txtUsedByIndices.TabIndex = 0;
            // 
            // txtUsedByData
            // 
            this.txtUsedByData.BackColor = System.Drawing.SystemColors.Info;
            this.txtUsedByData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUsedByData.Location = new System.Drawing.Point(176, 112);
            this.txtUsedByData.Name = "txtUsedByData";
            this.txtUsedByData.ReadOnly = true;
            this.txtUsedByData.Size = new System.Drawing.Size(278, 20);
            this.txtUsedByData.TabIndex = 0;
            // 
            // txtTotalDbSize
            // 
            this.txtTotalDbSize.BackColor = System.Drawing.SystemColors.Info;
            this.txtTotalDbSize.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTotalDbSize.Location = new System.Drawing.Point(176, 81);
            this.txtTotalDbSize.Name = "txtTotalDbSize";
            this.txtTotalDbSize.ReadOnly = true;
            this.txtTotalDbSize.Size = new System.Drawing.Size(278, 20);
            this.txtTotalDbSize.TabIndex = 0;
            // 
            // txtDBOwner
            // 
            this.txtDBOwner.BackColor = System.Drawing.SystemColors.Info;
            this.txtDBOwner.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDBOwner.Location = new System.Drawing.Point(176, 52);
            this.txtDBOwner.Name = "txtDBOwner";
            this.txtDBOwner.ReadOnly = true;
            this.txtDBOwner.Size = new System.Drawing.Size(278, 20);
            this.txtDBOwner.TabIndex = 0;
            // 
            // txtDBName
            // 
            this.txtDBName.BackColor = System.Drawing.SystemColors.Info;
            this.txtDBName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDBName.Location = new System.Drawing.Point(176, 23);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.ReadOnly = true;
            this.txtDBName.Size = new System.Drawing.Size(278, 20);
            this.txtDBName.TabIndex = 0;
            // 
            // tDatafiles
            // 
            this.tDatafiles.Controls.Add(this.dgvDatafiles);
            this.tDatafiles.Location = new System.Drawing.Point(4, 22);
            this.tDatafiles.Name = "tDatafiles";
            this.tDatafiles.Padding = new System.Windows.Forms.Padding(3);
            this.tDatafiles.Size = new System.Drawing.Size(684, 484);
            this.tDatafiles.TabIndex = 1;
            this.tDatafiles.Text = "Datafiles";
            this.tDatafiles.UseVisualStyleBackColor = true;
            // 
            // dgvDatafiles
            // 
            this.dgvDatafiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatafiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatafiles.Location = new System.Drawing.Point(3, 3);
            this.dgvDatafiles.Name = "dgvDatafiles";
            this.dgvDatafiles.ReadOnly = true;
            this.dgvDatafiles.Size = new System.Drawing.Size(678, 478);
            this.dgvDatafiles.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(3, 16);
            this.treeView1.Name = "treeView1";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Information";
            treeNode13.Name = "Node2";
            treeNode13.Text = "Recovery";
            treeNode14.Name = "Node3";
            treeNode14.Text = "ANSI";
            treeNode15.Name = "Node4";
            treeNode15.Text = "SQL";
            treeNode16.Name = "Node5";
            treeNode16.Text = "Auto";
            treeNode17.Name = "Node6";
            treeNode17.Text = "Cursor";
            treeNode18.Name = "Node7";
            treeNode18.Text = "Advanced";
            treeNode19.Name = "Node1";
            treeNode19.Text = "Options";
            treeNode20.Name = "Node8";
            treeNode20.Text = "Data files";
            treeNode21.Name = "Node9";
            treeNode21.Text = "Log Files";
            treeNode22.Name = "Node10";
            treeNode22.Text = "Filegroups";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            this.treeView1.Size = new System.Drawing.Size(202, 510);
            this.treeView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindServer);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbDatabase);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbAuthentication);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbServer);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 529);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Selection";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(218, 150);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(73, 28);
            this.btnConnect.TabIndex = 41;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbDatabase
            // 
            this.cbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(96, 183);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(195, 21);
            this.cbDatabase.TabIndex = 32;
            this.cbDatabase.SelectedIndexChanged += new System.EventHandler(this.cbDatabase_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Database:";
            // 
            // cbAuthentication
            // 
            this.cbAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAuthentication.FormattingEnabled = true;
            this.cbAuthentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbAuthentication.Location = new System.Drawing.Point(96, 71);
            this.cbAuthentication.Name = "cbAuthentication";
            this.cbAuthentication.Size = new System.Drawing.Size(195, 21);
            this.cbAuthentication.TabIndex = 29;
            this.cbAuthentication.SelectedIndexChanged += new System.EventHandler(this.cboAuthentication_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Authentication";
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Items.AddRange(new object[] {
            "(local)"});
            this.cbServer.Location = new System.Drawing.Point(96, 44);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(161, 21);
            this.cbServer.TabIndex = 28;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(195, 20);
            this.txtPassword.TabIndex = 31;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(96, 97);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(195, 20);
            this.txtUsername.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Server Host:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(31, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 13);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Source Database";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SSManager.Properties.Resources.Database;
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 18);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Operations
            // 
            this.Operations.Controls.Add(this.groupBox4);
            this.Operations.Controls.Add(this.groupBox3);
            this.Operations.Controls.Add(this.gbSP);
            this.Operations.Controls.Add(this.gbView);
            this.Operations.Controls.Add(this.gbTable);
            this.Operations.Controls.Add(this.statusStrip1);
            this.Operations.Controls.Add(this.menuStrip1);
            this.Operations.Location = new System.Drawing.Point(4, 22);
            this.Operations.Name = "Operations";
            this.Operations.Padding = new System.Windows.Forms.Padding(3);
            this.Operations.Size = new System.Drawing.Size(1206, 535);
            this.Operations.TabIndex = 1;
            this.Operations.Text = "Operations";
            this.Operations.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkAllNoneTrigger);
            this.groupBox4.Controls.Add(this.clbTrigger);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(835, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 483);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Trigger(s)";
            // 
            // chkAllNoneTrigger
            // 
            this.chkAllNoneTrigger.AutoSize = true;
            this.chkAllNoneTrigger.Location = new System.Drawing.Point(63, 0);
            this.chkAllNoneTrigger.Name = "chkAllNoneTrigger";
            this.chkAllNoneTrigger.Size = new System.Drawing.Size(68, 17);
            this.chkAllNoneTrigger.TabIndex = 6;
            this.chkAllNoneTrigger.Text = "All/None";
            this.chkAllNoneTrigger.UseVisualStyleBackColor = true;
            this.chkAllNoneTrigger.CheckedChanged += new System.EventHandler(this.chkAllNoneTrigger_CheckedChanged);
            // 
            // clbTrigger
            // 
            this.clbTrigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbTrigger.FormattingEnabled = true;
            this.clbTrigger.Location = new System.Drawing.Point(3, 16);
            this.clbTrigger.Name = "clbTrigger";
            this.clbTrigger.Size = new System.Drawing.Size(202, 464);
            this.clbTrigger.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAllNoneFx);
            this.groupBox3.Controls.Add(this.clbFunction);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(627, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 483);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function(s)";
            // 
            // chkAllNoneFx
            // 
            this.chkAllNoneFx.AutoSize = true;
            this.chkAllNoneFx.Location = new System.Drawing.Point(73, 0);
            this.chkAllNoneFx.Name = "chkAllNoneFx";
            this.chkAllNoneFx.Size = new System.Drawing.Size(68, 17);
            this.chkAllNoneFx.TabIndex = 5;
            this.chkAllNoneFx.Text = "All/None";
            this.chkAllNoneFx.UseVisualStyleBackColor = true;
            this.chkAllNoneFx.CheckedChanged += new System.EventHandler(this.chkAllNoneFx_CheckedChanged);
            // 
            // clbFunction
            // 
            this.clbFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbFunction.FormattingEnabled = true;
            this.clbFunction.Location = new System.Drawing.Point(3, 16);
            this.clbFunction.Name = "clbFunction";
            this.clbFunction.Size = new System.Drawing.Size(202, 464);
            this.clbFunction.TabIndex = 0;
            // 
            // gbSP
            // 
            this.gbSP.Controls.Add(this.chkAllNoneSP);
            this.gbSP.Controls.Add(this.clbSP);
            this.gbSP.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbSP.Location = new System.Drawing.Point(419, 27);
            this.gbSP.Name = "gbSP";
            this.gbSP.Size = new System.Drawing.Size(208, 483);
            this.gbSP.TabIndex = 4;
            this.gbSP.TabStop = false;
            this.gbSP.Text = "Store Procedure(s)";
            // 
            // chkAllNoneSP
            // 
            this.chkAllNoneSP.AutoSize = true;
            this.chkAllNoneSP.Location = new System.Drawing.Point(106, 0);
            this.chkAllNoneSP.Name = "chkAllNoneSP";
            this.chkAllNoneSP.Size = new System.Drawing.Size(68, 17);
            this.chkAllNoneSP.TabIndex = 4;
            this.chkAllNoneSP.Text = "All/None";
            this.chkAllNoneSP.UseVisualStyleBackColor = true;
            this.chkAllNoneSP.CheckedChanged += new System.EventHandler(this.chkAllNoneSP_CheckedChanged);
            // 
            // clbSP
            // 
            this.clbSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbSP.FormattingEnabled = true;
            this.clbSP.Location = new System.Drawing.Point(3, 16);
            this.clbSP.Name = "clbSP";
            this.clbSP.Size = new System.Drawing.Size(202, 464);
            this.clbSP.TabIndex = 0;
            // 
            // gbView
            // 
            this.gbView.Controls.Add(this.chkAllNoneView);
            this.gbView.Controls.Add(this.clbView);
            this.gbView.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbView.Location = new System.Drawing.Point(211, 27);
            this.gbView.Name = "gbView";
            this.gbView.Size = new System.Drawing.Size(208, 483);
            this.gbView.TabIndex = 3;
            this.gbView.TabStop = false;
            this.gbView.Text = "View(s)";
            // 
            // chkAllNoneView
            // 
            this.chkAllNoneView.AutoSize = true;
            this.chkAllNoneView.Location = new System.Drawing.Point(50, 0);
            this.chkAllNoneView.Name = "chkAllNoneView";
            this.chkAllNoneView.Size = new System.Drawing.Size(68, 17);
            this.chkAllNoneView.TabIndex = 3;
            this.chkAllNoneView.Text = "All/None";
            this.chkAllNoneView.UseVisualStyleBackColor = true;
            this.chkAllNoneView.CheckedChanged += new System.EventHandler(this.chkAllNoneView_CheckedChanged);
            // 
            // clbView
            // 
            this.clbView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbView.FormattingEnabled = true;
            this.clbView.Location = new System.Drawing.Point(3, 16);
            this.clbView.Name = "clbView";
            this.clbView.Size = new System.Drawing.Size(202, 464);
            this.clbView.TabIndex = 0;
            // 
            // gbTable
            // 
            this.gbTable.Controls.Add(this.chkAllNoneTable);
            this.gbTable.Controls.Add(this.clbTable);
            this.gbTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTable.Location = new System.Drawing.Point(3, 27);
            this.gbTable.Name = "gbTable";
            this.gbTable.Size = new System.Drawing.Size(208, 483);
            this.gbTable.TabIndex = 0;
            this.gbTable.TabStop = false;
            this.gbTable.Text = "Table(s)";
            // 
            // chkAllNoneTable
            // 
            this.chkAllNoneTable.AutoSize = true;
            this.chkAllNoneTable.Location = new System.Drawing.Point(61, 0);
            this.chkAllNoneTable.Name = "chkAllNoneTable";
            this.chkAllNoneTable.Size = new System.Drawing.Size(68, 17);
            this.chkAllNoneTable.TabIndex = 2;
            this.chkAllNoneTable.Text = "All/None";
            this.chkAllNoneTable.UseVisualStyleBackColor = true;
            this.chkAllNoneTable.CheckedChanged += new System.EventHandler(this.chkAllNoneTable_CheckedChanged);
            // 
            // clbTable
            // 
            this.clbTable.ContextMenuStrip = this.contextMenuTable;
            this.clbTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbTable.FormattingEnabled = true;
            this.clbTable.Location = new System.Drawing.Point(3, 16);
            this.clbTable.Name = "clbTable";
            this.clbTable.Size = new System.Drawing.Size(202, 464);
            this.clbTable.TabIndex = 0;
            // 
            // contextMenuTable
            // 
            this.contextMenuTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemTableSizeInfo,
            this.MenuItemAllTableSizeInfo,
            this.toolStripSeparator1,
            this.MenuItemFieldsInfo});
            this.contextMenuTable.Name = "contextMenuStrip1";
            this.contextMenuTable.Size = new System.Drawing.Size(167, 76);
            this.contextMenuTable.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuTable_ItemClicked);
            // 
            // MenuItemTableSizeInfo
            // 
            this.MenuItemTableSizeInfo.Name = "MenuItemTableSizeInfo";
            this.MenuItemTableSizeInfo.Size = new System.Drawing.Size(166, 22);
            this.MenuItemTableSizeInfo.Text = "Table Size Info";
            // 
            // MenuItemAllTableSizeInfo
            // 
            this.MenuItemAllTableSizeInfo.Name = "MenuItemAllTableSizeInfo";
            this.MenuItemAllTableSizeInfo.Size = new System.Drawing.Size(166, 22);
            this.MenuItemAllTableSizeInfo.Text = "All Table Size Info";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // MenuItemFieldsInfo
            // 
            this.MenuItemFieldsInfo.Name = "MenuItemFieldsInfo";
            this.MenuItemFieldsInfo.Size = new System.Drawing.Size(166, 22);
            this.MenuItemFieldsInfo.Text = "FieldsInfo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            this.toolStripStatusLabel1.TextChanged += new System.EventHandler(this.toolStripStatusLabel1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partitionToolStripMenuItem,
            this.operationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // partitionToolStripMenuItem
            // 
            this.partitionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partitionToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.indexToolStripMenuItem});
            this.partitionToolStripMenuItem.Name = "partitionToolStripMenuItem";
            this.partitionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.partitionToolStripMenuItem.Text = "Database";
            // 
            // partitionToolStripMenuItem1
            // 
            this.partitionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDatabasePartitionInfoToolStripMenuItem});
            this.partitionToolStripMenuItem1.Name = "partitionToolStripMenuItem1";
            this.partitionToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.partitionToolStripMenuItem1.Text = "Partition";
            // 
            // showDatabasePartitionInfoToolStripMenuItem
            // 
            this.showDatabasePartitionInfoToolStripMenuItem.Name = "showDatabasePartitionInfoToolStripMenuItem";
            this.showDatabasePartitionInfoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.showDatabasePartitionInfoToolStripMenuItem.Text = "Show Database Partition Info";
            this.showDatabasePartitionInfoToolStripMenuItem.Click += new System.EventHandler(this.showDatabasePartitionInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 6);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDuplicateIndiceToolStripMenuItem,
            this.missingIndicesToolStripMenuItem});
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.indexToolStripMenuItem.Text = "Index";
            // 
            // showDuplicateIndiceToolStripMenuItem
            // 
            this.showDuplicateIndiceToolStripMenuItem.Name = "showDuplicateIndiceToolStripMenuItem";
            this.showDuplicateIndiceToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.showDuplicateIndiceToolStripMenuItem.Text = "Show Duplicate Index";
            this.showDuplicateIndiceToolStripMenuItem.Click += new System.EventHandler(this.showDuplicateIndiceToolStripMenuItem_Click);
            // 
            // missingIndicesToolStripMenuItem
            // 
            this.missingIndicesToolStripMenuItem.Name = "missingIndicesToolStripMenuItem";
            this.missingIndicesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.missingIndicesToolStripMenuItem.Text = "Missing Index";
            this.missingIndicesToolStripMenuItem.Click += new System.EventHandler(this.missingIndicesToolStripMenuItem_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shrinkToolStripMenuItem,
            this.toolStripMenuItem2,
            this.enableCLRToolStripMenuItem,
            this.toolStripMenuItem3,
            this.emptyDBToolStripMenuItem,
            this.toolStripMenuItem4,
            this.renameDBToolStripMenuItem,
            this.toolStripMenuItem5,
            this.searchATextInsideToolStripMenuItem,
            this.toolStripMenuItem6});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // shrinkToolStripMenuItem
            // 
            this.shrinkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shrinkDatabaseToolStripMenuItem,
            this.shrinkFileToolStripMenuItem});
            this.shrinkToolStripMenuItem.Name = "shrinkToolStripMenuItem";
            this.shrinkToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.shrinkToolStripMenuItem.Text = "Shrink";
            // 
            // shrinkDatabaseToolStripMenuItem
            // 
            this.shrinkDatabaseToolStripMenuItem.Name = "shrinkDatabaseToolStripMenuItem";
            this.shrinkDatabaseToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.shrinkDatabaseToolStripMenuItem.Text = "Shrink Database";
            this.shrinkDatabaseToolStripMenuItem.Click += new System.EventHandler(this.shrinkDatabaseToolStripMenuItem_Click);
            // 
            // shrinkFileToolStripMenuItem
            // 
            this.shrinkFileToolStripMenuItem.Name = "shrinkFileToolStripMenuItem";
            this.shrinkFileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.shrinkFileToolStripMenuItem.Text = "Shrink File";
            this.shrinkFileToolStripMenuItem.Click += new System.EventHandler(this.shrinkFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(238, 6);
            // 
            // enableCLRToolStripMenuItem
            // 
            this.enableCLRToolStripMenuItem.Name = "enableCLRToolStripMenuItem";
            this.enableCLRToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.enableCLRToolStripMenuItem.Text = "Enable CLR";
            this.enableCLRToolStripMenuItem.Click += new System.EventHandler(this.enableCLRToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(238, 6);
            // 
            // emptyDBToolStripMenuItem
            // 
            this.emptyDBToolStripMenuItem.Name = "emptyDBToolStripMenuItem";
            this.emptyDBToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.emptyDBToolStripMenuItem.Text = "Empty DB";
            this.emptyDBToolStripMenuItem.Click += new System.EventHandler(this.emptyDBToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(238, 6);
            // 
            // renameDBToolStripMenuItem
            // 
            this.renameDBToolStripMenuItem.Name = "renameDBToolStripMenuItem";
            this.renameDBToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.renameDBToolStripMenuItem.Text = "Rename DB";
            this.renameDBToolStripMenuItem.Click += new System.EventHandler(this.renameDBToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(238, 6);
            // 
            // searchATextInsideToolStripMenuItem
            // 
            this.searchATextInsideToolStripMenuItem.Name = "searchATextInsideToolStripMenuItem";
            this.searchATextInsideToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.searchATextInsideToolStripMenuItem.Text = "Search a text inside DB object(s)";
            this.searchATextInsideToolStripMenuItem.Click += new System.EventHandler(this.searchATextInsideToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(238, 6);
            // 
            // Query
            // 
            this.Query.Controls.Add(this.gridResult);
            this.Query.Controls.Add(this.fastColoredTextBox1);
            this.Query.Controls.Add(this.panel1);
            this.Query.Location = new System.Drawing.Point(4, 22);
            this.Query.Name = "Query";
            this.Query.Padding = new System.Windows.Forms.Padding(3);
            this.Query.Size = new System.Drawing.Size(1206, 535);
            this.Query.TabIndex = 2;
            this.Query.Text = "Query";
            this.Query.UseVisualStyleBackColor = true;
            // 
            // gridResult
            // 
            this.gridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResult.Location = new System.Drawing.Point(3, 341);
            this.gridResult.MainView = this.gridView1;
            this.gridResult.Name = "gridResult";
            this.gridResult.Size = new System.Drawing.Size(1200, 191);
            this.gridResult.TabIndex = 4;
            this.gridResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridResult;
            this.gridView1.Name = "gridView1";
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(122, 56);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.CommentPrefix = "--";
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.SQL;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.Location = new System.Drawing.Point(3, 60);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(1200, 281);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.Text = "SELECT \r\n  TOP 1000 *\r\nFROM\r\n  ReceiptDetail";
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRightToLeft);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnExecuteEXport);
            this.panel1.Controls.Add(this.btnExecute);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 57);
            this.panel1.TabIndex = 1;
            // 
            // btnRightToLeft
            // 
            this.btnRightToLeft.BackColor = System.Drawing.Color.White;
            this.btnRightToLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRightToLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnRightToLeft.Image")));
            this.btnRightToLeft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRightToLeft.Location = new System.Drawing.Point(394, 2);
            this.btnRightToLeft.Name = "btnRightToLeft";
            this.btnRightToLeft.Size = new System.Drawing.Size(117, 48);
            this.btnRightToLeft.TabIndex = 0;
            this.btnRightToLeft.Text = "Position";
            this.btnRightToLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRightToLeft.UseVisualStyleBackColor = false;
            this.btnRightToLeft.Click += new System.EventHandler(this.btnRightToLeft_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(271, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(117, 48);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExecuteEXport
            // 
            this.btnExecuteEXport.BackColor = System.Drawing.Color.White;
            this.btnExecuteEXport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExecuteEXport.Image = global::SSManager.Properties.Resources.export2;
            this.btnExecuteEXport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExecuteEXport.Location = new System.Drawing.Point(139, 2);
            this.btnExecuteEXport.Name = "btnExecuteEXport";
            this.btnExecuteEXport.Size = new System.Drawing.Size(126, 48);
            this.btnExecuteEXport.TabIndex = 0;
            this.btnExecuteEXport.Text = "Execute && Export";
            this.btnExecuteEXport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecuteEXport.UseVisualStyleBackColor = false;
            this.btnExecuteEXport.Click += new System.EventHandler(this.btnExecuteEXport_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.White;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExecute.Image = ((System.Drawing.Image)(resources.GetObject("btnExecute.Image")));
            this.btnExecute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExecute.Location = new System.Drawing.Point(16, 2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(117, 48);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute";
            this.btnExecute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // Help
            // 
            this.Help.Controls.Add(this.groupBox2);
            this.Help.Location = new System.Drawing.Point(4, 22);
            this.Help.Name = "Help";
            this.Help.Padding = new System.Windows.Forms.Padding(3);
            this.Help.Size = new System.Drawing.Size(1206, 535);
            this.Help.TabIndex = 3;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(8, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 157);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.ForeColor = System.Drawing.Color.OliveDrab;
            this.label15.Location = new System.Drawing.Point(15, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "SS Manager";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label17.Location = new System.Drawing.Point(16, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "By : Ali Elmi";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(129, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Ver 1.3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(129, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "23 June 2016";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label21.Location = new System.Drawing.Point(16, 92);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 52);
            this.label21.TabIndex = 3;
            this.label21.Text = "Thanks to : \r\n  Mrs Beyami\r\n  Mr Taghavi\r\n\r\n";
            // 
            // btnFindServer
            // 
            this.btnFindServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindServer.Location = new System.Drawing.Point(263, 44);
            this.btnFindServer.Name = "btnFindServer";
            this.btnFindServer.Size = new System.Drawing.Size(28, 24);
            this.btnFindServer.TabIndex = 42;
            this.btnFindServer.Text = "...";
            this.btnFindServer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFindServer.UseVisualStyleBackColor = true;
            this.btnFindServer.Click += new System.EventHandler(this.btnFindServer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 561);
            this.Controls.Add(this.tabConnection);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Server Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabConnection.ResumeLayout(false);
            this.Connection.ResumeLayout(false);
            this.gbDatabaseInformation.ResumeLayout(false);
            this.tcDBInfo.ResumeLayout(false);
            this.tInformation.ResumeLayout(false);
            this.tInformation.PerformLayout();
            this.tDatafiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatafiles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Operations.ResumeLayout(false);
            this.Operations.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbSP.ResumeLayout(false);
            this.gbSP.PerformLayout();
            this.gbView.ResumeLayout(false);
            this.gbView.PerformLayout();
            this.gbTable.ResumeLayout(false);
            this.gbTable.PerformLayout();
            this.contextMenuTable.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Query.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Help.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConnection;
        private System.Windows.Forms.TabPage Connection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAuthentication;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage Operations;
        private System.Windows.Forms.GroupBox gbTable;
        private System.Windows.Forms.CheckedListBox clbTable;
        private System.Windows.Forms.TabPage Query;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbView;
        private System.Windows.Forms.CheckedListBox clbView;
        private System.Windows.Forms.GroupBox gbSP;
        private System.Windows.Forms.CheckedListBox clbSP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox clbFunction;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox clbTrigger;
        private System.Windows.Forms.CheckBox chkAllNoneTable;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuTable;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTableSizeInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFieldsInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAllTableSizeInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem partitionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partitionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showDatabasePartitionInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDuplicateIndiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem enableCLRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem emptyDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem renameDBToolStripMenuItem;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.GroupBox gbDatabaseInformation;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tcDBInfo;
        private System.Windows.Forms.TabPage tInformation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.TabPage tDatafiles;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem searchATextInsideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missingIndicesToolStripMenuItem;
        private System.Windows.Forms.TabPage Help;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.TextBox txtDBOwner;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtCompatibilityLevel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCreationDate;
        private System.Windows.Forms.TextBox txtTotalDbSize;
        private System.Windows.Forms.TextBox txtUsedByData;
        private System.Windows.Forms.TextBox txtUsedByIndices;
        private System.Windows.Forms.TextBox txtUnusedSpace;
        private System.Windows.Forms.CheckBox chkAllNoneTrigger;
        private System.Windows.Forms.CheckBox chkAllNoneFx;
        private System.Windows.Forms.CheckBox chkAllNoneSP;
        private System.Windows.Forms.CheckBox chkAllNoneView;
        private System.Windows.Forms.DataGridView dgvDatafiles;
        private Infragistics.Win.Misc.UltraGridBagLayoutManager ultraGridBagLayoutManager1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRightToLeft;
        private Infragistics.Win.UltraWinStatusBar.UltraStatusBar ultraStatusBar1;
        private DevExpress.XtraGrid.GridControl gridResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnExecuteEXport;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnFindServer;

    }
}

