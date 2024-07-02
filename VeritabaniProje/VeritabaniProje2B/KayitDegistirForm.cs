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
    public partial class KayitDegistirForm : Form
    {
        public KayitDegistirForm()
        {
            InitializeComponent();
        }

        //Birimler tablosunun BirimAdi alanından cmbBirim isimli ComboBoxa veri ekler
        public void BirimYukle()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Select BirimAdi from Birimler";
                SqlCommand YukleKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                SqlDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbBirim.Items.Add(dr["BirimAdi"]);
                }
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }

        }

        public void KayitDegistir()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Update Personel Set Tcno=@Tcno,Ad=@Ad,Soyad=@Soyad,Cinsiyet=@Cinsiyet,Dyer=@Dyer,Dtar=@Dtar,Tel=@Tel,Birim=@Birim where PerID=@PerID";
                SqlCommand DegistirKomut = new SqlCommand(Sorgu,Form1.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Tcno", txtTcno.Text);
                DegistirKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                DegistirKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                if (radErkek.Checked == true)
                    DegistirKomut.Parameters.AddWithValue("@Cinsiyet", "Erkek");
                else if (radKadin.Checked == true)
                    DegistirKomut.Parameters.AddWithValue("@Cinsiyet", "Kadın");
                DegistirKomut.Parameters.AddWithValue("@Dyer", cmbDyer.Text);
                DegistirKomut.Parameters.AddWithValue("@Dtar", dtDtar.Value);
                DegistirKomut.Parameters.AddWithValue("@Tel", txtTel.Text);
                DegistirKomut.Parameters.AddWithValue("@Birim", cmbBirim.Text);
                DegistirKomut.Parameters.AddWithValue("@PerID", txtPerID.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtPerID.Text+" Nolu Kayıt Değiştirildi");
                Form1.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message,"Kayıt Değiştir Hata Penceresi");
            }
        
        }


        public bool BoslukKontrol()
        {
            bool bos = false;

            yildizTcno.Visible = false;
            yildizAd.Visible = false;
            yildizSoyad.Visible = false;
            yildizCinsiyet.Visible = false;
            yildizDyer.Visible = false;
            yildizDtar.Visible = false;
            yildizTel.Visible = false;
            yildizBirim.Visible = false;

            if (cmbBirim.Text == "" || cmbBirim.Text == "Birim Seçiniz")
            {
                yildizBirim.Visible = true;
                cmbBirim.Focus();
                bos = true;
            }

            if (txtTel.Text.Length < 14)
            {
                yildizTel.Visible = true;
                txtTel.Focus();
                bos = true;
            }

            if (dtDtar.Value.Date == DateTime.Today.Date)
            {
                yildizDtar.Visible = true;
                dtDtar.Focus();
                bos = true;
            }

            if (cmbDyer.Text == "" || cmbDyer.Text == "Şehir Seçiniz")
            {
                yildizDyer.Visible = true;
                cmbDyer.Focus();
                bos = true;
            }

            if (radErkek.Checked == false && radKadin.Checked == false)
            {
                yildizCinsiyet.Visible = true;
                bos = true;
            }

            if (txtSoyad.Text == "")
            {
                yildizSoyad.Visible = true;
                txtSoyad.Focus();
                bos = true;
            }

            if (txtAd.Text == "")
            {
                yildizAd.Visible = true;
                txtAd.Focus();
                bos = true;
            }

            if (txtTcno.Text.Length < 11)
            {
                yildizTcno.Visible = true;
                txtTcno.Focus();
                bos = true;
            }

            return bos;
        }


        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Yıldızlı alanlar boş geçilemez!", "Dikkat");
            else
                KayitDegistir();
            

        }

        private void KayitDegistirForm_Load(object sender, EventArgs e)
        {
            BirimYukle();
        }
    }
}
