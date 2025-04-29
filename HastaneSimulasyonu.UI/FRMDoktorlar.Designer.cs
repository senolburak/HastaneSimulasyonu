namespace HastaneSimulasyonu.UI
{
    partial class FRMDoktorlar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAdSoyad = new TextBox();
            btnGec = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            dgvDoktorlar = new DataGridView();
            cmbBolumler = new ComboBox();
            txtTelefon = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDoktorlar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 61);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 100);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 0;
            label3.Text = "Bölüm";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(103, 25);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(151, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // btnGec
            // 
            btnGec.Location = new Point(24, 406);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(522, 29);
            btnGec.TabIndex = 5;
            btnGec.Text = ">>>>>";
            btnGec.UseVisualStyleBackColor = true;
            btnGec.Click += btnGec_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(294, 176);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(28, 176);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 30);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(150, 176);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 30);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvDoktorlar
            // 
            dgvDoktorlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoktorlar.Location = new Point(24, 212);
            dgvDoktorlar.Name = "dgvDoktorlar";
            dgvDoktorlar.RowHeadersWidth = 51;
            dgvDoktorlar.Size = new Size(522, 188);
            dgvDoktorlar.TabIndex = 9;
            // 
            // cmbBolumler
            // 
            cmbBolumler.FormattingEnabled = true;
            cmbBolumler.Location = new Point(103, 97);
            cmbBolumler.Name = "cmbBolumler";
            cmbBolumler.Size = new Size(151, 28);
            cmbBolumler.TabIndex = 10;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(103, 61);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(151, 27);
            txtTelefon.TabIndex = 1;
            // 
            // FRMDoktorlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 450);
            Controls.Add(cmbBolumler);
            Controls.Add(dgvDoktorlar);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnGuncelle);
            Controls.Add(btnGec);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMDoktorlar";
            Text = "FRMDoktorlar";
            ((System.ComponentModel.ISupportInitialize)dgvDoktorlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAdSoyad;
        private Button btnGec;
        private Button btnGuncelle;
        private Button btnEkle;
        private Button btnSil;
        private DataGridView dgvDoktorlar;
        private ComboBox cmbBolumler;
        private TextBox txtTelefon;
        private TextBox textBox3;
    }
}