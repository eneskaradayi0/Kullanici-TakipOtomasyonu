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
    public partial class BirimTanimlamaForm : Form
    {
        public BirimTanimlamaForm()
        {
            InitializeComponent();
        }

        public void BirimListele()
        {
            try
            {
                Form1.BaglantiAc();
                DataSet ds = new DataSet();
                string Sorgu = "Select * from Birimler";
                SqlDataAdapter da = new SqlDataAdapter(Sorgu,Form1.Baglanti);
                da.Fill(ds, "Birimler");
                dataGridView1.DataSource = ds.Tables["Birimler"];
                Form1.Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Birim Listele Hata Penceresi");

            }
        }

        public void BirimDegistir()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Update Birimler Set BirimAdi=@BirimAdi where BirimKodu=@BirimKodu";
                SqlCommand DegistirKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@BirimAdi", txtBirimadi.Text);                
                DegistirKomut.Parameters.AddWithValue("@BirimKodu", txtBirimkodu.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtBirimkodu.Text + " Nolu Kayıt Değiştirildi");
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Birim Değiştir Hata Penceresi");
            }

        }


        public void BirimEkle()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Insert Into Birimler (BirimAdi) Values (@BirimAdi)";
                SqlCommand EkleKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                EkleKomut.Parameters.AddWithValue("@BirimAdi", txtBirimadi.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Birim Ekle Hata Penceresi");
            }
        }

        public void BirimSil()
        {
            try
            {
                Form1.BaglantiAc();
                string Sorgu = "Delete from Birimler where BirimKodu=" + txtBirimkodu.Text;
                SqlCommand SilKomut = new SqlCommand(Sorgu, Form1.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Silindi");
                Form1.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Birim Sil Hata Penceresi");
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBirimkodu.Text != "")
                MessageBox.Show("Kayıt Eklemeden Önce\nTemizle Butonuna Basınız!", "Dikkat");
            else if(txtBirimadi.Text=="")
                MessageBox.Show("Birim adını giriniz", "Dikkat");
            else
                BirimEkle();
        }

        private void BirimTanimlamaForm_Load(object sender, EventArgs e)
        {
            BirimListele();
        }

        private void BirimTanimlamaForm_Activated(object sender, EventArgs e)
        {
            Form1.Baglanti.Close();
            BirimListele();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {   if (dataGridView1.SelectedRows.Count > 0)
            {
                txtBirimkodu.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtBirimadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtBirimadi.Text == "")
                MessageBox.Show("Birim adını giriniz", "Dikkat");
            else
                BirimDegistir();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtBirimkodu.Text = "";
            txtBirimadi.Text = "";
            txtBirimadi.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtBirimkodu.Text == "")
                MessageBox.Show("Silinecek kayıtı seçiniz");
            else
                BirimSil();
            
        }
    }
}
