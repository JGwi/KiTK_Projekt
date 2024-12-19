namespace KiTK_Algorytmy
{
    partial class szyfrowanieform
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
            this.label2 = new System.Windows.Forms.Label();
            this.WybierzOpcje = new System.Windows.Forms.GroupBox();
            this.checkBoxPrzesuniecieCykliczne = new System.Windows.Forms.CheckBox();
            this.checkBoxSzyfrTranspozycyjnym = new System.Windows.Forms.CheckBox();
            this.checkBoxPodstawienieHaslem = new System.Windows.Forms.CheckBox();
            this.checkBoxProstySzyfr = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKlucz = new System.Windows.Forms.TextBox();
            this.Szyfruj = new System.Windows.Forms.Button();
            this.btnDeszyfruj = new System.Windows.Forms.Button();
            this.btnEksportujPlik = new System.Windows.Forms.Button();
            this.btnImportujPlik = new System.Windows.Forms.Button();
            this.TekstDoSzyfrowania = new System.Windows.Forms.TextBox();
            this.TesktZaszyfrowany = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.WybierzOpcje.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 46);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kryptografia i teoria kodów | Szyfrowanie";
            // 
            // WybierzOpcje
            // 
            this.WybierzOpcje.Controls.Add(this.checkBoxPrzesuniecieCykliczne);
            this.WybierzOpcje.Controls.Add(this.checkBoxSzyfrTranspozycyjnym);
            this.WybierzOpcje.Controls.Add(this.checkBoxPodstawienieHaslem);
            this.WybierzOpcje.Controls.Add(this.checkBoxProstySzyfr);
            this.WybierzOpcje.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WybierzOpcje.Location = new System.Drawing.Point(58, 93);
            this.WybierzOpcje.Name = "WybierzOpcje";
            this.WybierzOpcje.Size = new System.Drawing.Size(654, 125);
            this.WybierzOpcje.TabIndex = 4;
            this.WybierzOpcje.TabStop = false;
            this.WybierzOpcje.Text = "Wybierz opcję";
            // 
            // checkBoxPrzesuniecieCykliczne
            // 
            this.checkBoxPrzesuniecieCykliczne.AutoSize = true;
            this.checkBoxPrzesuniecieCykliczne.Location = new System.Drawing.Point(393, 26);
            this.checkBoxPrzesuniecieCykliczne.Name = "checkBoxPrzesuniecieCykliczne";
            this.checkBoxPrzesuniecieCykliczne.Size = new System.Drawing.Size(252, 24);
            this.checkBoxPrzesuniecieCykliczne.TabIndex = 18;
            this.checkBoxPrzesuniecieCykliczne.Text = "Przesunięcie cykliczne o k liczbę *";
            this.checkBoxPrzesuniecieCykliczne.UseVisualStyleBackColor = true;
            this.checkBoxPrzesuniecieCykliczne.CheckedChanged += new System.EventHandler(this.checkBoxPrzesuniecieCykliczne_CheckedChanged);
            // 
            // checkBoxSzyfrTranspozycyjnym
            // 
            this.checkBoxSzyfrTranspozycyjnym.AutoSize = true;
            this.checkBoxSzyfrTranspozycyjnym.Location = new System.Drawing.Point(16, 56);
            this.checkBoxSzyfrTranspozycyjnym.Name = "checkBoxSzyfrTranspozycyjnym";
            this.checkBoxSzyfrTranspozycyjnym.Size = new System.Drawing.Size(187, 24);
            this.checkBoxSzyfrTranspozycyjnym.TabIndex = 1;
            this.checkBoxSzyfrTranspozycyjnym.Text = "Szyfr transpozycyjnym *";
            this.checkBoxSzyfrTranspozycyjnym.UseVisualStyleBackColor = true;
            this.checkBoxSzyfrTranspozycyjnym.CheckedChanged += new System.EventHandler(this.checkBoxSzyfrTranspozycyjnym_CheckedChanged);
            // 
            // checkBoxPodstawienieHaslem
            // 
            this.checkBoxPodstawienieHaslem.AutoSize = true;
            this.checkBoxPodstawienieHaslem.Location = new System.Drawing.Point(16, 85);
            this.checkBoxPodstawienieHaslem.Name = "checkBoxPodstawienieHaslem";
            this.checkBoxPodstawienieHaslem.Size = new System.Drawing.Size(244, 24);
            this.checkBoxPodstawienieHaslem.TabIndex = 2;
            this.checkBoxPodstawienieHaslem.Text = "Podstawienie za pomocą hasła *";
            this.checkBoxPodstawienieHaslem.UseVisualStyleBackColor = true;
            this.checkBoxPodstawienieHaslem.CheckedChanged += new System.EventHandler(this.checkBoxPodstawienieHaslem_CheckedChanged);
            // 
            // checkBoxProstySzyfr
            // 
            this.checkBoxProstySzyfr.AutoSize = true;
            this.checkBoxProstySzyfr.Location = new System.Drawing.Point(16, 26);
            this.checkBoxProstySzyfr.Name = "checkBoxProstySzyfr";
            this.checkBoxProstySzyfr.Size = new System.Drawing.Size(217, 24);
            this.checkBoxProstySzyfr.TabIndex = 0;
            this.checkBoxProstySzyfr.Text = "Prosty szyfr podstawieniowy";
            this.checkBoxProstySzyfr.UseVisualStyleBackColor = true;
            this.checkBoxProstySzyfr.CheckedChanged += new System.EventHandler(this.checkBoxProstySzyfr_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(54, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tekst do szyfrowania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(578, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Zaszyfrowaniy tekst";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(740, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Opcje z * wymagają podanie klucza/liczbę k";
            // 
            // textBoxKlucz
            // 
            this.textBoxKlucz.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKlucz.Location = new System.Drawing.Point(744, 119);
            this.textBoxKlucz.Name = "textBoxKlucz";
            this.textBoxKlucz.Size = new System.Drawing.Size(297, 30);
            this.textBoxKlucz.TabIndex = 42;
            // 
            // Szyfruj
            // 
            this.Szyfruj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Szyfruj.FlatAppearance.BorderSize = 0;
            this.Szyfruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Szyfruj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Szyfruj.ForeColor = System.Drawing.Color.White;
            this.Szyfruj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Szyfruj.Location = new System.Drawing.Point(754, 169);
            this.Szyfruj.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Szyfruj.Name = "Szyfruj";
            this.Szyfruj.Size = new System.Drawing.Size(118, 40);
            this.Szyfruj.TabIndex = 43;
            this.Szyfruj.Text = "Szyfruj";
            this.Szyfruj.UseVisualStyleBackColor = false;
            this.Szyfruj.Click += new System.EventHandler(this.Szyfruj_Click);
            // 
            // btnDeszyfruj
            // 
            this.btnDeszyfruj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnDeszyfruj.FlatAppearance.BorderSize = 0;
            this.btnDeszyfruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeszyfruj.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeszyfruj.ForeColor = System.Drawing.Color.White;
            this.btnDeszyfruj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeszyfruj.Location = new System.Drawing.Point(913, 169);
            this.btnDeszyfruj.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnDeszyfruj.Name = "btnDeszyfruj";
            this.btnDeszyfruj.Size = new System.Drawing.Size(118, 40);
            this.btnDeszyfruj.TabIndex = 44;
            this.btnDeszyfruj.Text = "Deszyfruj";
            this.btnDeszyfruj.UseVisualStyleBackColor = false;
            this.btnDeszyfruj.Click += new System.EventHandler(this.btnDeszyfruj_Click);
            // 
            // btnEksportujPlik
            // 
            this.btnEksportujPlik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnEksportujPlik.FlatAppearance.BorderSize = 0;
            this.btnEksportujPlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEksportujPlik.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEksportujPlik.ForeColor = System.Drawing.Color.White;
            this.btnEksportujPlik.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEksportujPlik.Location = new System.Drawing.Point(913, 223);
            this.btnEksportujPlik.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnEksportujPlik.Name = "btnEksportujPlik";
            this.btnEksportujPlik.Size = new System.Drawing.Size(118, 40);
            this.btnEksportujPlik.TabIndex = 46;
            this.btnEksportujPlik.Text = "Eksportuj Plik";
            this.btnEksportujPlik.UseVisualStyleBackColor = false;
            this.btnEksportujPlik.Click += new System.EventHandler(this.btnEksportujPlik_Click);
            // 
            // btnImportujPlik
            // 
            this.btnImportujPlik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnImportujPlik.FlatAppearance.BorderSize = 0;
            this.btnImportujPlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportujPlik.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnImportujPlik.ForeColor = System.Drawing.Color.White;
            this.btnImportujPlik.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportujPlik.Location = new System.Drawing.Point(753, 223);
            this.btnImportujPlik.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnImportujPlik.Name = "btnImportujPlik";
            this.btnImportujPlik.Size = new System.Drawing.Size(118, 40);
            this.btnImportujPlik.TabIndex = 45;
            this.btnImportujPlik.Text = "Importuj Plik";
            this.btnImportujPlik.UseVisualStyleBackColor = false;
            this.btnImportujPlik.Click += new System.EventHandler(this.btnImportujPlik_Click);
            // 
            // TekstDoSzyfrowania
            // 
            this.TekstDoSzyfrowania.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TekstDoSzyfrowania.Location = new System.Drawing.Point(23, 308);
            this.TekstDoSzyfrowania.Multiline = true;
            this.TekstDoSzyfrowania.Name = "TekstDoSzyfrowania";
            this.TekstDoSzyfrowania.Size = new System.Drawing.Size(500, 300);
            this.TekstDoSzyfrowania.TabIndex = 1;
            // 
            // TesktZaszyfrowany
            // 
            this.TesktZaszyfrowany.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TesktZaszyfrowany.Location = new System.Drawing.Point(582, 308);
            this.TesktZaszyfrowany.Multiline = true;
            this.TesktZaszyfrowany.Name = "TesktZaszyfrowany";
            this.TesktZaszyfrowany.ReadOnly = true;
            this.TesktZaszyfrowany.Size = new System.Drawing.Size(500, 300);
            this.TesktZaszyfrowany.TabIndex = 47;
            // 
            // szyfrowanieform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1094, 718);
            this.Controls.Add(this.TesktZaszyfrowany);
            this.Controls.Add(this.TekstDoSzyfrowania);
            this.Controls.Add(this.btnEksportujPlik);
            this.Controls.Add(this.btnImportujPlik);
            this.Controls.Add(this.btnDeszyfruj);
            this.Controls.Add(this.Szyfruj);
            this.Controls.Add(this.textBoxKlucz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WybierzOpcje);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "szyfrowanieform";
            this.Text = "szyfrowanieform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.WybierzOpcje.ResumeLayout(false);
            this.WybierzOpcje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox WybierzOpcje;
        private System.Windows.Forms.CheckBox checkBoxSzyfrTranspozycyjnym;
        private System.Windows.Forms.CheckBox checkBoxProstySzyfr;
        private System.Windows.Forms.CheckBox checkBoxPodstawienieHaslem;
        private System.Windows.Forms.CheckBox checkBoxPrzesuniecieCykliczne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKlucz;
        private System.Windows.Forms.Button Szyfruj;
        private System.Windows.Forms.Button btnDeszyfruj;
        private System.Windows.Forms.Button btnEksportujPlik;
        private System.Windows.Forms.Button btnImportujPlik;
        private System.Windows.Forms.TextBox TekstDoSzyfrowania;
        private System.Windows.Forms.TextBox TesktZaszyfrowany;
    }
}