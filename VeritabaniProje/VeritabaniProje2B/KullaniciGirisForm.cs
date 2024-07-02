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
    public partial class KullaniciGirisForm : Form
    {
        public KullaniciGirisForm()
        {
            InitializeComponent();
        }


        public static string KullaniciAdi, KTuru;

        public void KullaniciAra()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Select * from Kullanicilar where Kadi='"+txtKadi.Text+"' And Ksifre='"+txtSifre.Text+"'";
                SqlCommand KullaniciKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                SqlDataReader dr = KullaniciKomut.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı\nPrograma Hoşgeldiniz","Giriş");
                    
                    KullaniciAdi = txtKadi.Text;    //Aktif Kullanıcı Adı
                    KTuru = dr["Kturu"].ToString(); //Aktif Kullanıcı Türü
                    
                    Form1.Baglanti.Close();
                    Form1 frmAna = new Form1();
                    frmAna.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı\nTekrar giriş yapınız", "Giriş");

                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kullanıcı Girişi Hata Penceresi");
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKadi.Text == "" || txtSifre.Text == "")
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Geçilemez!","Uyarı");
            else
                KullaniciAra();
        }
    }
}
