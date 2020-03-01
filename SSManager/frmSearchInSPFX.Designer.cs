namespace SSManager
{
    partial class frmSearchInSPFX
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.grbSPFX = new System.Windows.Forms.GroupBox();
            this.chkTableValuedFunction = new System.Windows.Forms.CheckBox();
            this.chkSP = new System.Windows.Forms.CheckBox();
            this.chkScalarValuedFunction = new System.Windows.Forms.CheckBox();
            this.chkTrigger = new System.Windows.Forms.CheckBox();
            this.chkView = new System.Windows.Forms.CheckBox();
            this.grbSPFX.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find What:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSearch.Location = new System.Drawing.Point(20, 115);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(351, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "You can use wild charachte suck as % and ?";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(377, 115);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(92, 23);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "&Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // grbSPFX
            // 
            this.grbSPFX.Controls.Add(this.chkView);
            this.grbSPFX.Controls.Add(this.chkTrigger);
            this.grbSPFX.Controls.Add(this.chkScalarValuedFunction);
            this.grbSPFX.Controls.Add(this.chkTableValuedFunction);
            this.grbSPFX.Controls.Add(this.chkSP);
            this.grbSPFX.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbSPFX.Location = new System.Drawing.Point(0, 0);
            this.grbSPFX.Name = "grbSPFX";
            this.grbSPFX.Size = new System.Drawing.Size(494, 95);
            this.grbSPFX.TabIndex = 4;
            this.grbSPFX.TabStop = false;
            // 
            // chkTableValuedFunction
            // 
            this.chkTableValuedFunction.AutoSize = true;
            this.chkTableValuedFunction.Location = new System.Drawing.Point(42, 37);
            this.chkTableValuedFunction.Name = "chkTableValuedFunction";
            this.chkTableValuedFunction.Size = new System.Drawing.Size(132, 17);
            this.chkTableValuedFunction.TabIndex = 1;
            this.chkTableValuedFunction.Text = "Table-valued Function";
            this.chkTableValuedFunction.UseVisualStyleBackColor = true;
            // 
            // chkSP
            // 
            this.chkSP.AutoSize = true;
            this.chkSP.Location = new System.Drawing.Point(42, 12);
            this.chkSP.Name = "chkSP";
            this.chkSP.Size = new System.Drawing.Size(108, 17);
            this.chkSP.TabIndex = 0;
            this.chkSP.Text = "Store Procedures";
            this.chkSP.UseVisualStyleBackColor = true;
            // 
            // chkScalarValuedFunction
            // 
            this.chkScalarValuedFunction.AutoSize = true;
            this.chkScalarValuedFunction.Location = new System.Drawing.Point(42, 62);
            this.chkScalarValuedFunction.Name = "chkScalarValuedFunction";
            this.chkScalarValuedFunction.Size = new System.Drawing.Size(135, 17);
            this.chkScalarValuedFunction.TabIndex = 2;
            this.chkScalarValuedFunction.Text = "Scalar-valued Function";
            this.chkScalarValuedFunction.UseVisualStyleBackColor = true;
            // 
            // chkTrigger
            // 
            this.chkTrigger.AutoSize = true;
            this.chkTrigger.Location = new System.Drawing.Point(275, 12);
            this.chkTrigger.Name = "chkTrigger";
            this.chkTrigger.Size = new System.Drawing.Size(59, 17);
            this.chkTrigger.TabIndex = 2;
            this.chkTrigger.Text = "Trigger";
            this.chkTrigger.UseVisualStyleBackColor = true;
            // 
            // chkView
            // 
            this.chkView.AutoSize = true;
            this.chkView.Location = new System.Drawing.Point(275, 37);
            this.chkView.Name = "chkView";
            this.chkView.Size = new System.Drawing.Size(49, 17);
            this.chkView.TabIndex = 2;
            this.chkView.Text = "View";
            this.chkView.UseVisualStyleBackColor = true;
            // 
            // frmSearchInSPFX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 175);
            this.Controls.Add(this.grbSPFX);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchInSPFX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search inside objects(s)";
            this.grbSPFX.ResumeLayout(false);
            this.grbSPFX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox grbSPFX;
        private System.Windows.Forms.CheckBox chkTableValuedFunction;
        private System.Windows.Forms.CheckBox chkSP;
        private System.Windows.Forms.CheckBox chkView;
        private System.Windows.Forms.CheckBox chkTrigger;
        private System.Windows.Forms.CheckBox chkScalarValuedFunction;
    }
}