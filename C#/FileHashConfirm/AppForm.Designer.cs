namespace FileHashConfirm
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.appTitle = new System.Windows.Forms.Label();
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.dropZone = new System.Windows.Forms.Panel();
            this.dropZoneLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.givenHashTextBox = new System.Windows.Forms.TextBox();
            this.md5HashTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sha1HashTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sha256HashTextBox = new System.Windows.Forms.TextBox();
            this.statusIconSHA256 = new System.Windows.Forms.PictureBox();
            this.statusIconSHA1 = new System.Windows.Forms.PictureBox();
            this.statusIconMD5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.dropZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusIconSHA256)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusIconSHA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusIconMD5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.appTitle);
            this.panel1.Controls.Add(this.appLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "By CodeLover254";
            // 
            // appTitle
            // 
            this.appTitle.AutoSize = true;
            this.appTitle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.appTitle.Location = new System.Drawing.Point(78, 13);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(180, 22);
            this.appTitle.TabIndex = 1;
            this.appTitle.Text = "File Hash Confirm";
            // 
            // appLogo
            // 
            this.appLogo.Image = global::FileHashConfirm.Properties.Resources.app_logo;
            this.appLogo.Location = new System.Drawing.Point(9, 6);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(63, 58);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogo.TabIndex = 0;
            this.appLogo.TabStop = false;
            // 
            // dropZone
            // 
            this.dropZone.AllowDrop = true;
            this.dropZone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dropZone.Controls.Add(this.dropZoneLabel);
            this.dropZone.Location = new System.Drawing.Point(5, 83);
            this.dropZone.Name = "dropZone";
            this.dropZone.Size = new System.Drawing.Size(370, 101);
            this.dropZone.TabIndex = 1;
            this.dropZone.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnFileDrop);
            this.dropZone.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnFileDragEnter);
            this.dropZone.DragLeave += new System.EventHandler(this.OnFileDragLeave);
            // 
            // dropZoneLabel
            // 
            this.dropZoneLabel.AutoSize = true;
            this.dropZoneLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropZoneLabel.Location = new System.Drawing.Point(82, 38);
            this.dropZoneLabel.Name = "dropZoneLabel";
            this.dropZoneLabel.Size = new System.Drawing.Size(216, 19);
            this.dropZoneLabel.TabIndex = 0;
            this.dropZoneLabel.Text = "Drag and Drop File Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Given Hash (paste here)";
            // 
            // givenHashTextBox
            // 
            this.givenHashTextBox.Location = new System.Drawing.Point(9, 222);
            this.givenHashTextBox.Name = "givenHashTextBox";
            this.givenHashTextBox.Size = new System.Drawing.Size(370, 20);
            this.givenHashTextBox.TabIndex = 3;
            this.givenHashTextBox.TextChanged += new System.EventHandler(this.OnUserInput);
            // 
            // md5HashTextBox
            // 
            this.md5HashTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.md5HashTextBox.Location = new System.Drawing.Point(9, 282);
            this.md5HashTextBox.Name = "md5HashTextBox";
            this.md5HashTextBox.ReadOnly = true;
            this.md5HashTextBox.Size = new System.Drawing.Size(335, 20);
            this.md5HashTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "MD5";
            // 
            // sha1HashTextBox
            // 
            this.sha1HashTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.sha1HashTextBox.Location = new System.Drawing.Point(9, 341);
            this.sha1HashTextBox.Name = "sha1HashTextBox";
            this.sha1HashTextBox.ReadOnly = true;
            this.sha1HashTextBox.Size = new System.Drawing.Size(335, 20);
            this.sha1HashTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "SHA-1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "SHA-256";
            // 
            // sha256HashTextBox
            // 
            this.sha256HashTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.sha256HashTextBox.Location = new System.Drawing.Point(9, 407);
            this.sha256HashTextBox.Name = "sha256HashTextBox";
            this.sha256HashTextBox.ReadOnly = true;
            this.sha256HashTextBox.Size = new System.Drawing.Size(335, 20);
            this.sha256HashTextBox.TabIndex = 13;
            // 
            // statusIconSHA256
            // 
            this.statusIconSHA256.Location = new System.Drawing.Point(351, 407);
            this.statusIconSHA256.Name = "statusIconSHA256";
            this.statusIconSHA256.Size = new System.Drawing.Size(21, 20);
            this.statusIconSHA256.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusIconSHA256.TabIndex = 12;
            this.statusIconSHA256.TabStop = false;
            // 
            // statusIconSHA1
            // 
            this.statusIconSHA1.Location = new System.Drawing.Point(351, 341);
            this.statusIconSHA1.Name = "statusIconSHA1";
            this.statusIconSHA1.Size = new System.Drawing.Size(21, 20);
            this.statusIconSHA1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusIconSHA1.TabIndex = 11;
            this.statusIconSHA1.TabStop = false;
            // 
            // statusIconMD5
            // 
            this.statusIconMD5.Location = new System.Drawing.Point(351, 282);
            this.statusIconMD5.Name = "statusIconMD5";
            this.statusIconMD5.Size = new System.Drawing.Size(21, 20);
            this.statusIconMD5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusIconMD5.TabIndex = 10;
            this.statusIconMD5.TabStop = false;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 470);
            this.Controls.Add(this.sha256HashTextBox);
            this.Controls.Add(this.statusIconSHA256);
            this.Controls.Add(this.statusIconSHA1);
            this.Controls.Add(this.statusIconMD5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sha1HashTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.md5HashTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.givenHashTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dropZone);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileHashConfirm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.dropZone.ResumeLayout(false);
            this.dropZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusIconSHA256)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusIconSHA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusIconMD5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.Panel dropZone;
        private System.Windows.Forms.Label dropZoneLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox givenHashTextBox;
        private System.Windows.Forms.TextBox md5HashTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sha1HashTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox statusIconMD5;
        private System.Windows.Forms.PictureBox statusIconSHA1;
        private System.Windows.Forms.PictureBox statusIconSHA256;
        private System.Windows.Forms.TextBox sha256HashTextBox;
        private System.Windows.Forms.Label label1;
    }
}

