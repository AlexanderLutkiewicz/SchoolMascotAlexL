namespace SchoolMascotAlexL
{
    partial class frmSchoolMascot
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblMascot = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSchool = new System.Windows.Forms.ToolStripMenuItem();
            this.mniIMH = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAsh = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMT = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(148, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(164, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Immaculata";
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascot.Location = new System.Drawing.Point(149, 119);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(72, 25);
            this.lblMascot.TabIndex = 1;
            this.lblMascot.Text = "Saints";
            this.lblMascot.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSchool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(442, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSchool
            // 
            this.mnuSchool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniIMH,
            this.mniAsh,
            this.mniMT,
            this.mniSP});
            this.mnuSchool.Name = "mnuSchool";
            this.mnuSchool.Size = new System.Drawing.Size(55, 20);
            this.mnuSchool.Text = "School";
            // 
            // mniIMH
            // 
            this.mniIMH.Name = "mniIMH";
            this.mniIMH.Size = new System.Drawing.Size(152, 22);
            this.mniIMH.Text = "Immaculata";
            this.mniIMH.Click += new System.EventHandler(this.mniIMH_Click);
            // 
            // mniAsh
            // 
            this.mniAsh.Name = "mniAsh";
            this.mniAsh.Size = new System.Drawing.Size(152, 22);
            this.mniAsh.Text = "Ashbury";
            this.mniAsh.Click += new System.EventHandler(this.mniAsh_Click);
            // 
            // mniMT
            // 
            this.mniMT.Name = "mniMT";
            this.mniMT.Size = new System.Drawing.Size(152, 22);
            this.mniMT.Text = "Mother Teresa";
            this.mniMT.Click += new System.EventHandler(this.mniMT_Click);
            // 
            // mniSP
            // 
            this.mniSP.Name = "mniSP";
            this.mniSP.Size = new System.Drawing.Size(152, 22);
            this.mniSP.Text = "St. Patrick\'s";
            this.mniSP.Click += new System.EventHandler(this.mniSP_Click);
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 242);
            this.Controls.Add(this.lblMascot);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSchool;
        private System.Windows.Forms.ToolStripMenuItem mniIMH;
        private System.Windows.Forms.ToolStripMenuItem mniAsh;
        private System.Windows.Forms.ToolStripMenuItem mniMT;
        private System.Windows.Forms.ToolStripMenuItem mniSP;
    }
}

