namespace WFAPersonelBilgileri
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
            label1 = new Label();
            btnResimSec = new Button();
            lvPersonelListesi = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            txtPersonelID = new TextBox();
            gbPersonelBilgileri = new GroupBox();
            pboxResim = new PictureBox();
            txtAdres = new TextBox();
            mtbTelefon = new MaskedTextBox();
            dtpIseGirisTarihi = new DateTimePicker();
            dtpDogumTarihi = new DateTimePicker();
            txtEmail = new TextBox();
            txtSoyad = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            label8 = new Label();
            label7 = new Label();
            gbPersonelBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxResim).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 57);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "Personel ID";
            // 
            // btnResimSec
            // 
            btnResimSec.Location = new Point(666, 185);
            btnResimSec.Margin = new Padding(3, 4, 3, 4);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(86, 31);
            btnResimSec.TabIndex = 1;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // lvPersonelListesi
            // 
            lvPersonelListesi.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvPersonelListesi.FullRowSelect = true;
            lvPersonelListesi.GridLines = true;
            lvPersonelListesi.Location = new Point(1, 379);
            lvPersonelListesi.Margin = new Padding(3, 4, 3, 4);
            lvPersonelListesi.Name = "lvPersonelListesi";
            lvPersonelListesi.Size = new Size(862, 333);
            lvPersonelListesi.TabIndex = 2;
            lvPersonelListesi.UseCompatibleStateImageBehavior = false;
            lvPersonelListesi.View = View.Details;
            lvPersonelListesi.SelectedIndexChanged += lvPersonelListesi_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Personel ID";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Doğum Tarihi";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telefon";
            columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Email";
            columnHeader6.Width = 175;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Resim Yolu";
            columnHeader7.Width = 225;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(666, 224);
            btnKaydet.Margin = new Padding(3, 4, 3, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(86, 31);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Enabled = false;
            btnGuncelle.Location = new Point(666, 263);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(86, 31);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Enabled = false;
            btnSil.Location = new Point(666, 300);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(86, 31);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtPersonelID
            // 
            txtPersonelID.Location = new Point(122, 47);
            txtPersonelID.Margin = new Padding(3, 4, 3, 4);
            txtPersonelID.Name = "txtPersonelID";
            txtPersonelID.Size = new Size(195, 27);
            txtPersonelID.TabIndex = 3;
            // 
            // gbPersonelBilgileri
            // 
            gbPersonelBilgileri.Controls.Add(pboxResim);
            gbPersonelBilgileri.Controls.Add(txtAdres);
            gbPersonelBilgileri.Controls.Add(mtbTelefon);
            gbPersonelBilgileri.Controls.Add(dtpIseGirisTarihi);
            gbPersonelBilgileri.Controls.Add(dtpDogumTarihi);
            gbPersonelBilgileri.Controls.Add(txtEmail);
            gbPersonelBilgileri.Controls.Add(txtSoyad);
            gbPersonelBilgileri.Controls.Add(label6);
            gbPersonelBilgileri.Controls.Add(label5);
            gbPersonelBilgileri.Controls.Add(label4);
            gbPersonelBilgileri.Controls.Add(label3);
            gbPersonelBilgileri.Controls.Add(txtAd);
            gbPersonelBilgileri.Controls.Add(label2);
            gbPersonelBilgileri.Controls.Add(txtPersonelID);
            gbPersonelBilgileri.Controls.Add(label8);
            gbPersonelBilgileri.Controls.Add(label7);
            gbPersonelBilgileri.Controls.Add(label1);
            gbPersonelBilgileri.Controls.Add(btnSil);
            gbPersonelBilgileri.Controls.Add(btnGuncelle);
            gbPersonelBilgileri.Controls.Add(btnResimSec);
            gbPersonelBilgileri.Controls.Add(btnKaydet);
            gbPersonelBilgileri.Location = new Point(26, 16);
            gbPersonelBilgileri.Margin = new Padding(3, 4, 3, 4);
            gbPersonelBilgileri.Name = "gbPersonelBilgileri";
            gbPersonelBilgileri.Padding = new Padding(3, 4, 3, 4);
            gbPersonelBilgileri.Size = new Size(813, 355);
            gbPersonelBilgileri.TabIndex = 4;
            gbPersonelBilgileri.TabStop = false;
            gbPersonelBilgileri.Text = "Personel Bilgileri";
            // 
            // pboxResim
            // 
            pboxResim.Location = new Point(478, 187);
            pboxResim.Margin = new Padding(3, 4, 3, 4);
            pboxResim.Name = "pboxResim";
            pboxResim.Size = new Size(182, 147);
            pboxResim.SizeMode = PictureBoxSizeMode.Zoom;
            pboxResim.TabIndex = 7;
            pboxResim.TabStop = false;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(478, 47);
            txtAdres.Margin = new Padding(3, 4, 3, 4);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(274, 68);
            txtAdres.TabIndex = 6;
            // 
            // mtbTelefon
            // 
            mtbTelefon.Location = new Point(122, 233);
            mtbTelefon.Margin = new Padding(3, 4, 3, 4);
            mtbTelefon.Mask = "(999) 000-0000";
            mtbTelefon.Name = "mtbTelefon";
            mtbTelefon.Size = new Size(195, 27);
            mtbTelefon.TabIndex = 5;
            // 
            // dtpIseGirisTarihi
            // 
            dtpIseGirisTarihi.Location = new Point(610, 137);
            dtpIseGirisTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            dtpIseGirisTarihi.Size = new Size(141, 27);
            dtpIseGirisTarihi.TabIndex = 4;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(122, 187);
            dtpDogumTarihi.Margin = new Padding(3, 4, 3, 4);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(195, 27);
            dtpDogumTarihi.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 280);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(122, 140);
            txtSoyad.Margin = new Padding(3, 4, 3, 4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(195, 27);
            txtSoyad.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 291);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 0;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 244);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 0;
            label5.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 197);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 0;
            label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 151);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Soyad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(122, 93);
            txtAd.Margin = new Padding(3, 4, 3, 4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(195, 27);
            txtAd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 104);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 0;
            label2.Text = "Ad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(389, 145);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 0;
            label8.Text = "İşe Giriş Tarihi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(389, 47);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 0;
            label7.Text = "Adres";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 697);
            Controls.Add(gbPersonelBilgileri);
            Controls.Add(lvPersonelListesi);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            gbPersonelBilgileri.ResumeLayout(false);
            gbPersonelBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnResimSec;
        private ListView lvPersonelListesi;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox txtPersonelID;
        private GroupBox gbPersonelBilgileri;
        private MaskedTextBox mtbTelefon;
        private DateTimePicker dtpDogumTarihi;
        private TextBox txtEmail;
        private TextBox txtSoyad;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtAd;
        private Label label2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private PictureBox pboxResim;
        private TextBox txtAdres;
        private DateTimePicker dtpIseGirisTarihi;
        private Label label8;
        private Label label7;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}