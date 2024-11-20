namespace KiTK_Algorytmy
{
    partial class algorytmyform
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
            this.label1 = new System.Windows.Forms.Label();
            this.tekstPlikText = new System.Windows.Forms.RichTextBox();
            this.zaszyfrowanyText = new System.Windows.Forms.RichTextBox();
            this.szukajOknoText = new System.Windows.Forms.TextBox();
            this.btnSzyfrAES = new System.Windows.Forms.Button();
            this.btnDeszyfrAES = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.btnDeszyfrDES = new System.Windows.Forms.Button();
            this.btnSzyfrDES = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeszyfrStrDES = new System.Windows.Forms.Button();
            this.btnSzyfrStrDES = new System.Windows.Forms.Button();
            this.btnDeszyfrStrAES = new System.Windows.Forms.Button();
            this.btnSzyfrStrAES = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kryptografia i teoria kodów | Algorytmy AES i DES\r\n";
            // 
            // tekstPlikText
            // 
            this.tekstPlikText.Location = new System.Drawing.Point(140, 118);
            this.tekstPlikText.Name = "tekstPlikText";
            this.tekstPlikText.Size = new System.Drawing.Size(400, 500);
            this.tekstPlikText.TabIndex = 4;
            this.tekstPlikText.Text = "";
            // 
            // zaszyfrowanyText
            // 
            this.zaszyfrowanyText.Location = new System.Drawing.Point(550, 118);
            this.zaszyfrowanyText.Name = "zaszyfrowanyText";
            this.zaszyfrowanyText.Size = new System.Drawing.Size(400, 500);
            this.zaszyfrowanyText.TabIndex = 5;
            this.zaszyfrowanyText.Text = "";
            // 
            // szukajOknoText
            // 
            this.szukajOknoText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szukajOknoText.Location = new System.Drawing.Point(347, 67);
            this.szukajOknoText.Name = "szukajOknoText";
            this.szukajOknoText.Size = new System.Drawing.Size(400, 30);
            this.szukajOknoText.TabIndex = 9;
            // 
            // btnSzyfrAES
            // 
            this.btnSzyfrAES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSzyfrAES.FlatAppearance.BorderSize = 0;
            this.btnSzyfrAES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzyfrAES.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzyfrAES.ForeColor = System.Drawing.Color.White;
            this.btnSzyfrAES.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSzyfrAES.Location = new System.Drawing.Point(155, 640);
            this.btnSzyfrAES.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSzyfrAES.Name = "btnSzyfrAES";
            this.btnSzyfrAES.Size = new System.Drawing.Size(160, 60);
            this.btnSzyfrAES.TabIndex = 10;
            this.btnSzyfrAES.Text = "Szyfruj AES\r\nTryb blokowy";
            this.btnSzyfrAES.UseVisualStyleBackColor = false;
            this.btnSzyfrAES.Click += new System.EventHandler(this.btnSzyfrAES_Click);
            // 
            // btnDeszyfrAES
            // 
            this.btnDeszyfrAES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDeszyfrAES.FlatAppearance.BorderSize = 0;
            this.btnDeszyfrAES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeszyfrAES.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeszyfrAES.ForeColor = System.Drawing.Color.White;
            this.btnDeszyfrAES.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeszyfrAES.Location = new System.Drawing.Point(565, 640);
            this.btnDeszyfrAES.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDeszyfrAES.Name = "btnDeszyfrAES";
            this.btnDeszyfrAES.Size = new System.Drawing.Size(160, 60);
            this.btnDeszyfrAES.TabIndex = 11;
            this.btnDeszyfrAES.Text = "Deszyfruj AES\r\nTryb blokowy";
            this.btnDeszyfrAES.UseVisualStyleBackColor = false;
            this.btnDeszyfrAES.Click += new System.EventHandler(this.btnDeszyfrAES_Click);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSzukaj.FlatAppearance.BorderSize = 0;
            this.btnSzukaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzukaj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj.ForeColor = System.Drawing.Color.White;
            this.btnSzukaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSzukaj.Location = new System.Drawing.Point(750, 62);
            this.btnSzukaj.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(80, 40);
            this.btnSzukaj.TabIndex = 12;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = false;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // btnDeszyfrDES
            // 
            this.btnDeszyfrDES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDeszyfrDES.FlatAppearance.BorderSize = 0;
            this.btnDeszyfrDES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeszyfrDES.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeszyfrDES.ForeColor = System.Drawing.Color.White;
            this.btnDeszyfrDES.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeszyfrDES.Location = new System.Drawing.Point(775, 640);
            this.btnDeszyfrDES.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDeszyfrDES.Name = "btnDeszyfrDES";
            this.btnDeszyfrDES.Size = new System.Drawing.Size(160, 60);
            this.btnDeszyfrDES.TabIndex = 14;
            this.btnDeszyfrDES.Text = "Deszyfruj DES\nTryb blokowy";
            this.btnDeszyfrDES.UseVisualStyleBackColor = false;
            this.btnDeszyfrDES.Click += new System.EventHandler(this.btnDeszyfrDES_Click);
            // 
            // btnSzyfrDES
            // 
            this.btnSzyfrDES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnSzyfrDES.FlatAppearance.BorderSize = 0;
            this.btnSzyfrDES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzyfrDES.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzyfrDES.ForeColor = System.Drawing.Color.White;
            this.btnSzyfrDES.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSzyfrDES.Location = new System.Drawing.Point(365, 640);
            this.btnSzyfrDES.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSzyfrDES.Name = "btnSzyfrDES";
            this.btnSzyfrDES.Size = new System.Drawing.Size(160, 60);
            this.btnSzyfrDES.TabIndex = 13;
            this.btnSzyfrDES.Text = "Szyfruj DES\r\nTryb blokowy";
            this.btnSzyfrDES.UseVisualStyleBackColor = false;
            this.btnSzyfrDES.Click += new System.EventHandler(this.btnSzyfrDES_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 46);
            this.panel1.TabIndex = 15;
            // 
            // btnDeszyfrStrDES
            // 
            this.btnDeszyfrStrDES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnDeszyfrStrDES.FlatAppearance.BorderSize = 0;
            this.btnDeszyfrStrDES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeszyfrStrDES.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeszyfrStrDES.ForeColor = System.Drawing.Color.White;
            this.btnDeszyfrStrDES.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeszyfrStrDES.Location = new System.Drawing.Point(953, 420);
            this.btnDeszyfrStrDES.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeszyfrStrDES.Name = "btnDeszyfrStrDES";
            this.btnDeszyfrStrDES.Size = new System.Drawing.Size(138, 70);
            this.btnDeszyfrStrDES.TabIndex = 19;
            this.btnDeszyfrStrDES.Text = "Deszyfruj DES\r\nTryb strumieniowy";
            this.btnDeszyfrStrDES.UseVisualStyleBackColor = false;
            // 
            // btnSzyfrStrDES
            // 
            this.btnSzyfrStrDES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnSzyfrStrDES.FlatAppearance.BorderSize = 0;
            this.btnSzyfrStrDES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzyfrStrDES.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzyfrStrDES.ForeColor = System.Drawing.Color.White;
            this.btnSzyfrStrDES.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSzyfrStrDES.Location = new System.Drawing.Point(953, 240);
            this.btnSzyfrStrDES.Margin = new System.Windows.Forms.Padding(0);
            this.btnSzyfrStrDES.Name = "btnSzyfrStrDES";
            this.btnSzyfrStrDES.Size = new System.Drawing.Size(138, 70);
            this.btnSzyfrStrDES.TabIndex = 18;
            this.btnSzyfrStrDES.Text = "Szyfruj DES\r\nTryb strumieniowy";
            this.btnSzyfrStrDES.UseVisualStyleBackColor = false;
            // 
            // btnDeszyfrStrAES
            // 
            this.btnDeszyfrStrAES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnDeszyfrStrAES.FlatAppearance.BorderSize = 0;
            this.btnDeszyfrStrAES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeszyfrStrAES.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeszyfrStrAES.ForeColor = System.Drawing.Color.White;
            this.btnDeszyfrStrAES.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeszyfrStrAES.Location = new System.Drawing.Point(953, 330);
            this.btnDeszyfrStrAES.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeszyfrStrAES.Name = "btnDeszyfrStrAES";
            this.btnDeszyfrStrAES.Size = new System.Drawing.Size(138, 70);
            this.btnDeszyfrStrAES.TabIndex = 17;
            this.btnDeszyfrStrAES.Text = "Deszyfruj AES\r\nTryb strumieniowy";
            this.btnDeszyfrStrAES.UseVisualStyleBackColor = false;
            this.btnDeszyfrStrAES.Click += new System.EventHandler(this.btnDeszyfrStrAES_Click);
            // 
            // btnSzyfrStrAES
            // 
            this.btnSzyfrStrAES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnSzyfrStrAES.FlatAppearance.BorderSize = 0;
            this.btnSzyfrStrAES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzyfrStrAES.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzyfrStrAES.ForeColor = System.Drawing.Color.White;
            this.btnSzyfrStrAES.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSzyfrStrAES.Location = new System.Drawing.Point(953, 150);
            this.btnSzyfrStrAES.Margin = new System.Windows.Forms.Padding(0);
            this.btnSzyfrStrAES.Name = "btnSzyfrStrAES";
            this.btnSzyfrStrAES.Size = new System.Drawing.Size(138, 70);
            this.btnSzyfrStrAES.TabIndex = 16;
            this.btnSzyfrStrAES.Text = "Szyfruj AES\r\nTryb strumieniowy";
            this.btnSzyfrStrAES.UseVisualStyleBackColor = false;
            this.btnSzyfrStrAES.Click += new System.EventHandler(this.btnSzyfrStrAES_Click);
            // 
            // algorytmyform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1094, 718);
            this.Controls.Add(this.btnDeszyfrStrDES);
            this.Controls.Add(this.btnSzyfrStrDES);
            this.Controls.Add(this.btnDeszyfrStrAES);
            this.Controls.Add(this.btnSzyfrStrAES);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeszyfrDES);
            this.Controls.Add(this.btnSzyfrDES);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.btnDeszyfrAES);
            this.Controls.Add(this.btnSzyfrAES);
            this.Controls.Add(this.szukajOknoText);
            this.Controls.Add(this.zaszyfrowanyText);
            this.Controls.Add(this.tekstPlikText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "algorytmyform";
            this.Text = "algorytmyform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tekstPlikText;
        private System.Windows.Forms.RichTextBox zaszyfrowanyText;
        private System.Windows.Forms.TextBox szukajOknoText;
        private System.Windows.Forms.Button btnSzyfrAES;
        private System.Windows.Forms.Button btnDeszyfrAES;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Button btnDeszyfrDES;
        private System.Windows.Forms.Button btnSzyfrDES;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeszyfrStrDES;
        private System.Windows.Forms.Button btnSzyfrStrDES;
        private System.Windows.Forms.Button btnDeszyfrStrAES;
        private System.Windows.Forms.Button btnSzyfrStrAES;
    }
}