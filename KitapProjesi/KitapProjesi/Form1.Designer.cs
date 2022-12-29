namespace KitapProjesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.dtKitapBasimYili = new System.Windows.Forms.DateTimePicker();
            this.nmdSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.txtYazarAdi = new System.Windows.Forms.TextBox();
            this.txtIsbnNumarasi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDetayGoster = new System.Windows.Forms.Button();
            this.listBoxKitaplar = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmdSayfaSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKitapAdi.Location = new System.Drawing.Point(58, 37);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(100, 28);
            this.lblKitapAdi.TabIndex = 0;
            this.lblKitapAdi.Text = "Kitap Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Basım Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sayfa Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yazar Adı Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(58, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "ISBN Numarası";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(59, 68);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(161, 27);
            this.txtKitapAdi.TabIndex = 5;
            // 
            // dtKitapBasimYili
            // 
            this.dtKitapBasimYili.Location = new System.Drawing.Point(59, 141);
            this.dtKitapBasimYili.Name = "dtKitapBasimYili";
            this.dtKitapBasimYili.Size = new System.Drawing.Size(250, 27);
            this.dtKitapBasimYili.TabIndex = 6;
            // 
            // nmdSayfaSayisi
            // 
            this.nmdSayfaSayisi.Location = new System.Drawing.Point(59, 202);
            this.nmdSayfaSayisi.Name = "nmdSayfaSayisi";
            this.nmdSayfaSayisi.Size = new System.Drawing.Size(150, 27);
            this.nmdSayfaSayisi.TabIndex = 7;
            // 
            // txtYazarAdi
            // 
            this.txtYazarAdi.Location = new System.Drawing.Point(58, 277);
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.Size = new System.Drawing.Size(125, 27);
            this.txtYazarAdi.TabIndex = 8;
            // 
            // txtIsbnNumarasi
            // 
            this.txtIsbnNumarasi.Location = new System.Drawing.Point(58, 346);
            this.txtIsbnNumarasi.Name = "txtIsbnNumarasi";
            this.txtIsbnNumarasi.Size = new System.Drawing.Size(125, 27);
            this.txtIsbnNumarasi.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.Location = new System.Drawing.Point(58, 414);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(158, 40);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDetayGoster
            // 
            this.btnDetayGoster.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDetayGoster.Location = new System.Drawing.Point(335, 414);
            this.btnDetayGoster.Name = "btnDetayGoster";
            this.btnDetayGoster.Size = new System.Drawing.Size(180, 40);
            this.btnDetayGoster.TabIndex = 11;
            this.btnDetayGoster.Text = "Detay Göster";
            this.btnDetayGoster.UseVisualStyleBackColor = true;
            this.btnDetayGoster.Click += new System.EventHandler(this.btnDetayGoster_Click);
            // 
            // listBoxKitaplar
            // 
            this.listBoxKitaplar.FormattingEnabled = true;
            this.listBoxKitaplar.ItemHeight = 20;
            this.listBoxKitaplar.Location = new System.Drawing.Point(335, 37);
            this.listBoxKitaplar.Name = "listBoxKitaplar";
            this.listBoxKitaplar.Size = new System.Drawing.Size(251, 364);
            this.listBoxKitaplar.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 544);
            this.Controls.Add(this.listBoxKitaplar);
            this.Controls.Add(this.btnDetayGoster);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtIsbnNumarasi);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.nmdSayfaSayisi);
            this.Controls.Add(this.dtKitapBasimYili);
            this.Controls.Add(this.txtKitapAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKitapAdi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmdSayfaSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKitapAdi;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private TextBox txtKitapAdi;
        private DateTimePicker dtKitapBasimYili;
        private NumericUpDown nmdSayfaSayisi;
        private TextBox txtYazarAdi;
        private TextBox txtIsbnNumarasi;
        private Button btnKaydet;
        private Button btnDetayGoster;
        private ListBox listBoxKitaplar;
    }
}