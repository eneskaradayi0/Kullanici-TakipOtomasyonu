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
    public partial class KayitEkleForm : Form
    {
        public KayitEkleForm()
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
                SqlCommand YukleKomut = new SqlCommand(Sorgu,Form1.Baglanti);
                SqlDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbBirim.Items.Add(dr["BirimAdi"]);
                }
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message,"Veri Yükleme Hata Penceresi");
            }
        
        }


        //Personel tablosuna formdaki kontrollere girilen verileri kayıt olarak ekler
        public void KayitEkle()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Insert Into Personel (Tcno,Ad,Soyad,Cinsiyet,Dyer,Dtar,Tel,Birim) Values (@Tcno,@Ad,@Soyad,@Cinsiyet,@Dyer,@Dtar,@Tel,@Birim)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu,Form1.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Tcno", txtTcno.Text);
                EkleKomut.Parameters.AddWithValue("@Ad", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                if (radErkek.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "Erkek");
                else if (radKadin.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "Kadın");
                EkleKomut.Parameters.AddWithValue("@Dyer", cmbDyer.Text);
                EkleKomut.Parameters.AddWithValue("@Dtar", dtDtar.Value);
                EkleKomut.Parameters.AddWithValue("@Tel", txtTel.Text);
                EkleKomut.Parameters.AddWithValue("@Birim", cmbBirim.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                Form1.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message,"Kayıt Ekle Hata Penceresi");
            }
        }

        //Kayıt ekle formunda bosluk kontrolü yaparak geriye true veya false değerini döndüren method
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

            if(dtDtar.Value.Date==DateTime.Today.Date)
            {
                yildizDtar.Visible = true;
                dtDtar.Focus();
                bos = true;
            }

            if(cmbDyer.Text==""||cmbDyer.Text== "Şehir Seçiniz")
            {
                yildizDyer.Visible = true;
                cmbDyer.Focus();
                bos = true;
            }

            if(radErkek.Checked==false&&radKadin.Checked==false)
            {
                yildizCinsiyet.Visible = true;
                bos = true;
            }

            if (txtSoyad.Text=="")
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

            if(txtTcno.Text.Length<11)
            {
                yildizTcno.Visible = true;
                txtTcno.Focus();
                bos = true;
            }

            return bos;
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == false)
                KayitEkle();
            else
                MessageBox.Show("Yıldızlı alanlar boş geçilemez!","Dikkat");
        }

        private void KayitEkleForm_Load(object sender, EventArgs e)
        {
            BirimYukle();
        }
    }
}
