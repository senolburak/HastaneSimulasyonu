namespace HastaneSimulasyonu.UI
{
    partial class FRMRandevu
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
            label4 = new Label();
            txtAdSoyad = new TextBox();
            txtSikayet = new TextBox();
            cmbDoktorlar = new ComboBox();
            dtpRandevuTarihi = new DateTimePicker();
            dgvRandevular = new DataGridView();
            btnRandevuAl = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRandevular).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 65);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Şikayet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 107);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "Doktor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 153);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 3;
            label4.Text = "Randevu Tarihi";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(132, 17);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(251, 27);
            txtAdSoyad.TabIndex = 4;
            // 
            // txtSikayet
            // 
            txtSikayet.Location = new Point(132, 58);
            txtSikayet.Name = "txtSikayet";
            txtSikayet.Size = new Size(251, 27);
            txtSikayet.TabIndex = 5;
            // 
            // cmbDoktorlar
            // 
            cmbDoktorlar.FormattingEnabled = true;
            cmbDoktorlar.Location = new Point(133, 99);
            cmbDoktorlar.Name = "cmbDoktorlar";
            cmbDoktorlar.Size = new Size(250, 28);
            cmbDoktorlar.TabIndex = 6;
            // 
            // dtpRandevuTarihi
            // 
            dtpRandevuTarihi.Location = new Point(133, 148);
            dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            dtpRandevuTarihi.Size = new Size(250, 27);
            dtpRandevuTarihi.TabIndex = 7;
            // 
            // dgvRandevular
            // 
            dgvRandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRandevular.Location = new Point(16, 250);
            dgvRandevular.Name = "dgvRandevular";
            dgvRandevular.RowHeadersWidth = 51;
            dgvRandevular.Size = new Size(485, 188);
            dgvRandevular.TabIndex = 8;
            // 
            // btnRandevuAl
            // 
            btnRandevuAl.Location = new Point(22, 215);
            btnRandevuAl.Name = "btnRandevuAl";
            btnRandevuAl.Size = new Size(158, 29);
            btnRandevuAl.TabIndex = 11;
            btnRandevuAl.Text = "Randevu Oluştur";
            btnRandevuAl.UseVisualStyleBackColor = true;
            btnRandevuAl.Click += btnRandevuAl_Click;
            // 
            // FRMRandevu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 450);
            Controls.Add(btnRandevuAl);
            Controls.Add(dgvRandevular);
            Controls.Add(dtpRandevuTarihi);
            Controls.Add(cmbDoktorlar);
            Controls.Add(txtSikayet);
            Controls.Add(txtAdSoyad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FRMRandevu";
            Text = "FRMRandevu";
            ((System.ComponentModel.ISupportInitialize)dgvRandevular).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAdSoyad;
        private TextBox txtSikayet;
        private ComboBox cmbDoktorlar;
        private DateTimePicker dtpRandevuTarihi;
        private DataGridView dgvRandevular;
        private Button btnRandevuAl;
    }
}