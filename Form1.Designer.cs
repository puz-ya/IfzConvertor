namespace IFZConvertor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIfz2Img = new System.Windows.Forms.Button();
            this.btnImg2Ifz = new System.Windows.Forms.Button();
            this.pnlSelectMainMode = new System.Windows.Forms.Panel();
            this.chbSameAsSourceFolder = new System.Windows.Forms.CheckBox();
            this.txbFolderSource = new System.Windows.Forms.TextBox();
            this.txbFolderDestination = new System.Windows.Forms.TextBox();
            this.lblFolderSource = new System.Windows.Forms.Label();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.lblFolderDestination = new System.Windows.Forms.Label();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.pnlImg2Ifz = new System.Windows.Forms.Panel();
            this.chbAddExtToName = new System.Windows.Forms.CheckBox();
            this.lblAddExtToName = new System.Windows.Forms.Label();
            this.btnLabelImg2Ifa = new System.Windows.Forms.Button();
            this.lblFilesCounters = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnRefreshImgCount = new System.Windows.Forms.Button();
            this.txbImgsCount = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSelectExt = new System.Windows.Forms.Label();
            this.cmbSelectExt = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIfz2Img = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImg2Ifz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectSourcePath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectDestinationPath = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSelectMainMode.SuspendLayout();
            this.pnlImg2Ifz.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIfz2Img
            // 
            this.btnIfz2Img.Enabled = false;
            this.btnIfz2Img.Location = new System.Drawing.Point(85, 103);
            this.btnIfz2Img.Name = "btnIfz2Img";
            this.btnIfz2Img.Size = new System.Drawing.Size(160, 160);
            this.btnIfz2Img.TabIndex = 6;
            this.btnIfz2Img.Text = "IFZ ---> IMG";
            this.btnIfz2Img.UseVisualStyleBackColor = true;
            // 
            // btnImg2Ifz
            // 
            this.btnImg2Ifz.Location = new System.Drawing.Point(416, 103);
            this.btnImg2Ifz.Name = "btnImg2Ifz";
            this.btnImg2Ifz.Size = new System.Drawing.Size(160, 160);
            this.btnImg2Ifz.TabIndex = 7;
            this.btnImg2Ifz.Text = "IMG ---> IFZ";
            this.btnImg2Ifz.UseVisualStyleBackColor = true;
            this.btnImg2Ifz.Click += new System.EventHandler(this.btnImg2Ifz_Click);
            // 
            // pnlSelectMainMode
            // 
            this.pnlSelectMainMode.Controls.Add(this.btnIfz2Img);
            this.pnlSelectMainMode.Controls.Add(this.btnImg2Ifz);
            this.pnlSelectMainMode.Location = new System.Drawing.Point(9, 40);
            this.pnlSelectMainMode.Name = "pnlSelectMainMode";
            this.pnlSelectMainMode.Size = new System.Drawing.Size(663, 366);
            this.pnlSelectMainMode.TabIndex = 8;
            // 
            // chbSameAsSourceFolder
            // 
            this.chbSameAsSourceFolder.AutoSize = true;
            this.chbSameAsSourceFolder.Checked = true;
            this.chbSameAsSourceFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSameAsSourceFolder.Location = new System.Drawing.Point(174, 229);
            this.chbSameAsSourceFolder.Name = "chbSameAsSourceFolder";
            this.chbSameAsSourceFolder.Size = new System.Drawing.Size(133, 17);
            this.chbSameAsSourceFolder.TabIndex = 8;
            this.chbSameAsSourceFolder.Text = "Same as Source folder";
            this.chbSameAsSourceFolder.UseVisualStyleBackColor = true;
            this.chbSameAsSourceFolder.CheckedChanged += new System.EventHandler(this.chbSameAsSourceFolder_CheckedChanged);
            // 
            // txbFolderSource
            // 
            this.txbFolderSource.Location = new System.Drawing.Point(17, 47);
            this.txbFolderSource.Name = "txbFolderSource";
            this.txbFolderSource.Size = new System.Drawing.Size(470, 20);
            this.txbFolderSource.TabIndex = 2;
            this.txbFolderSource.Text = "C:\\";
            this.txbFolderSource.TextChanged += new System.EventHandler(this.txbFolderSource_TextChanged);
            // 
            // txbFolderDestination
            // 
            this.txbFolderDestination.Location = new System.Drawing.Point(17, 256);
            this.txbFolderDestination.Name = "txbFolderDestination";
            this.txbFolderDestination.Size = new System.Drawing.Size(473, 20);
            this.txbFolderDestination.TabIndex = 3;
            this.txbFolderDestination.Text = "C:\\";
            // 
            // lblFolderSource
            // 
            this.lblFolderSource.Location = new System.Drawing.Point(17, 18);
            this.lblFolderSource.Name = "lblFolderSource";
            this.lblFolderSource.Size = new System.Drawing.Size(217, 23);
            this.lblFolderSource.TabIndex = 4;
            this.lblFolderSource.Text = "Source image folder path:";
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.Location = new System.Drawing.Point(496, 240);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(138, 51);
            this.btnSelectDestination.TabIndex = 1;
            this.btnSelectDestination.Text = "Open Destination folder";
            this.btnSelectDestination.UseVisualStyleBackColor = true;
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            // 
            // lblFolderDestination
            // 
            this.lblFolderDestination.Location = new System.Drawing.Point(17, 230);
            this.lblFolderDestination.Name = "lblFolderDestination";
            this.lblFolderDestination.Size = new System.Drawing.Size(224, 23);
            this.lblFolderDestination.TabIndex = 5;
            this.lblFolderDestination.Text = "Destination image folder path:";
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(496, 31);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(138, 51);
            this.btnSelectSource.TabIndex = 0;
            this.btnSelectSource.Text = "Open Source folder";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // pnlImg2Ifz
            // 
            this.pnlImg2Ifz.Controls.Add(this.chbAddExtToName);
            this.pnlImg2Ifz.Controls.Add(this.lblAddExtToName);
            this.pnlImg2Ifz.Controls.Add(this.btnLabelImg2Ifa);
            this.pnlImg2Ifz.Controls.Add(this.chbSameAsSourceFolder);
            this.pnlImg2Ifz.Controls.Add(this.lblFilesCounters);
            this.pnlImg2Ifz.Controls.Add(this.txbFolderSource);
            this.pnlImg2Ifz.Controls.Add(this.txbFolderDestination);
            this.pnlImg2Ifz.Controls.Add(this.btnConvert);
            this.pnlImg2Ifz.Controls.Add(this.btnSelectDestination);
            this.pnlImg2Ifz.Controls.Add(this.btnRefreshImgCount);
            this.pnlImg2Ifz.Controls.Add(this.lblFolderDestination);
            this.pnlImg2Ifz.Controls.Add(this.txbImgsCount);
            this.pnlImg2Ifz.Controls.Add(this.lblFolderSource);
            this.pnlImg2Ifz.Controls.Add(this.btnSelectSource);
            this.pnlImg2Ifz.Controls.Add(this.btnBack);
            this.pnlImg2Ifz.Controls.Add(this.lblSelectExt);
            this.pnlImg2Ifz.Controls.Add(this.cmbSelectExt);
            this.pnlImg2Ifz.Location = new System.Drawing.Point(9, 40);
            this.pnlImg2Ifz.Name = "pnlImg2Ifz";
            this.pnlImg2Ifz.Size = new System.Drawing.Size(663, 366);
            this.pnlImg2Ifz.TabIndex = 8;
            // 
            // chbAddExtToName
            // 
            this.chbAddExtToName.AutoSize = true;
            this.chbAddExtToName.Location = new System.Drawing.Point(174, 191);
            this.chbAddExtToName.Name = "chbAddExtToName";
            this.chbAddExtToName.Size = new System.Drawing.Size(265, 17);
            this.chbAddExtToName.TabIndex = 16;
            this.chbAddExtToName.Text = "Add (01.jpg -> 01.jpg.ifz, 01.jpeg -> 01.jpeg.ifz, etc)";
            this.chbAddExtToName.UseVisualStyleBackColor = true;
            this.chbAddExtToName.CheckedChanged += new System.EventHandler(this.chbAddExtToName_CheckedChanged);
            // 
            // lblAddExtToName
            // 
            this.lblAddExtToName.Location = new System.Drawing.Point(21, 192);
            this.lblAddExtToName.Name = "lblAddExtToName";
            this.lblAddExtToName.Size = new System.Drawing.Size(142, 23);
            this.lblAddExtToName.TabIndex = 15;
            this.lblAddExtToName.Text = "Add ext to end of the name?";
            // 
            // btnLabelImg2Ifa
            // 
            this.btnLabelImg2Ifa.BackColor = System.Drawing.SystemColors.Control;
            this.btnLabelImg2Ifa.Enabled = false;
            this.btnLabelImg2Ifa.Location = new System.Drawing.Point(496, 88);
            this.btnLabelImg2Ifa.Name = "btnLabelImg2Ifa";
            this.btnLabelImg2Ifa.Size = new System.Drawing.Size(138, 120);
            this.btnLabelImg2Ifa.TabIndex = 14;
            this.btnLabelImg2Ifa.Text = "IMG ---> IFZ";
            this.btnLabelImg2Ifa.UseVisualStyleBackColor = false;
            // 
            // lblFilesCounters
            // 
            this.lblFilesCounters.Location = new System.Drawing.Point(17, 76);
            this.lblFilesCounters.Name = "lblFilesCounters";
            this.lblFilesCounters.Size = new System.Drawing.Size(135, 23);
            this.lblFilesCounters.TabIndex = 13;
            this.lblFilesCounters.Text = "Files by types at Source:";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(496, 312);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(138, 51);
            this.btnConvert.TabIndex = 12;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnRefreshImgCount
            // 
            this.btnRefreshImgCount.Location = new System.Drawing.Point(313, 73);
            this.btnRefreshImgCount.Name = "btnRefreshImgCount";
            this.btnRefreshImgCount.Size = new System.Drawing.Size(92, 80);
            this.btnRefreshImgCount.TabIndex = 11;
            this.btnRefreshImgCount.Text = "Refresh";
            this.btnRefreshImgCount.UseVisualStyleBackColor = true;
            this.btnRefreshImgCount.Click += new System.EventHandler(this.btnRefreshImgCount_Click);
            // 
            // txbImgsCount
            // 
            this.txbImgsCount.Location = new System.Drawing.Point(169, 73);
            this.txbImgsCount.Multiline = true;
            this.txbImgsCount.Name = "txbImgsCount";
            this.txbImgsCount.ReadOnly = true;
            this.txbImgsCount.Size = new System.Drawing.Size(138, 80);
            this.txbImgsCount.TabIndex = 10;
            this.txbImgsCount.Text = ".bmp: 0\r\n.jpg / .jpeg: 0\r\n.png: 0\r\n--- --- ---\r\nAll: 0";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(24, 312);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(138, 51);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSelectExt
            // 
            this.lblSelectExt.Location = new System.Drawing.Point(21, 162);
            this.lblSelectExt.Name = "lblSelectExt";
            this.lblSelectExt.Size = new System.Drawing.Size(142, 23);
            this.lblSelectExt.TabIndex = 1;
            this.lblSelectExt.Text = "Types to convert:";
            // 
            // cmbSelectExt
            // 
            this.cmbSelectExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectExt.FormattingEnabled = true;
            this.cmbSelectExt.Items.AddRange(new object[] {
            ".bmp",
            ".jpg / .jpeg",
            ".png",
            "All"});
            this.cmbSelectExt.Location = new System.Drawing.Point(169, 159);
            this.cmbSelectExt.Name = "cmbSelectExt";
            this.cmbSelectExt.Size = new System.Drawing.Size(236, 21);
            this.cmbSelectExt.TabIndex = 0;
            this.cmbSelectExt.SelectedIndexChanged += new System.EventHandler(this.cmbSelectExt_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.functionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // defaultsToolStripMenuItem
            // 
            this.defaultsToolStripMenuItem.Name = "defaultsToolStripMenuItem";
            this.defaultsToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.defaultsToolStripMenuItem.Text = "Reset";
            this.defaultsToolStripMenuItem.Click += new System.EventHandler(this.defaultsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIfz2Img,
            this.tsmiImg2Ifz,
            this.toolStripSeparator1,
            this.tsmiSelectSourcePath,
            this.tsmiSelectDestinationPath});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.functionsToolStripMenuItem.Text = "Functions";
            // 
            // tsmiIfz2Img
            // 
            this.tsmiIfz2Img.Enabled = false;
            this.tsmiIfz2Img.Name = "tsmiIfz2Img";
            this.tsmiIfz2Img.Size = new System.Drawing.Size(195, 22);
            this.tsmiIfz2Img.Text = "IFZ -> IMG";
            // 
            // tsmiImg2Ifz
            // 
            this.tsmiImg2Ifz.Name = "tsmiImg2Ifz";
            this.tsmiImg2Ifz.Size = new System.Drawing.Size(195, 22);
            this.tsmiImg2Ifz.Text = "IMG -> IFZ";
            this.tsmiImg2Ifz.Click += new System.EventHandler(this.tsmiImg2Ifz_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // tsmiSelectSourcePath
            // 
            this.tsmiSelectSourcePath.Name = "tsmiSelectSourcePath";
            this.tsmiSelectSourcePath.Size = new System.Drawing.Size(195, 22);
            this.tsmiSelectSourcePath.Text = "Select Source path";
            this.tsmiSelectSourcePath.Click += new System.EventHandler(this.tsmiSelectSourcePath_Click);
            // 
            // tsmiSelectDestinationPath
            // 
            this.tsmiSelectDestinationPath.Name = "tsmiSelectDestinationPath";
            this.tsmiSelectDestinationPath.Size = new System.Drawing.Size(195, 22);
            this.tsmiSelectDestinationPath.Text = "Select Destination path";
            this.tsmiSelectDestinationPath.Click += new System.EventHandler(this.tsmiSelectDestinationPath_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 421);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlImg2Ifz);
            this.Controls.Add(this.pnlSelectMainMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IFZConvertor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pnlSelectMainMode.ResumeLayout(false);
            this.pnlImg2Ifz.ResumeLayout(false);
            this.pnlImg2Ifz.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIfz2Img;
        private System.Windows.Forms.Button btnImg2Ifz;
        private System.Windows.Forms.Panel pnlSelectMainMode;
        private System.Windows.Forms.TextBox txbFolderSource;
        private System.Windows.Forms.TextBox txbFolderDestination;
        private System.Windows.Forms.Label lblFolderSource;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.Label lblFolderDestination;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Panel pnlImg2Ifz;
        private System.Windows.Forms.Label lblSelectExt;
        private System.Windows.Forms.ComboBox cmbSelectExt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txbImgsCount;
        private System.Windows.Forms.Button btnRefreshImgCount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.CheckBox chbSameAsSourceFolder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectSourcePath;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectDestinationPath;
        private System.Windows.Forms.ToolStripMenuItem tsmiIfz2Img;
        private System.Windows.Forms.ToolStripMenuItem tsmiImg2Ifz;
        private System.Windows.Forms.ToolStripMenuItem defaultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblFilesCounters;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnLabelImg2Ifa;
        private System.Windows.Forms.CheckBox chbAddExtToName;
        private System.Windows.Forms.Label lblAddExtToName;
    }
}

