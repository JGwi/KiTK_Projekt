namespace KiTK_Algorytmy
{
    partial class podpiscyfrowy
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.cmbHashAlgorithm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerateSignature = new System.Windows.Forms.Button();
            this.rtbSignatureOutput = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelectCertificate = new System.Windows.Forms.Button();
            this.txtCertificatePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnalyzeCertificate = new System.Windows.Forms.Button();
            this.rtbCertificateDetails = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.treeCertificateChain = new System.Windows.Forms.TreeView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnValidateCertificate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(47, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ścieżka do pliku PDF";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 46);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(19, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kryptografia i teoria kodów | Obsługa podpisu cyfrowego";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFilePath.Location = new System.Drawing.Point(50, 64);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(400, 30);
            this.txtFilePath.TabIndex = 17;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSelectFile.FlatAppearance.BorderSize = 0;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectFile.ForeColor = System.Drawing.Color.White;
            this.btnSelectFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectFile.Location = new System.Drawing.Point(290, 102);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(160, 40);
            this.btnSelectFile.TabIndex = 18;
            this.btnSelectFile.Text = "Wybierz plik";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // cmbHashAlgorithm
            // 
            this.cmbHashAlgorithm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbHashAlgorithm.FormattingEnabled = true;
            this.cmbHashAlgorithm.Items.AddRange(new object[] {
            "SHA-256",
            "SHA-512",
            "MD5"});
            this.cmbHashAlgorithm.Location = new System.Drawing.Point(50, 150);
            this.cmbHashAlgorithm.Name = "cmbHashAlgorithm";
            this.cmbHashAlgorithm.Size = new System.Drawing.Size(400, 28);
            this.cmbHashAlgorithm.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(47, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Wybierz algorytm funkcji skrótu";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(50, 234);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(400, 27);
            this.txtPassword.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(56, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Hasło (klucz symetryczny)";
            // 
            // btnGenerateSignature
            // 
            this.btnGenerateSignature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnGenerateSignature.FlatAppearance.BorderSize = 0;
            this.btnGenerateSignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateSignature.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenerateSignature.ForeColor = System.Drawing.Color.White;
            this.btnGenerateSignature.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerateSignature.Location = new System.Drawing.Point(290, 269);
            this.btnGenerateSignature.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnGenerateSignature.Name = "btnGenerateSignature";
            this.btnGenerateSignature.Size = new System.Drawing.Size(160, 40);
            this.btnGenerateSignature.TabIndex = 24;
            this.btnGenerateSignature.Text = "Generuj podpis";
            this.btnGenerateSignature.UseVisualStyleBackColor = false;
            this.btnGenerateSignature.Click += new System.EventHandler(this.btnGenerateSignature_Click);
            // 
            // rtbSignatureOutput
            // 
            this.rtbSignatureOutput.Location = new System.Drawing.Point(50, 334);
            this.rtbSignatureOutput.Name = "rtbSignatureOutput";
            this.rtbSignatureOutput.Size = new System.Drawing.Size(400, 372);
            this.rtbSignatureOutput.TabIndex = 25;
            this.rtbSignatureOutput.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(56, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Wynik";
            // 
            // btnSelectCertificate
            // 
            this.btnSelectCertificate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSelectCertificate.FlatAppearance.BorderSize = 0;
            this.btnSelectCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCertificate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelectCertificate.ForeColor = System.Drawing.Color.White;
            this.btnSelectCertificate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectCertificate.Location = new System.Drawing.Point(875, 102);
            this.btnSelectCertificate.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSelectCertificate.Name = "btnSelectCertificate";
            this.btnSelectCertificate.Size = new System.Drawing.Size(160, 40);
            this.btnSelectCertificate.TabIndex = 30;
            this.btnSelectCertificate.Text = "Wybierz certyfikat\r\n";
            this.btnSelectCertificate.UseVisualStyleBackColor = false;
            this.btnSelectCertificate.Click += new System.EventHandler(this.btnSelectCertificate_Click);
            // 
            // txtCertificatePath
            // 
            this.txtCertificatePath.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCertificatePath.Location = new System.Drawing.Point(635, 64);
            this.txtCertificatePath.Name = "txtCertificatePath";
            this.txtCertificatePath.Size = new System.Drawing.Size(400, 30);
            this.txtCertificatePath.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(632, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ścieżka do certyfikatu";
            // 
            // btnAnalyzeCertificate
            // 
            this.btnAnalyzeCertificate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnAnalyzeCertificate.FlatAppearance.BorderSize = 0;
            this.btnAnalyzeCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyzeCertificate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnalyzeCertificate.ForeColor = System.Drawing.Color.White;
            this.btnAnalyzeCertificate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnalyzeCertificate.Location = new System.Drawing.Point(636, 150);
            this.btnAnalyzeCertificate.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnAnalyzeCertificate.Name = "btnAnalyzeCertificate";
            this.btnAnalyzeCertificate.Size = new System.Drawing.Size(400, 40);
            this.btnAnalyzeCertificate.TabIndex = 31;
            this.btnAnalyzeCertificate.Text = "Analizuj certyfikat\r\n";
            this.btnAnalyzeCertificate.UseVisualStyleBackColor = false;
            this.btnAnalyzeCertificate.Click += new System.EventHandler(this.btnAnalyzeCertificate_Click);
            // 
            // rtbCertificateDetails
            // 
            this.rtbCertificateDetails.Location = new System.Drawing.Point(635, 234);
            this.rtbCertificateDetails.Name = "rtbCertificateDetails";
            this.rtbCertificateDetails.Size = new System.Drawing.Size(401, 150);
            this.rtbCertificateDetails.TabIndex = 32;
            this.rtbCertificateDetails.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(632, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Szczegóły certyfikatu";
            // 
            // treeCertificateChain
            // 
            this.treeCertificateChain.Location = new System.Drawing.Point(633, 456);
            this.treeCertificateChain.Name = "treeCertificateChain";
            this.treeCertificateChain.Size = new System.Drawing.Size(401, 250);
            this.treeCertificateChain.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(630, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Łańcuch certyfikatów";
            // 
            // btnValidateCertificate
            // 
            this.btnValidateCertificate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnValidateCertificate.FlatAppearance.BorderSize = 0;
            this.btnValidateCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidateCertificate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnValidateCertificate.ForeColor = System.Drawing.Color.White;
            this.btnValidateCertificate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidateCertificate.Location = new System.Drawing.Point(633, 393);
            this.btnValidateCertificate.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnValidateCertificate.Name = "btnValidateCertificate";
            this.btnValidateCertificate.Size = new System.Drawing.Size(400, 40);
            this.btnValidateCertificate.TabIndex = 36;
            this.btnValidateCertificate.Text = "Waliduj certyfikat";
            this.btnValidateCertificate.UseVisualStyleBackColor = false;
            // 
            // podpiscyfrowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1094, 718);
            this.Controls.Add(this.btnValidateCertificate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.treeCertificateChain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbCertificateDetails);
            this.Controls.Add(this.btnAnalyzeCertificate);
            this.Controls.Add(this.btnSelectCertificate);
            this.Controls.Add(this.txtCertificatePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtbSignatureOutput);
            this.Controls.Add(this.btnGenerateSignature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbHashAlgorithm);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "podpiscyfrowy";
            this.Text = "podpiscyfrowy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.ComboBox cmbHashAlgorithm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerateSignature;
        private System.Windows.Forms.RichTextBox rtbSignatureOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelectCertificate;
        private System.Windows.Forms.TextBox txtCertificatePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnalyzeCertificate;
        private System.Windows.Forms.RichTextBox rtbCertificateDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeCertificateChain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnValidateCertificate;
    }
}