using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutup
{
    public partial class kullanicilarform : Form
    {
        public kullanicilarform()
        {
            InitializeComponent();
        }

        kutupEntities db = new kutupEntities();
        public void Listele()
        {
           
            var kullanicilar = db.kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        private void kullanicilarform_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
