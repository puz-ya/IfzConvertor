using System;
using System.Reflection;
using System.Windows.Forms;

namespace IFZConvertor
{
	public class VersionYP : Form
	{
		private Label lblVersion;
		private Button btnOK;
        private Label lblYear;
        private LinkLabel lnkLblGithub;
        private LinkLabel lnkLblEmail;
        private Label lblCopyright;

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionYP));
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lnkLblGithub = new System.Windows.Forms.LinkLabel();
            this.lnkLblEmail = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblVersion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVersion.Location = new System.Drawing.Point(12, 9);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(185, 15);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version 1.1";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK.Location = new System.Drawing.Point(147, 88);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCopyright.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyright.Location = new System.Drawing.Point(12, 32);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(173, 15);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "(C) Copyright OMRON ATC BCN";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblYear.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblYear.Location = new System.Drawing.Point(12, 60);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(35, 15);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "2025";
            // 
            // lnkLblGithub
            // 
            this.lnkLblGithub.AutoSize = true;
            this.lnkLblGithub.Location = new System.Drawing.Point(308, 34);
            this.lnkLblGithub.Name = "lnkLblGithub";
            this.lnkLblGithub.Size = new System.Drawing.Size(40, 13);
            this.lnkLblGithub.TabIndex = 7;
            this.lnkLblGithub.TabStop = true;
            this.lnkLblGithub.Text = "GitHub";
            this.lnkLblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblGithub_LinkClicked);
            // 
            // lnkLblEmail
            // 
            this.lnkLblEmail.AutoSize = true;
            this.lnkLblEmail.Location = new System.Drawing.Point(225, 62);
            this.lnkLblEmail.Name = "lnkLblEmail";
            this.lnkLblEmail.Size = new System.Drawing.Size(123, 13);
            this.lnkLblEmail.TabIndex = 8;
            this.lnkLblEmail.TabStop = true;
            this.lnkLblEmail.Text = "yury.puzino@omron.com";
            this.lnkLblEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblEmail_LinkClicked);
            // 
            // VersionYP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 122);
            this.Controls.Add(this.lnkLblEmail);
            this.Controls.Add(this.lnkLblGithub);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCopyright);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VersionYP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About IFZConvertor";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		public VersionYP()
		{
			this.InitializeComponent();

            // Get the current assembly
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Get the version from the AssemblyFileVersion attribute
            string version = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>()?.Version;

            // Alternatively, get the version from the AssemblyInformationalVersion attribute
            string informationalVersion = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

            lblVersion.Text = $"Version: {version}";

        }
        private void OKBtn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

        private void lnkLblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the website in the default browser
            System.Diagnostics.Process.Start("https://github.com/puz-ya/IfzConvertor/");
        }

        private void lnkLblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:yury.puzino@omron.com");
        }
    }
}
