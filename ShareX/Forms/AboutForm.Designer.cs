namespace ShareX
{
    partial class AboutForm
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

            if (easterEgg != null) easterEgg.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.btnShareXLicense = new System.Windows.Forms.Button();
            this.btnLicenses = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.productname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblarchitecture = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkforupdates = new System.Windows.Forms.Button();
            this.cLogo = new ShareX.HelpersLib.Canvas();
            this.rtbInfo = new ShareX.HelpersLib.ReadOnlyRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShareXLicense
            // 
            resources.ApplyResources(this.btnShareXLicense, "btnShareXLicense");
            this.btnShareXLicense.Name = "btnShareXLicense";
            this.btnShareXLicense.UseVisualStyleBackColor = true;
            this.btnShareXLicense.Click += new System.EventHandler(this.btnShareXLicense_Click);
            // 
            // btnLicenses
            // 
            resources.ApplyResources(this.btnLicenses, "btnLicenses");
            this.btnLicenses.Name = "btnLicenses";
            this.btnLicenses.UseVisualStyleBackColor = true;
            this.btnLicenses.Click += new System.EventHandler(this.btnLicenses_Click);
            // 
            // pbLogo
            // 
            resources.ApplyResources(this.pbLogo, "pbLogo");
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.TabStop = false;
            this.pbLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLogo_MouseDown);
            // 
            // productname
            // 
            resources.ApplyResources(this.productname, "productname");
            this.productname.BackColor = System.Drawing.Color.Transparent;
            this.productname.Name = "productname";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // lblarchitecture
            // 
            resources.ApplyResources(this.lblarchitecture, "lblarchitecture");
            this.lblarchitecture.Name = "lblarchitecture";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkforupdates
            // 
            resources.ApplyResources(this.checkforupdates, "checkforupdates");
            this.checkforupdates.Name = "checkforupdates";
            this.checkforupdates.UseVisualStyleBackColor = true;
            this.checkforupdates.Click += new System.EventHandler(this.checkforupdates_Click);
            // 
            // cLogo
            // 
            resources.ApplyResources(this.cLogo, "cLogo");
            this.cLogo.Interval = 100;
            this.cLogo.Name = "cLogo";
            // 
            // rtbInfo
            // 
            resources.ApplyResources(this.rtbInfo, "rtbInfo");
            this.rtbInfo.BackColor = System.Drawing.SystemColors.Window;
            this.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtb_LinkClicked);
            this.rtbInfo.TextChanged += new System.EventHandler(this.rtbInfo_TextChanged);
            // 
            // AboutForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.checkforupdates);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblarchitecture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.cLogo);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.btnLicenses);
            this.Controls.Add(this.btnShareXLicense);
            this.Controls.Add(this.rtbInfo);
            this.Name = "AboutForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.Shown += new System.EventHandler(this.AboutForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion Windows Form Designer generated code
        private HelpersLib.ReadOnlyRichTextBox rtbInfo;
        private System.Windows.Forms.Button btnShareXLicense;
        private System.Windows.Forms.Button btnLicenses;
        private HelpersLib.Canvas cLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label productname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblarchitecture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button checkforupdates;
    }
}