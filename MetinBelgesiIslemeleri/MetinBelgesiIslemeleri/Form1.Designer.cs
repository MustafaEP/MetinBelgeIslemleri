namespace MetinBelgesiIslemeleri
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
            this.btnYolSec = new System.Windows.Forms.Button();
            this.tbbelgeAdi = new System.Windows.Forms.TextBox();
            this.tbBelgeYolu = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnListeAktar = new System.Windows.Forms.Button();
            this.LBDialog = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRichTextBoxAktar = new System.Windows.Forms.Button();
            this.rTBAktar = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAcDosyaAdi = new System.Windows.Forms.TextBox();
            this.btnVerileriKaydet = new System.Windows.Forms.Button();
            this.rtbKaydedilecekVeriler = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYolSec
            // 
            this.btnYolSec.Location = new System.Drawing.Point(885, 12);
            this.btnYolSec.Name = "btnYolSec";
            this.btnYolSec.Size = new System.Drawing.Size(148, 89);
            this.btnYolSec.TabIndex = 0;
            this.btnYolSec.Text = "Yol Seç";
            this.btnYolSec.UseVisualStyleBackColor = true;
            this.btnYolSec.Click += new System.EventHandler(this.btnYolSec_Click);
            // 
            // tbbelgeAdi
            // 
            this.tbbelgeAdi.Location = new System.Drawing.Point(180, 104);
            this.tbbelgeAdi.Name = "tbbelgeAdi";
            this.tbbelgeAdi.Size = new System.Drawing.Size(329, 22);
            this.tbbelgeAdi.TabIndex = 1;
            // 
            // tbBelgeYolu
            // 
            this.tbBelgeYolu.Location = new System.Drawing.Point(180, 45);
            this.tbBelgeYolu.Name = "tbBelgeYolu";
            this.tbBelgeYolu.Size = new System.Drawing.Size(329, 22);
            this.tbBelgeYolu.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(885, 107);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(148, 89);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Belge Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Belge Yolu";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnListeAktar
            // 
            this.btnListeAktar.Location = new System.Drawing.Point(885, 203);
            this.btnListeAktar.Name = "btnListeAktar";
            this.btnListeAktar.Size = new System.Drawing.Size(148, 89);
            this.btnListeAktar.TabIndex = 6;
            this.btnListeAktar.Text = "Liste Kutusuna Aktar";
            this.btnListeAktar.UseVisualStyleBackColor = true;
            this.btnListeAktar.Click += new System.EventHandler(this.btnListeAktar_Click);
            // 
            // LBDialog
            // 
            this.LBDialog.FormattingEnabled = true;
            this.LBDialog.ItemHeight = 16;
            this.LBDialog.Location = new System.Drawing.Point(22, 258);
            this.LBDialog.Name = "LBDialog";
            this.LBDialog.Size = new System.Drawing.Size(275, 180);
            this.LBDialog.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aktarılan Bilgiler";
            // 
            // btnRichTextBoxAktar
            // 
            this.btnRichTextBoxAktar.Location = new System.Drawing.Point(885, 298);
            this.btnRichTextBoxAktar.Name = "btnRichTextBoxAktar";
            this.btnRichTextBoxAktar.Size = new System.Drawing.Size(148, 89);
            this.btnRichTextBoxAktar.TabIndex = 9;
            this.btnRichTextBoxAktar.Text = "RichTextBox\'a Aktar";
            this.btnRichTextBoxAktar.UseVisualStyleBackColor = true;
            this.btnRichTextBoxAktar.Click += new System.EventHandler(this.btnRichTextBoxAktar_Click);
            // 
            // rTBAktar
            // 
            this.rTBAktar.Location = new System.Drawing.Point(303, 258);
            this.rTBAktar.Name = "rTBAktar";
            this.rTBAktar.Size = new System.Drawing.Size(275, 180);
            this.rTBAktar.TabIndex = 10;
            this.rTBAktar.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Aktarılan Bilgiler";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rich Metin";
            // 
            // tbAcDosyaAdi
            // 
            this.tbAcDosyaAdi.Location = new System.Drawing.Point(180, 174);
            this.tbAcDosyaAdi.Name = "tbAcDosyaAdi";
            this.tbAcDosyaAdi.Size = new System.Drawing.Size(329, 22);
            this.tbAcDosyaAdi.TabIndex = 12;
            // 
            // btnVerileriKaydet
            // 
            this.btnVerileriKaydet.Location = new System.Drawing.Point(885, 393);
            this.btnVerileriKaydet.Name = "btnVerileriKaydet";
            this.btnVerileriKaydet.Size = new System.Drawing.Size(148, 89);
            this.btnVerileriKaydet.TabIndex = 14;
            this.btnVerileriKaydet.Text = "Verileri Kaydet";
            this.btnVerileriKaydet.UseVisualStyleBackColor = true;
            this.btnVerileriKaydet.Click += new System.EventHandler(this.btnVerileriKaydet_Click);
            // 
            // rtbKaydedilecekVeriler
            // 
            this.rtbKaydedilecekVeriler.Location = new System.Drawing.Point(584, 258);
            this.rtbKaydedilecekVeriler.Name = "rtbKaydedilecekVeriler";
            this.rtbKaydedilecekVeriler.Size = new System.Drawing.Size(275, 180);
            this.rtbKaydedilecekVeriler.TabIndex = 15;
            this.rtbKaydedilecekVeriler.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kaydedilecek Veriler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 503);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbKaydedilecekVeriler);
            this.Controls.Add(this.btnVerileriKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAcDosyaAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rTBAktar);
            this.Controls.Add(this.btnRichTextBoxAktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LBDialog);
            this.Controls.Add(this.btnListeAktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tbBelgeYolu);
            this.Controls.Add(this.tbbelgeAdi);
            this.Controls.Add(this.btnYolSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYolSec;
        private System.Windows.Forms.TextBox tbbelgeAdi;
        private System.Windows.Forms.TextBox tbBelgeYolu;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnListeAktar;
        private System.Windows.Forms.ListBox LBDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRichTextBoxAktar;
        private System.Windows.Forms.RichTextBox rTBAktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAcDosyaAdi;
        private System.Windows.Forms.Button btnVerileriKaydet;
        private System.Windows.Forms.RichTextBox rtbKaydedilecekVeriler;
        private System.Windows.Forms.Label label6;
    }
}

