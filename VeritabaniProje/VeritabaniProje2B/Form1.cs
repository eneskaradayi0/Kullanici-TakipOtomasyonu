using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //Ado.Net Sql Server Veritabanı Kütüphanesi


namespace VeritabaniProje2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static SqlConnection Baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VeriTabaniProje2B;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public static void BaglantiAc()
        {
            try
            {
                if (Baglanti.State == ConnectionState.Closed)
                {
                    Baglanti.Open();
                    //MessageBox.Show("Veritabanı Bağlantısı Açıldı");
                }
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message,"Bağlantı Açma Hata Penceresi");
            }

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
                    cmbBirimara.Items.Add(dr["BirimAdi"]);
                }
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }

        }


        public void KayitListele()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * from Personel";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Personel");
                dataGridView1.DataSource = ds.Tables["Personel"];
                Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message,"Kayıt Listele Hata Penceresi");
 
            }
        }

        //Personel tablosunda seçili alanlara göre BİREBİR arama yapar
        public void KayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * from Personel";
                string SorguSoyad = "Select * from Personel where Soyad='"+txtSoyadara.Text+"'";
                string SorguDyer = "Select * from Personel where Dyer='"+cmbDyerara.Text+"'";
                string SorguBirim = "Select * from Personel where Birim = '"+cmbBirimara.Text+"'";
                string SorguSoyadDyer = "Select * from Personel where Soyad='" + txtSoyadara.Text + "' and Dyer='" + cmbDyerara.Text + "'";
                string SorguSoyadBirim = "Select * from Personel where Soyad='" + txtSoyadara.Text + "' and Birim='" + cmbBirimara.Text + "'";
                string SorguDyerBirim = "Select * from Personel where Dyer='" + cmbDyerara.Text + "' and Birim='" + cmbBirimara.Text + "'";
                string SorguSoyadDyerBirim = "Select * from Personel where Soyad='" + txtSoyadara.Text + "' and Dyer='" + cmbDyerara.Text + "' and Birim='" + cmbBirimara.Text + "'";


                if (chkSoyad.Checked == true && chkDyer.Checked == true&& chkBirim.Checked==true)
                    SorguTum = SorguSoyadDyerBirim;
                else if (chkSoyad.Checked == true && chkDyer.Checked == true)
                    SorguTum = SorguSoyadDyer;
                else if (chkSoyad.Checked == true && chkBirim.Checked == true)
                    SorguTum = SorguSoyadBirim;
                else if (chkDyer.Checked == true && chkBirim.Checked == true)
                    SorguTum = SorguDyerBirim;
                else if (chkSoyad.Checked == true)
                    SorguTum = SorguSoyad;
                else if (chkDyer.Checked == true)
                    SorguTum = SorguDyer;
                else if (chkBirim.Checked == true)
                    SorguTum = SorguBirim;


                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Baglanti);
                da.Fill(ds, "Personel");
                dataGridView1.DataSource = ds.Tables["Personel"];
                Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");

            }
        }

        //Personel tablosunda seçili alanlara ve arama türüne göre BENZER kayıtları YAZARKEN arar
        public void HizliAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTum = "Select * from Personel";
                string SorguTcnoilebaslayan = "Select * from Personel where Tcno like '" +txtHizliara.Text+ "%'";
                string SorguTcnoilebiten = "Select * from Personel where Tcno like '%" + txtHizliara.Text + "'";
                string SorguTcnoiceren = "Select * from Personel where Tcno like '%" + txtHizliara.Text + "%'";

                string SorguSoyadilebaslayan = "Select * from Personel where Soyad like '" + txtHizliara.Text + "%'";
                string SorguSoyadilebiten = "Select * from Personel where Soyad like '%" + txtHizliara.Text + "'";
                string SorguSoyadiceren = "Select * from Personel where Soyad like '%" + txtHizliara.Text + "%'";

                string SorguAdilebaslayan = "Select * from Personel where Ad like '" + txtHizliara.Text + "%'";
                string SorguAdilebiten = "Select * from Personel where Ad like '%" + txtHizliara.Text + "'";
                string SorguAdiceren = "Select * from Personel where Ad like '%" + txtHizliara.Text + "%'";

                string SorguTelilebaslayan = "Select * from Personel where Tel like '(" + txtHizliara.Text + "%'";
                string SorguTelilebiten = "Select * from Personel where Tel like '%" + txtHizliara.Text + "'";
                string SorguTeliceren = "Select * from Personel where Tel like '%" + txtHizliara.Text + "%'";


                if (cmbAramaturu.Text=="İle Başlayan")
                {
                    if (radTcno.Checked == true)
                        SorguTum = SorguTcnoilebaslayan;
                    else if (radSoyad.Checked == true)
                        SorguTum = SorguSoyadilebaslayan;
                    else if (radAd.Checked == true)
                        SorguTum = SorguAdilebaslayan;
                    else if (radTel.Checked == true)
                        SorguTum = SorguTelilebaslayan;
                }
                else if(cmbAramaturu.Text=="İle Biten")
                {
                    if (radTcno.Checked == true)
                        SorguTum = SorguTcnoilebiten;
                    else if (radSoyad.Checked == true)
                        SorguTum = SorguSoyadilebiten;
                    else if (radAd.Checked == true)
                        SorguTum = SorguAdilebiten;
                    else if (radTel.Checked == true)
                        SorguTum = SorguTelilebiten;
                }
                else if(cmbAramaturu.Text=="İçeren")
                {
                    if (radTcno.Checked == true)
                        SorguTum = SorguTcnoiceren;
                    else if (radSoyad.Checked == true)
                        SorguTum = SorguSoyadiceren;
                    else if (radAd.Checked == true)
                        SorguTum = SorguAdiceren;
                    else if (radTel.Checked == true)
                        SorguTum = SorguTeliceren;
                }

                SqlDataAdapter da = new SqlDataAdapter(SorguTum, Baglanti);
                da.Fill(ds, "Personel");
                dataGridView1.DataSource = ds.Tables["Personel"];
                Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            KayitListele();
            BirimYukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KayitEkleForm frmEkle = new KayitEkleForm();
            frmEkle.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Baglanti.Close();
            KayitListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
             
            KayitSilForm frmSil = new KayitSilForm();
            frmSil.txtPerID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmSil.txtTcno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmSil.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmSil.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            frmSil.ShowDialog();

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            KayitDegistirForm frmDegistir = new KayitDegistirForm();

            frmDegistir.txtPerID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmDegistir.txtTcno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmDegistir.txtAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frmDegistir.txtSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Erkek")
                frmDegistir.radErkek.Checked = true;
            else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Kadin")
                frmDegistir.radKadin.Checked = true;
            frmDegistir.cmbDyer.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frmDegistir.dtDtar.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frmDegistir.txtTel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frmDegistir.cmbBirim.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
         
            frmDegistir.ShowDialog();
        }

        private void chkSoyad_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSoyad.Checked==true)
            {
                txtSoyadara.Enabled = true;
                txtSoyadara.Focus();
            }
            else if(chkSoyad.Checked==false)
            {
                txtSoyadara.Enabled = false;
                txtSoyadara.Text = "";
            }
        }

        private void chkDyer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDyer.Checked == true)
            {
                cmbDyerara.Enabled = true;
                cmbDyerara.Focus();
            }
            else if (chkDyer.Checked == false)
            {
                cmbDyerara.Enabled = false;
                cmbDyerara.Text = "";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void chkBirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBirim.Checked == true)
            {
                cmbBirimara.Enabled = true;
                cmbBirimara.Focus();
            }
            else if (chkDyer.Checked == false)
            {
                cmbBirimara.Enabled = false;
                cmbBirimara.Text = "";
            }
        }

        private void radTcno_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Tc No :";
            txtHizliara.Text = "";
            txtHizliara.Focus();
        }

        private void radSoyad_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Soyad :";
            txtHizliara.Text = "";
            txtHizliara.Focus();
        }

        private void txtHizliara_TextChanged(object sender, EventArgs e)
        {            
            HizliAra();
        }

        private void radAd_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Ad :";
            txtHizliara.Text = "";
            txtHizliara.Focus();
        }

        private void radTel_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Telefon :";
            txtHizliara.Text = "";
            txtHizliara.Focus();
        }

        private void birimTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BirimTanimlamaForm frmBirim = new BirimTanimlamaForm();
            frmBirim.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciislemForm frmKislem = new KullaniciislemForm();
            frmKislem.ShowDialog();
        }

        private void genelListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelRaporForm1 frmRapor1 = new PersonelRaporForm1();
            frmRapor1.ShowDialog();
        }

        private void ayrııntılıListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelRaporForm2 frmRapor2 = new PersonelRaporForm2();
            frmRapor2.ShowDialog();

        }

        private void kullanıcıListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KullaniciGirisForm.KTuru == "Yönetici")
            {
                KullaniciRaporForm frmRapor3 = new KullaniciRaporForm();
                frmRapor3.ShowDialog();
            }
            else
                MessageBox.Show("Bu listeye erişim yetkiniz yok!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
