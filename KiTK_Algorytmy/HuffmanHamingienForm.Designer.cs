namespace KiTK_Algorytmy
{
    partial class HuffmanHamingienForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ZakHammingabtn = new System.Windows.Forms.Button();
            this.DaneBinText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ZakHammingaText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ZdeHammingaText = new System.Windows.Forms.RichTextBox();
            this.ZdeHammingabtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ZdeHuffmanaText = new System.Windows.Forms.RichTextBox();
            this.ZdeHuffmanabtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ZakHuffmanaText = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DaneText = new System.Windows.Forms.RichTextBox();
            this.ZakHuffmanabtn = new System.Windows.Forms.Button();
            this.DrzewoHuffmanaText = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 46);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kryptografia i teoria kodów | Hamingien i Huffman\r\n";
            // 
            // ZakHammingabtn
            // 
            this.ZakHammingabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ZakHammingabtn.FlatAppearance.BorderSize = 0;
            this.ZakHammingabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZakHammingabtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakHammingabtn.ForeColor = System.Drawing.Color.White;
            this.ZakHammingabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ZakHammingabtn.Location = new System.Drawing.Point(23, 387);
            this.ZakHammingabtn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ZakHammingabtn.Name = "ZakHammingabtn";
            this.ZakHammingabtn.Size = new System.Drawing.Size(400, 40);
            this.ZakHammingabtn.TabIndex = 32;
            this.ZakHammingabtn.Text = "Zakoduj Hamminga";
            this.ZakHammingabtn.UseVisualStyleBackColor = false;
            this.ZakHammingabtn.Click += new System.EventHandler(this.ZakHammingabtn_Click);
            // 
            // DaneBinText
            // 
            this.DaneBinText.Location = new System.Drawing.Point(23, 104);
            this.DaneBinText.Name = "DaneBinText";
            this.DaneBinText.Size = new System.Drawing.Size(400, 150);
            this.DaneBinText.TabIndex = 34;
            this.DaneBinText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Wprowadzanie danych binarnych";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(19, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Wyświetlanie zakodowanych danych";
            // 
            // ZakHammingaText
            // 
            this.ZakHammingaText.Location = new System.Drawing.Point(23, 279);
            this.ZakHammingaText.Name = "ZakHammingaText";
            this.ZakHammingaText.Size = new System.Drawing.Size(400, 100);
            this.ZakHammingaText.TabIndex = 36;
            this.ZakHammingaText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(19, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Wyświetlanie zakodowanych danych";
            // 
            // ZdeHammingaText
            // 
            this.ZdeHammingaText.Location = new System.Drawing.Point(23, 457);
            this.ZdeHammingaText.Name = "ZdeHammingaText";
            this.ZdeHammingaText.Size = new System.Drawing.Size(400, 100);
            this.ZdeHammingaText.TabIndex = 41;
            this.ZdeHammingaText.Text = "";
            // 
            // ZdeHammingabtn
            // 
            this.ZdeHammingabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ZdeHammingabtn.FlatAppearance.BorderSize = 0;
            this.ZdeHammingabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZdeHammingabtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZdeHammingabtn.ForeColor = System.Drawing.Color.White;
            this.ZdeHammingabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ZdeHammingabtn.Location = new System.Drawing.Point(23, 565);
            this.ZdeHammingabtn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ZdeHammingabtn.Name = "ZdeHammingabtn";
            this.ZdeHammingabtn.Size = new System.Drawing.Size(400, 40);
            this.ZdeHammingabtn.TabIndex = 38;
            this.ZdeHammingabtn.Text = "Zdekoduj Hamminga ";
            this.ZdeHammingabtn.UseVisualStyleBackColor = false;
            this.ZdeHammingabtn.Click += new System.EventHandler(this.ZdeHammingabtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(449, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Wyświetlanie oryginalnych danych";
            // 
            // ZdeHuffmanaText
            // 
            this.ZdeHuffmanaText.Location = new System.Drawing.Point(453, 457);
            this.ZdeHuffmanaText.Name = "ZdeHuffmanaText";
            this.ZdeHuffmanaText.Size = new System.Drawing.Size(400, 100);
            this.ZdeHuffmanaText.TabIndex = 49;
            this.ZdeHuffmanaText.Text = "";
            // 
            // ZdeHuffmanabtn
            // 
            this.ZdeHuffmanabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ZdeHuffmanabtn.FlatAppearance.BorderSize = 0;
            this.ZdeHuffmanabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZdeHuffmanabtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZdeHuffmanabtn.ForeColor = System.Drawing.Color.White;
            this.ZdeHuffmanabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ZdeHuffmanabtn.Location = new System.Drawing.Point(453, 565);
            this.ZdeHuffmanabtn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ZdeHuffmanabtn.Name = "ZdeHuffmanabtn";
            this.ZdeHuffmanabtn.Size = new System.Drawing.Size(400, 40);
            this.ZdeHuffmanabtn.TabIndex = 48;
            this.ZdeHuffmanabtn.Text = "Zdekoduj Huffmana";
            this.ZdeHuffmanabtn.UseVisualStyleBackColor = false;
            this.ZdeHuffmanabtn.Click += new System.EventHandler(this.ZdeHuffmanabtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(449, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Wyświetlanie zakodowanych danych";
            // 
            // ZakHuffmanaText
            // 
            this.ZakHuffmanaText.Location = new System.Drawing.Point(453, 279);
            this.ZakHuffmanaText.Name = "ZakHuffmanaText";
            this.ZakHuffmanaText.Size = new System.Drawing.Size(400, 100);
            this.ZakHuffmanaText.TabIndex = 46;
            this.ZakHuffmanaText.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(449, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Wprowadzanie danych";
            // 
            // DaneText
            // 
            this.DaneText.Location = new System.Drawing.Point(453, 104);
            this.DaneText.Name = "DaneText";
            this.DaneText.Size = new System.Drawing.Size(400, 150);
            this.DaneText.TabIndex = 44;
            this.DaneText.Text = "";
            // 
            // ZakHuffmanabtn
            // 
            this.ZakHuffmanabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ZakHuffmanabtn.FlatAppearance.BorderSize = 0;
            this.ZakHuffmanabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZakHuffmanabtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZakHuffmanabtn.ForeColor = System.Drawing.Color.White;
            this.ZakHuffmanabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ZakHuffmanabtn.Location = new System.Drawing.Point(453, 387);
            this.ZakHuffmanabtn.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.ZakHuffmanabtn.Name = "ZakHuffmanabtn";
            this.ZakHuffmanabtn.Size = new System.Drawing.Size(400, 40);
            this.ZakHuffmanabtn.TabIndex = 43;
            this.ZakHuffmanabtn.Text = "Zakoduj Huffmana";
            this.ZakHuffmanabtn.UseVisualStyleBackColor = false;
            this.ZakHuffmanabtn.Click += new System.EventHandler(this.ZakHuffmanabtn_Click);
            // 
            // DrzewoHuffmanaText
            // 
            this.DrzewoHuffmanaText.Location = new System.Drawing.Point(859, 104);
            this.DrzewoHuffmanaText.Name = "DrzewoHuffmanaText";
            this.DrzewoHuffmanaText.Size = new System.Drawing.Size(223, 501);
            this.DrzewoHuffmanaText.TabIndex = 51;
            this.DrzewoHuffmanaText.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(855, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Wyświetlenie drzewa Huffmana";
            // 
            // HuffmanHamingienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 718);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DrzewoHuffmanaText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ZdeHuffmanaText);
            this.Controls.Add(this.ZdeHuffmanabtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ZakHuffmanaText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DaneText);
            this.Controls.Add(this.ZakHuffmanabtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ZdeHammingaText);
            this.Controls.Add(this.ZdeHammingabtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZakHammingaText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DaneBinText);
            this.Controls.Add(this.ZakHammingabtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HuffmanHamingienForm";
            this.Text = "HuffmanHamingienForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ZakHammingabtn;
        private System.Windows.Forms.RichTextBox DaneBinText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ZakHammingaText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ZdeHammingaText;
        private System.Windows.Forms.Button ZdeHammingabtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ZdeHuffmanaText;
        private System.Windows.Forms.Button ZdeHuffmanabtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox ZakHuffmanaText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox DaneText;
        private System.Windows.Forms.Button ZakHuffmanabtn;
        private System.Windows.Forms.RichTextBox DrzewoHuffmanaText;
        private System.Windows.Forms.Label label8;
    }
}