using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeritabaniProje2B
{
    public partial class KullaniciislemForm : Form
    {
        public KullaniciislemForm()
        {
            InitializeComponent();
        }

        public void KullaniciListele()
        {
            try
            {
                Form1.BaglantiAc();
                DataSet ds = new DataSet();
                string YoneticiSorgu = "Select * from Kullanicilar";
                string KullaniciSorgu = "Select * from Kullanicilar where Kadi='"+lblKadi.Text+"'";

                if (lblKTuru.Text != "Yönetici")
                    YoneticiSorgu = KullaniciSorgu;

                SqlDataAdapter da = new SqlDataAdapter(YoneticiSorgu, Form1.Baglanti);
                da.Fill(ds, "Kullanicilar");
                dataGridView1.DataSource = ds.Tables["Kullanicilar"];
                Form1.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kullanici Listele Hata Penceresi");

            }
        }

        public void SifreDegistir()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Update Kullanicilar Set Ksifre=@Ksifre where KKod=@KKod";
                SqlCommand DegistirKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Ksifre", txtSifre.Text);
                DegistirKomut.Parameters.AddWithValue("@KKod", txtKkodu.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtKadi.Text + " İsimli Kullacının Şifresi Değiştirildi");
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Şifre Değiştir Hata Penceresi");
            }

        }


        private void KullaniciislemForm_Load(object sender, EventArgs e)
        {
            lblKadi.Text = KullaniciGirisForm.KullaniciAdi;
            lblKTuru.Text = KullaniciGirisForm.KTuru;

            if (lblKTuru.Text != "Yönetici")
            {
                txtKadi.Enabled = false;
                cmbKturu.Enabled = false;
                btnYeni.Enabled = false;
                btnSil.Enabled = false;
            }

            KullaniciListele();
        }

        private void KullaniciislemForm_Activated(object sender, EventArgs e)
        {
            Form1.Baglanti.Close();
            KullaniciListele();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtKkodu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtKadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmbKturu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
                MessageBox.Show("Şifreyi giriniz", "Dikkat");
            else
                SifreDegistir();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }
    }
}
