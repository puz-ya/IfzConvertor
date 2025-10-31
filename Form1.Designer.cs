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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.txbFolderSource = new System.Windows.Forms.TextBox();
            this.txbFolderDestination = new System.Windows.Forms.TextBox();
            this.lblFolderSource = new System.Windows.Forms.Label();
            this.lblFolderDestination = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnImg2Ifz = new System.Windows.Forms.Button();
            this.pnlSelectFolders = new System.Windows.Forms.Panel();
            this.pnlSelectFolders.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open Source";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // lblFolderDestination
            // 
            this.lblFolderDestination.Location = new System.Drawing.Point(24, 141);
            this.lblFolderDestination.Name = "lblFolderDestination";
            this.lblFolderDestination.Size = new System.Drawing.Size(217, 23);
            this.lblFolderDestination.TabIndex = 5;
            this.lblFolderDestination.Text = "Select destination folder:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "IFZ ---> IMG";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnImg2Ifz
            // 
            this.btnImg2Ifz.Location = new System.Drawing.Point(380, 321);
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
            this.pnlSelectFolders.Controls.Add(this.txbFolderDestination);
            this.pnlSelectFolders.Controls.Add(this.lblFolderSource);
            this.pnlSelectFolders.Controls.Add(this.btnSelectDestination);
            this.pnlSelectFolders.Controls.Add(this.lblFolderDestination);
            this.pnlSelectFolders.Controls.Add(this.button1);
            this.pnlSelectFolders.Location = new System.Drawing.Point(9, 65);
            this.pnlSelectFolders.Name = "pnlSelectFolders";
            this.pnlSelectFolders.Size = new System.Drawing.Size(590, 216);
            this.pnlSelectFolders.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 421);
            this.Controls.Add(this.pnlSelectFolders);
            this.Controls.Add(this.btnImg2Ifz);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IFZConvertor";
            this.pnlSelectFolders.ResumeLayout(false);
            this.pnlSelectFolders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.TextBox txbFolderSource;
        private System.Windows.Forms.TextBox txbFolderDestination;
        private System.Windows.Forms.Label lblFolderSource;
        private System.Windows.Forms.Label lblFolderDestination;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnImg2Ifz;
        private System.Windows.Forms.Panel pnlSelectFolders;
    }
}

