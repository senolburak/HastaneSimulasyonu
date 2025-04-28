using System.Windows.Forms;
using HastaneSimulasyonu.UI.Context;
using HastaneSimulasyonu.UI.Models;

namespace HastaneSimulasyonu.UI
{
    public partial class FRMBolumler : Form
    {
        MyDbContext _db;
        Bolum bolum;
        public FRMBolumler()
        {
            InitializeComponent();
            _db = new MyDbContext();
            LoadBolumler();
        }
        private void ClearInputs()
        {
            txtBolumAd.Text = txtBolumAciklama.Text = string.Empty;
        }
        private void LoadBolumler()
        {
            var bolumler = _db.Bolum.ToList();
            dgvBolumler.DataSource = bolumler;
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtBolumAd.Text))
            {
                MessageBox.Show("Bölüm Adýný Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBolumAciklama.Text))
            {
                MessageBox.Show("Bölüm Açýklamasýný Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var bolum = new Bolum()
            {
                Adi = txtBolumAd.Text,
                Aciklama = txtBolumAciklama.Text
            };
            _db.Bolum.Add(bolum);
            _db.SaveChanges();
            MessageBox.Show("Eklendi");
            ClearInputs();
            LoadBolumler();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            var bolumId = (dgvBolumler.SelectedRows[0].DataBoundItem as Bolum).Id;

            var bolum = _db.Bolum.FirstOrDefault(b => b.Id == bolumId);

            if (bolum != null)
            {
                _db.Remove(bolum);
                _db.SaveChanges();
                MessageBox.Show("Silindi");
            }
            LoadBolumler();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var bolumId = (dgvBolumler.SelectedRows[0].DataBoundItem as Bolum).Id;

            var bolum = _db.Bolum.FirstOrDefault(b => b.Id == bolumId);

            if (bolum != null)
            {
                bolum.Adi = txtBolumAd.Text;
                bolum.Aciklama = txtBolumAciklama.Text;
                _db.SaveChanges();
                LoadBolumler();
                ClearInputs();
            }
        }
    }
}

