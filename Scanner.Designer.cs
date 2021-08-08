namespace ScannerControlToshiba
{
    partial class Scanner
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
            this.openScannerConnection = new System.Windows.Forms.Button();
            this.closeConnection = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openScannerConnection
            // 
            this.openScannerConnection.Location = new System.Drawing.Point(12, 22);
            this.openScannerConnection.Name = "openScannerConnection";
            this.openScannerConnection.Size = new System.Drawing.Size(183, 40);
            this.openScannerConnection.TabIndex = 0;
            this.openScannerConnection.Text = "Skano barkod";
            this.openScannerConnection.UseVisualStyleBackColor = true;
            this.openScannerConnection.Click += new System.EventHandler(this.openScannerConnection_Click);
            // 
            // closeConnection
            // 
            this.closeConnection.Location = new System.Drawing.Point(12, 160);
            this.closeConnection.Name = "closeConnection";
            this.closeConnection.Size = new System.Drawing.Size(183, 40);
            this.closeConnection.TabIndex = 1;
            this.closeConnection.Text = "Mbyll lidhjen";
            this.closeConnection.UseVisualStyleBackColor = true;
            this.closeConnection.Click += new System.EventHandler(this.closeConnection_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hap lidhjen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Identifiko pajisjen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 212);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeConnection);
            this.Controls.Add(this.openScannerConnection);
            this.Name = "Scanner";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Scanner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openScannerConnection;
        private System.Windows.Forms.Button closeConnection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

