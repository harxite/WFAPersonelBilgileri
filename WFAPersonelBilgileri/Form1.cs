using System;

namespace WFAPersonelBilgileri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Personel> People = new List<Personel>();
        string dosyaYolu;
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpg (.jpg)|*.jpg|Png(.png)|*.png";
            ofd.ShowDialog();
            dosyaYolu = ofd.FileName;
            pboxResim.ImageLocation = dosyaYolu;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Personel personel1 = new Personel();
                personel1.PersonelID = int.Parse(txtPersonelID.Text);
                personel1.Ad = txtAd.Text;
                personel1.Soyad = txtSoyad.Text;
                personel1.Adres = txtAdres.Text;
                personel1.DogumTarihi = dtpDogumTarihi.Value;
                personel1.Telefon = mtbTelefon.Text;
                personel1.Email = txtEmail.Text;
                personel1.IseGirisTarihi = dtpIseGirisTarihi.Value;
                personel1.ResimYolu = dosyaYolu;

                People.Add(personel1);
                ListViewDoldur();
                FormuTemizle();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListViewDoldur()
        {
            lvPersonelListesi.Items.Clear();
            foreach (Personel personel in People)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = personel.PersonelID.ToString();
                lvi.SubItems.Add(personel.Ad);
                lvi.SubItems.Add(personel.Soyad);
                lvi.SubItems.Add(personel.DogumTarihi.ToString());
                lvi.SubItems.Add(personel.Telefon.ToString());
                lvi.SubItems.Add(personel.Email);
                lvi.SubItems.Add(personel.ResimYolu);

                lvPersonelListesi.Items.Add(lvi);
            }
        }

        public void FormuTemizle()
        {
            txtPersonelID.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            dtpDogumTarihi.Value = DateTime.Now;
            mtbTelefon.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
            dtpIseGirisTarihi.Value = DateTime.Now;
        }

        int selectedIndex = 0;
        private void lvPersonelListesi_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvPersonelListesi.SelectedItems.Count > 0)
            {
                selectedIndex = lvPersonelListesi.SelectedIndices[0];
                btnResimSec.Enabled = true;
                btnKaydet.Enabled = false;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            else
            {
                btnResimSec.Enabled = true;
                btnKaydet.Enabled = true;
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
            }
            FormuDoldur(selectedIndex);
        }

        public void FormuDoldur(int indeks)
        {
            txtPersonelID.Text = People[indeks].PersonelID.ToString();
            txtAd.Text = People[indeks].Ad;
            txtSoyad.Text = People[indeks].Soyad;
            dtpDogumTarihi.Value = People[indeks].DogumTarihi;
            mtbTelefon.Text = People[indeks].Telefon;
            txtEmail.Text = People[indeks].Email;
            txtAdres.Text = People[indeks].Adres;
            dtpIseGirisTarihi.Value = People[indeks].IseGirisTarihi;
            pboxResim.ImageLocation = People[indeks].ResimYolu;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            People[selectedIndex].PersonelID = int.Parse(txtPersonelID.Text);
            People[selectedIndex].Ad = txtAd.Text;
            People[selectedIndex].Soyad = txtSoyad.Text;
            People[selectedIndex].Adres = txtAdres.Text;
            People[selectedIndex].DogumTarihi = dtpDogumTarihi.Value;
            People[selectedIndex].Telefon = mtbTelefon.Text;
            People[selectedIndex].Email = txtEmail.Text;
            People[selectedIndex].IseGirisTarihi = dtpIseGirisTarihi.Value;
            People[selectedIndex].ResimYolu = dosyaYolu;

            ListViewDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lvPersonelListesi.Items[selectedIndex].Remove();
            FormuTemizle();
        }
    }
}