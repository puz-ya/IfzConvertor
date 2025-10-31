namespace IFZConvertor
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txbFolderSource = new System.Windows.Forms.TextBox();
            this.txbFolderDestination = new System.Windows.Forms.TextBox();
            this.lblFolderSource = new System.Windows.Forms.Label();
            this.lblFolderDestination = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.pnlSelectFolders = new System.Windows.Forms.Panel();
            this.pnlSelectFolders.SuspendLayout();
            this.SuspendLayout();
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(116, 321);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(138, 51);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(380, 321);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(138, 51);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // pnlSelectFolders
            // 
            this.pnlSelectFolders.Controls.Add(this.txbFolderSource);
            this.pnlSelectFolders.Controls.Add(this.txbFolderDestination);
            this.pnlSelectFolders.Controls.Add(this.lblFolderSource);
            this.pnlSelectFolders.Controls.Add(this.lblFolderDestination);
            this.pnlSelectFolders.Location = new System.Drawing.Point(9, 65);
            this.pnlSelectFolders.Name = "pnlSelectFolders";
            this.pnlSelectFolders.Size = new System.Drawing.Size(590, 216);
            this.pnlSelectFolders.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 421);
            this.Controls.Add(this.pnlSelectFolders);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IFZConvertor";
            this.pnlSelectFolders.ResumeLayout(false);
            this.pnlSelectFolders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbFolderSource;
        private System.Windows.Forms.TextBox txbFolderDestination;
        private System.Windows.Forms.Label lblFolderSource;
        private System.Windows.Forms.Label lblFolderDestination;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Panel pnlSelectFolders;
    }
}

