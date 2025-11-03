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
            this.pnlSelectFolders = new System.Windows.Forms.Panel();
            this.pnlImg2Ifz = new System.Windows.Forms.Panel();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnRefreshImgCount = new System.Windows.Forms.Button();
            this.txbImgsCount = new System.Windows.Forms.TextBox();
            this.txbFolderPath = new System.Windows.Forms.TextBox();
            this.lblPathSource = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelectExt = new System.Windows.Forms.ComboBox();
            this.txbFolderSource = new System.Windows.Forms.TextBox();
            this.txbFolderDestination = new System.Windows.Forms.TextBox();
            this.lblFolderSource = new System.Windows.Forms.Label();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.lblFolderDestination = new System.Windows.Forms.Label();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.pnlSelectFolders.SuspendLayout();
            this.pnlImg2Ifz.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIfz2Img
            // 
            this.btnIfz2Img.Location = new System.Drawing.Point(103, 240);
            this.btnIfz2Img.Name = "btnIfz2Img";
            this.btnIfz2Img.Size = new System.Drawing.Size(138, 51);
            this.btnIfz2Img.TabIndex = 6;
            this.btnIfz2Img.Text = "IFZ ---> IMG";
            this.btnIfz2Img.UseVisualStyleBackColor = true;
            // 
            // btnImg2Ifz
            // 
            this.btnImg2Ifz.Location = new System.Drawing.Point(410, 240);
            this.btnImg2Ifz.Name = "btnImg2Ifz";
            this.btnImg2Ifz.Size = new System.Drawing.Size(138, 51);
            this.btnImg2Ifz.TabIndex = 7;
            this.btnImg2Ifz.Text = "IMG ---> IFZ";
            this.btnImg2Ifz.UseVisualStyleBackColor = true;
            this.btnImg2Ifz.Click += new System.EventHandler(this.btnImg2Ifz_Click);
            // 
            // pnlSelectFolders
            // 
            this.pnlSelectFolders.Controls.Add(this.txbFolderSource);
            this.pnlSelectFolders.Controls.Add(this.btnIfz2Img);
            this.pnlSelectFolders.Controls.Add(this.btnImg2Ifz);
            this.pnlSelectFolders.Controls.Add(this.txbFolderDestination);
            this.pnlSelectFolders.Controls.Add(this.lblFolderSource);
            this.pnlSelectFolders.Controls.Add(this.btnSelectDestination);
            this.pnlSelectFolders.Controls.Add(this.lblFolderDestination);
            this.pnlSelectFolders.Controls.Add(this.btnSelectSource);
            this.pnlSelectFolders.Location = new System.Drawing.Point(12, 12);
            this.pnlSelectFolders.Name = "pnlSelectFolders";
            this.pnlSelectFolders.Size = new System.Drawing.Size(680, 397);
            this.pnlSelectFolders.TabIndex = 8;
            // 
            // pnlImg2Ifz
            // 
            this.pnlImg2Ifz.Controls.Add(this.btnConvert);
            this.pnlImg2Ifz.Controls.Add(this.btnRefreshImgCount);
            this.pnlImg2Ifz.Controls.Add(this.txbImgsCount);
            this.pnlImg2Ifz.Controls.Add(this.txbFolderPath);
            this.pnlImg2Ifz.Controls.Add(this.lblPathSource);
            this.pnlImg2Ifz.Controls.Add(this.btnBack);
            this.pnlImg2Ifz.Controls.Add(this.label1);
            this.pnlImg2Ifz.Controls.Add(this.cmbSelectExt);
            this.pnlImg2Ifz.Location = new System.Drawing.Point(9, 9);
            this.pnlImg2Ifz.Name = "pnlImg2Ifz";
            this.pnlImg2Ifz.Size = new System.Drawing.Size(680, 397);
            this.pnlImg2Ifz.TabIndex = 8;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(453, 325);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(138, 51);
            this.btnConvert.TabIndex = 12;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnRefreshImgCount
            // 
            this.btnRefreshImgCount.Location = new System.Drawing.Point(453, 167);
            this.btnRefreshImgCount.Name = "btnRefreshImgCount";
            this.btnRefreshImgCount.Size = new System.Drawing.Size(138, 51);
            this.btnRefreshImgCount.TabIndex = 11;
            this.btnRefreshImgCount.Text = "Refresh";
            this.btnRefreshImgCount.UseVisualStyleBackColor = true;
            this.btnRefreshImgCount.Click += new System.EventHandler(this.btnRefreshImgCount_Click);
            // 
            // txbImgsCount
            // 
            this.txbImgsCount.Location = new System.Drawing.Point(453, 80);
            this.txbImgsCount.Multiline = true;
            this.txbImgsCount.Name = "txbImgsCount";
            this.txbImgsCount.ReadOnly = true;
            this.txbImgsCount.Size = new System.Drawing.Size(138, 84);
            this.txbImgsCount.TabIndex = 10;
            this.txbImgsCount.Text = ".bmp: 0\r\n.jpg: 0\r\n.png: 0\r\n.ifz: 0";
            // 
            // txbFolderPath
            // 
            this.txbFolderPath.Location = new System.Drawing.Point(169, 47);
            this.txbFolderPath.Name = "txbFolderPath";
            this.txbFolderPath.ReadOnly = true;
            this.txbFolderPath.Size = new System.Drawing.Size(422, 20);
            this.txbFolderPath.TabIndex = 9;
            // 
            // lblPathSource
            // 
            this.lblPathSource.Location = new System.Drawing.Point(27, 45);
            this.lblPathSource.Name = "lblPathSource";
            this.lblPathSource.Size = new System.Drawing.Size(135, 23);
            this.lblPathSource.TabIndex = 8;
            this.lblPathSource.Text = "Folder path:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(24, 325);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(138, 51);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Format:";
            // 
            // cmbSelectExt
            // 
            this.cmbSelectExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectExt.FormattingEnabled = true;
            this.cmbSelectExt.Items.AddRange(new object[] {
            ".bmp",
            ".jpg / .jpeg",
            ".png"});
            this.cmbSelectExt.Location = new System.Drawing.Point(168, 82);
            this.cmbSelectExt.Name = "cmbSelectExt";
            this.cmbSelectExt.Size = new System.Drawing.Size(174, 21);
            this.cmbSelectExt.TabIndex = 0;
            // 
            // txbFolderSource
            // 
            this.txbFolderSource.Location = new System.Drawing.Point(24, 48);
            this.txbFolderSource.Name = "txbFolderSource";
            this.txbFolderSource.Size = new System.Drawing.Size(410, 20);
            this.txbFolderSource.TabIndex = 2;
            // 
            // txbFolderDestination
            // 
            this.txbFolderDestination.Location = new System.Drawing.Point(24, 167);
            this.txbFolderDestination.Name = "txbFolderDestination";
            this.txbFolderDestination.Size = new System.Drawing.Size(410, 20);
            this.txbFolderDestination.TabIndex = 3;
            // 
            // lblFolderSource
            // 
            this.lblFolderSource.Location = new System.Drawing.Point(24, 16);
            this.lblFolderSource.Name = "lblFolderSource";
            this.lblFolderSource.Size = new System.Drawing.Size(217, 23);
            this.lblFolderSource.TabIndex = 4;
            this.lblFolderSource.Text = "Select your image folder.";
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.Location = new System.Drawing.Point(440, 151);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(138, 51);
            this.btnSelectDestination.TabIndex = 1;
            this.btnSelectDestination.Text = "Open Dest";
            this.btnSelectDestination.UseVisualStyleBackColor = true;
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            // 
            // lblFolderDestination
            // 
            this.lblFolderDestination.Location = new System.Drawing.Point(24, 141);
            this.lblFolderDestination.Name = "lblFolderDestination";
            this.lblFolderDestination.Size = new System.Drawing.Size(217, 23);
            this.lblFolderDestination.TabIndex = 5;
            this.lblFolderDestination.Text = "Select destination folder:";
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(440, 32);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(138, 51);
            this.btnSelectSource.TabIndex = 0;
            this.btnSelectSource.Text = "Open Source";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 421);
            this.Controls.Add(this.pnlImg2Ifz);
            this.Controls.Add(this.pnlSelectFolders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IFZConvertor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.pnlSelectFolders.ResumeLayout(false);
            this.pnlSelectFolders.PerformLayout();
            this.pnlImg2Ifz.ResumeLayout(false);
            this.pnlImg2Ifz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIfz2Img;
        private System.Windows.Forms.Button btnImg2Ifz;
        private System.Windows.Forms.Panel pnlSelectFolders;
        private System.Windows.Forms.TextBox txbFolderSource;
        private System.Windows.Forms.TextBox txbFolderDestination;
        private System.Windows.Forms.Label lblFolderSource;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.Label lblFolderDestination;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Panel pnlImg2Ifz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelectExt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPathSource;
        private System.Windows.Forms.TextBox txbFolderPath;
        private System.Windows.Forms.TextBox txbImgsCount;
        private System.Windows.Forms.Button btnRefreshImgCount;
        private System.Windows.Forms.Button btnConvert;
    }
}

