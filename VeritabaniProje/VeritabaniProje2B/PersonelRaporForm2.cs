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
    public partial class PersonelRaporForm2 : Form
    {
        public PersonelRaporForm2()
        {
            InitializeComponent();
        }

        private void PersonelRaporForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vt2BDataSet.Personel' table. You can move, or remove it, as needed.
            this.PersonelTableAdapter.Fill(this.vt2BDataSet.Personel);

            this.reportViewer1.RefreshReport();
        }
    }
}
