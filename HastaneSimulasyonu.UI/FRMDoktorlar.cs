using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneSimulasyonu.UI.Context;
using HastaneSimulasyonu.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace HastaneSimulasyonu.UI
{
    public partial class FRMDoktorlar : Form
    {
        private readonly MyDbContext _db;
        Doktor secilenDoktor;
        public FRMDoktorlar()
        {
            InitializeComponent();
            _db = new MyDbContext();
            LoadDoktorlar();
            LoadBolumler();
        }
        private void LoadBolumler()
        {
            var bolumler = _db.Bolum
                .Select(b => new
                {
                    b.Id,
                    b.Adi
                }).ToList();
            cmbBolumler.DisplayMember = "Adi";
            cmbBolumler.ValueMember = "Id";
            cmbBolumler.DataSource = bolumler;
        }
        private void LoadDoktorlar()
        {
            var doktorlar = _db.Doktor
                .Include(d => d.Bolum)
                .Select(d => new
                {
                    d.Id,
                    d.AdSoyad,
                    d.Telefon,
                    BolumAdi = d.Bolum.Adi
                }).ToList();
            dgvDoktorlar.DataSource = doktorlar;
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                MessageBox.Show("Ad Soyad Bölümünü Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (int.TryParse(txtTelefon.Text, out int sonuc))
            {
                MessageBox.Show("Telefon Numarası Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbBolumler.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Bölüm Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void CleanInputs()
        {
            txtAdSoyad.Text = txtTelefon.Text = string.Empty;
            cmbBolumler.SelectedIndex = -1;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var doktor = new Doktor()
            {
                AdSoyad = txtAdSoyad.Text,
                Telefon = txtTelefon.Text,
                BolumId = (int)cmbBolumler.SelectedValue
            };
            _db.Doktor.Add(doktor);
            _db.SaveChanges();
            MessageBox.Show("Eklendi");
            CleanInputs();
            LoadBolumler();
            LoadDoktorlar();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if(dgvDoktorlar.SelectedRows.Count==0)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Satırı Seçiniz");
                return;
            }

            var doktorId = (int)(dgvDoktorlar.SelectedRows[0].Cells["Id"].Value);
            var doktor = _db.Doktor.FirstOrDefault(d => d.Id == doktorId);

            if (doktor != null)
            {
                _db.Doktor.Remove(doktor);
                _db.SaveChanges();
                MessageBox.Show("Silindi");
                LoadBolumler();
                LoadDoktorlar();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secilenDoktor.AdSoyad = txtAdSoyad.Text;
            secilenDoktor.Telefon = txtTelefon.Text;
            secilenDoktor.BolumId = (cmbBolumler.SelectedItem as Bolum).Id;

            _db.SaveChanges();
        }
    }
}
