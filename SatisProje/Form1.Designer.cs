namespace SatisProje
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbUrun = new System.Windows.Forms.ComboBox();
            this.CmbMusteri = new System.Windows.Forms.ComboBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.CmbPersonel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnMusteriEkle = new System.Windows.Forms.Button();
            this.dataGridViewMusteri = new System.Windows.Forms.DataGridView();
            this.TxtMusteriAd = new System.Windows.Forms.TextBox();
            this.TxtMusteriID = new System.Windows.Forms.TextBox();
            this.LblMusteriID = new System.Windows.Forms.Label();
            this.BtnMusteriSil = new System.Windows.Forms.Button();
            this.BtnMusGuncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtPersonelID = new System.Windows.Forms.TextBox();
            this.BtnPersonelGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnPersonelSil = new System.Windows.Forms.Button();
            this.BtnPersonelEkle = new System.Windows.Forms.Button();
            this.TxtPersonelAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(343, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(614, 234);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri:";
            // 
            // CmbUrun
            // 
            this.CmbUrun.FormattingEnabled = true;
            this.CmbUrun.Location = new System.Drawing.Point(111, 65);
            this.CmbUrun.Name = "CmbUrun";
            this.CmbUrun.Size = new System.Drawing.Size(189, 32);
            this.CmbUrun.TabIndex = 4;
            // 
            // CmbMusteri
            // 
            this.CmbMusteri.FormattingEnabled = true;
            this.CmbMusteri.Location = new System.Drawing.Point(111, 103);
            this.CmbMusteri.Name = "CmbMusteri";
            this.CmbMusteri.Size = new System.Drawing.Size(189, 32);
            this.CmbMusteri.TabIndex = 5;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(170, 227);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(130, 36);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // CmbPersonel
            // 
            this.CmbPersonel.FormattingEnabled = true;
            this.CmbPersonel.Location = new System.Drawing.Point(111, 141);
            this.CmbPersonel.Name = "CmbPersonel";
            this.CmbPersonel.Size = new System.Drawing.Size(189, 32);
            this.CmbPersonel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Personel:";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(111, 179);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(189, 30);
            this.TxtFiyat.TabIndex = 12;
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(22, 227);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(130, 36);
            this.BtnGüncelle.TabIndex = 13;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(111, 29);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(189, 30);
            this.TxtID.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Satış ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnGüncelle);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.CmbUrun);
            this.groupBox1.Controls.Add(this.TxtFiyat);
            this.groupBox1.Controls.Add(this.CmbMusteri);
            this.groupBox1.Controls.Add(this.CmbPersonel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 276);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış İşlemleri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Müşteri:";
            // 
            // BtnMusteriEkle
            // 
            this.BtnMusteriEkle.Location = new System.Drawing.Point(16, 112);
            this.BtnMusteriEkle.Name = "BtnMusteriEkle";
            this.BtnMusteriEkle.Size = new System.Drawing.Size(130, 36);
            this.BtnMusteriEkle.TabIndex = 19;
            this.BtnMusteriEkle.Text = "Ekle";
            this.BtnMusteriEkle.UseVisualStyleBackColor = true;
            this.BtnMusteriEkle.Click += new System.EventHandler(this.BtnMusteriEkle_Click);
            // 
            // dataGridViewMusteri
            // 
            this.dataGridViewMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteri.Location = new System.Drawing.Point(331, 298);
            this.dataGridViewMusteri.Name = "dataGridViewMusteri";
            this.dataGridViewMusteri.RowHeadersWidth = 51;
            this.dataGridViewMusteri.RowTemplate.Height = 24;
            this.dataGridViewMusteri.Size = new System.Drawing.Size(302, 191);
            this.dataGridViewMusteri.TabIndex = 20;
            this.dataGridViewMusteri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMusteri_CellDoubleClick);
            // 
            // TxtMusteriAd
            // 
            this.TxtMusteriAd.Location = new System.Drawing.Point(112, 65);
            this.TxtMusteriAd.Name = "TxtMusteriAd";
            this.TxtMusteriAd.Size = new System.Drawing.Size(189, 30);
            this.TxtMusteriAd.TabIndex = 21;
            // 
            // TxtMusteriID
            // 
            this.TxtMusteriID.Location = new System.Drawing.Point(112, 29);
            this.TxtMusteriID.Name = "TxtMusteriID";
            this.TxtMusteriID.ReadOnly = true;
            this.TxtMusteriID.Size = new System.Drawing.Size(189, 30);
            this.TxtMusteriID.TabIndex = 23;
            // 
            // LblMusteriID
            // 
            this.LblMusteriID.AutoSize = true;
            this.LblMusteriID.Location = new System.Drawing.Point(12, 32);
            this.LblMusteriID.Name = "LblMusteriID";
            this.LblMusteriID.Size = new System.Drawing.Size(39, 24);
            this.LblMusteriID.TabIndex = 22;
            this.LblMusteriID.Text = "ID:";
            // 
            // BtnMusteriSil
            // 
            this.BtnMusteriSil.Location = new System.Drawing.Point(171, 112);
            this.BtnMusteriSil.Name = "BtnMusteriSil";
            this.BtnMusteriSil.Size = new System.Drawing.Size(130, 36);
            this.BtnMusteriSil.TabIndex = 24;
            this.BtnMusteriSil.Text = "Sil";
            this.BtnMusteriSil.UseVisualStyleBackColor = true;
            this.BtnMusteriSil.Click += new System.EventHandler(this.BtnMusteriSil_Click);
            // 
            // BtnMusGuncelle
            // 
            this.BtnMusGuncelle.Location = new System.Drawing.Point(16, 161);
            this.BtnMusGuncelle.Name = "BtnMusGuncelle";
            this.BtnMusGuncelle.Size = new System.Drawing.Size(130, 36);
            this.BtnMusGuncelle.TabIndex = 25;
            this.BtnMusGuncelle.Text = "Güncelle";
            this.BtnMusGuncelle.UseVisualStyleBackColor = true;
            this.BtnMusGuncelle.Click += new System.EventHandler(this.BtnMusGuncelle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtMusteriID);
            this.groupBox2.Controls.Add(this.BtnMusGuncelle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnMusteriSil);
            this.groupBox2.Controls.Add(this.BtnMusteriEkle);
            this.groupBox2.Controls.Add(this.TxtMusteriAd);
            this.groupBox2.Controls.Add(this.LblMusteriID);
            this.groupBox2.Location = new System.Drawing.Point(4, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 205);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri İşlemleri";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtPersonelID);
            this.groupBox3.Controls.Add(this.BtnPersonelGuncelle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.BtnPersonelSil);
            this.groupBox3.Controls.Add(this.BtnPersonelEkle);
            this.groupBox3.Controls.Add(this.TxtPersonelAd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(639, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 205);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel İşlemleri";
            // 
            // TxtPersonelID
            // 
            this.TxtPersonelID.Location = new System.Drawing.Point(112, 29);
            this.TxtPersonelID.Name = "TxtPersonelID";
            this.TxtPersonelID.ReadOnly = true;
            this.TxtPersonelID.Size = new System.Drawing.Size(189, 30);
            this.TxtPersonelID.TabIndex = 23;
            // 
            // BtnPersonelGuncelle
            // 
            this.BtnPersonelGuncelle.Location = new System.Drawing.Point(16, 161);
            this.BtnPersonelGuncelle.Name = "BtnPersonelGuncelle";
            this.BtnPersonelGuncelle.Size = new System.Drawing.Size(130, 36);
            this.BtnPersonelGuncelle.TabIndex = 25;
            this.BtnPersonelGuncelle.Text = "Güncelle";
            this.BtnPersonelGuncelle.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Personel:";
            // 
            // BtnPersonelSil
            // 
            this.BtnPersonelSil.Location = new System.Drawing.Point(171, 112);
            this.BtnPersonelSil.Name = "BtnPersonelSil";
            this.BtnPersonelSil.Size = new System.Drawing.Size(130, 36);
            this.BtnPersonelSil.TabIndex = 24;
            this.BtnPersonelSil.Text = "Sil";
            this.BtnPersonelSil.UseVisualStyleBackColor = true;
            // 
            // BtnPersonelEkle
            // 
            this.BtnPersonelEkle.Location = new System.Drawing.Point(16, 112);
            this.BtnPersonelEkle.Name = "BtnPersonelEkle";
            this.BtnPersonelEkle.Size = new System.Drawing.Size(130, 36);
            this.BtnPersonelEkle.TabIndex = 19;
            this.BtnPersonelEkle.Text = "Ekle";
            this.BtnPersonelEkle.UseVisualStyleBackColor = true;
            // 
            // TxtPersonelAd
            // 
            this.TxtPersonelAd.Location = new System.Drawing.Point(112, 65);
            this.TxtPersonelAd.Name = "TxtPersonelAd";
            this.TxtPersonelAd.Size = new System.Drawing.Size(189, 30);
            this.TxtPersonelAd.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(963, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(302, 191);
            this.dataGridView1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 685);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewMusteri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Satış İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbUrun;
        private System.Windows.Forms.ComboBox CmbMusteri;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.ComboBox CmbPersonel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnMusteriEkle;
        private System.Windows.Forms.DataGridView dataGridViewMusteri;
        private System.Windows.Forms.TextBox TxtMusteriAd;
        private System.Windows.Forms.TextBox TxtMusteriID;
        private System.Windows.Forms.Label LblMusteriID;
        private System.Windows.Forms.Button BtnMusteriSil;
        private System.Windows.Forms.Button BtnMusGuncelle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtPersonelID;
        private System.Windows.Forms.Button BtnPersonelGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnPersonelSil;
        private System.Windows.Forms.Button BtnPersonelEkle;
        private System.Windows.Forms.TextBox TxtPersonelAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

