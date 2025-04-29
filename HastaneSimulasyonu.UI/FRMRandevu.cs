using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneSimulasyonu.UI.Context;
using HastaneSimulasyonu.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace HastaneSimulasyonu.UI
{
    public partial class FRMRandevu : Form
    {
        private readonly MyDbContext _db;
        public FRMRandevu()
        {
            InitializeComponent();
            _db = new MyDbContext();
            LoadDoktorlar();
            LoadRandevular();
        }
        private void LoadRandevular()
        {
            var randevu = _db.Randevu
                 .Include(r => r.Hasta)
                 .Include(r => r.Doktor)
                 .ThenInclude(r => r.Bolum)
                 .Select(
                r => new
                {
                    HastaAdSoyad =r.Hasta.AdSoyad,
                    RandevuTarihi = r.Tarih,
                    DoktorAdSoyad = r.Doktor.AdSoyad,
                    BolumAdi = r.Doktor.Bolum.Adi,
                }).ToList();
            dgvRandevular.DataSource = randevu;
            ConfigureDataGridView();
        }
        private void ConfigureDataGridView()
        {
            dgvRandevular.Columns["HastaAdSoyad"].HeaderText = "Hasta Adı Soyadı";
            dgvRandevular.Columns["RandevuTarihi"].HeaderText = "Randevu Tarihi";
            dgvRandevular.Columns["BolumAdi"].HeaderText = "Bölüm Adı";
        }
        private void LoadDoktorlar()
        {
            var doktorlar = _db.Doktor.Select(d => new { d.Id, d.AdSoyad }).ToList();
            cmbDoktorlar.DisplayMember = "AdSoyad";
            cmbDoktorlar.ValueMember = "Id";
            cmbDoktorlar.DataSource = doktorlar;
        }
        private void ClearInputs()
        {
            txtAdSoyad.Text = txtSikayet.Text = string.Empty;
            cmbDoktorlar.SelectedIndex = -1;
        }
        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                MessageBox.Show("Ad Soyad Alanını Kontrol Ediniz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSikayet.Text))
            {
                MessageBox.Show("Şikayet Alanını Kontrol Ediniz!");
                return;
            }
            if (cmbDoktorlar.SelectedIndex == -1)
            {
                MessageBox.Show("Doktor Seçiniz!");
                return;
            }
            if (dtpRandevuTarihi.Value <= DateTime.Now)
            {
                MessageBox.Show("Tarih Aralığını Kontrol Ediniz!");
                return;
            }

            //var hasta = new Hasta
            //{
            //    AdSoyad = txtAdSoyad.Text,
            //    Sikayet = txtSikayet.Text,
            //};
            //_db.Hasta.Add(hasta);
            //_db.SaveChanges();
            //var randevu = new Randevu
            //{
            //    HastaId = hasta.Id,
            //    DoktorId= (int)cmbDoktorlar.SelectedValue,
            //    Tarih=dtpRandevuTarihi.Value,
            //};
            //_db.Randevu.Add(randevu);
            //_db.SaveChanges();
            //LoadRandevular();

            using (var transaction = _db.Database.BeginTransaction())
            {
                try
                {
                    var hasta = new Hasta
                    {
                        AdSoyad = txtAdSoyad.Text,
                        Sikayet = txtSikayet.Text,
                    };
                    _db.Hasta.Add(hasta);
                    _db.SaveChanges();

                    int doktorId = (int)cmbDoktorlar.SelectedValue;
                    if (!_db.Doktor.Any(d => d.Id == doktorId))
                    {
                        MessageBox.Show("Seçilen Doktor Veritabanında Bulunamadı!");
                        return;
                    }
                    var randevu = new Randevu
                    {
                        HastaId = hasta.Id,
                        DoktorId = (int)cmbDoktorlar.SelectedValue,
                        Tarih = dtpRandevuTarihi.Value,
                    };
                    _db.Randevu.Add(randevu);
                    _db.SaveChanges();

                    transaction.Commit();

                    MessageBox.Show("Kaydedildi");
                    LoadRandevular();

                    ClearInputs();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Randevu Kaydedilemedi {ex.Message}");
                }
            }
        }
    }
}
