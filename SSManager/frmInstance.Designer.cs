namespace SSManager
{
    partial class frmInstance
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
            this.btnLocalInstance = new System.Windows.Forms.Button();
            this.btnNetwrokInstance = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbInstance = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLocalInstance
            // 
            this.btnLocalInstance.Location = new System.Drawing.Point(26, 19);
            this.btnLocalInstance.Name = "btnLocalInstance";
            this.btnLocalInstance.Size = new System.Drawing.Size(105, 45);
            this.btnLocalInstance.TabIndex = 0;
            this.btnLocalInstance.Text = "Local Instance";
            this.btnLocalInstance.UseVisualStyleBackColor = true;
            this.btnLocalInstance.Click += new System.EventHandler(this.btnLocalInstance_Click);
            // 
            // btnNetwrokInstance
            // 
            this.btnNetwrokInstance.Location = new System.Drawing.Point(164, 19);
            this.btnNetwrokInstance.Name = "btnNetwrokInstance";
            this.btnNetwrokInstance.Size = new System.Drawing.Size(105, 45);
            this.btnNetwrokInstance.TabIndex = 0;
            this.btnNetwrokInstance.Text = "Netwrok Instance";
            this.btnNetwrokInstance.UseVisualStyleBackColor = true;
            this.btnNetwrokInstance.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLocalInstance);
            this.groupBox1.Controls.Add(this.btnNetwrokInstance);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL ServerInstance";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 33);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(128, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "&Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbInstance);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 252);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Instances";
            // 
            // lbInstance
            // 
            this.lbInstance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInstance.FormattingEnabled = true;
            this.lbInstance.Location = new System.Drawing.Point(3, 16);
            this.lbInstance.Name = "lbInstance";
            this.lbInstance.Size = new System.Drawing.Size(291, 233);
            this.lbInstance.TabIndex = 0;
            // 
            // frmInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInstance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Instance";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLocalInstance;
        private System.Windows.Forms.Button btnNetwrokInstance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbInstance;
    }
}