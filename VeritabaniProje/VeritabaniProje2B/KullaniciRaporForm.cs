using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabaniProje2B
{
    public partial class KullaniciRaporForm : Form
    {
        public KullaniciRaporForm()
        {
            InitializeComponent();
        }

        private void KullaniciRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vt2BDataSet.Kullanicilar' table. You can move, or remove it, as needed.
            this.KullanicilarTableAdapter.Fill(this.vt2BDataSet.Kullanicilar);

            this.reportViewer1.RefreshReport();
        }
    }
}
