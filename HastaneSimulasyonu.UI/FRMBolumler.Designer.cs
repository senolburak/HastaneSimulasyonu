namespace HastaneSimulasyonu.UI
{
    partial class FRMBolumler
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
            btnEkle = new Button();
            dgvBolumler = new DataGridView();
            txtBolumAd = new TextBox();
            label2 = new Label();
            txtBolumAciklama = new TextBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnGec = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBolumler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 42);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Bölüm Ad";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(8, 150);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // dgvBolumler
            // 
            dgvBolumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBolumler.Location = new Point(8, 185);
            dgvBolumler.Name = "dgvBolumler";
            dgvBolumler.RowHeadersWidth = 51;
            dgvBolumler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBolumler.Size = new Size(409, 203);
            dgvBolumler.TabIndex = 2;
            // 
            // txtBolumAd
            // 
            txtBolumAd.Location = new Point(87, 35);
            txtBolumAd.Name = "txtBolumAd";
            txtBolumAd.Size = new Size(330, 27);
            txtBolumAd.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Açıklama";
            // 
            // txtBolumAciklama
            // 
            txtBolumAciklama.Location = new Point(87, 77);
            txtBolumAciklama.Multiline = true;
            txtBolumAciklama.Name = "txtBolumAciklama";
            txtBolumAciklama.Size = new Size(330, 55);
            txtBolumAciklama.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(323, 150);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(163, 150);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGec
            // 
            btnGec.Location = new Point(8, 394);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(409, 29);
            btnGec.TabIndex = 1;
            btnGec.Text = ">>>>";
            btnGec.UseVisualStyleBackColor = true;
            btnGec.Click += btnGec_Click;
            // 
            // FRMBolumler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 450);
            Controls.Add(txtBolumAciklama);
            Controls.Add(txtBolumAd);
            Controls.Add(dgvBolumler);
            Controls.Add(label2);
            Controls.Add(btnGec);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Name = "FRMBolumler";
            Text = "Bölüm";
            ((System.ComponentModel.ISupportInitialize)dgvBolumler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEkle;
        private DataGridView dgvBolumler;
        private TextBox txtBolumAd;
        private Label label2;
        private TextBox txtBolumAciklama;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnGec;
    }
}
