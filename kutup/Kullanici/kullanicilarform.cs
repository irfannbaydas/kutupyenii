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
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[0].HeaderText = "Kullanıcı ID";
            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[2].HeaderText = "Kullanıcı Soyad";
            dataGridView1.Columns[3].HeaderText = "Kullanıcı TC";
            dataGridView1.Columns[4].HeaderText = "Kullanıcı Telefon";
            dataGridView1.Columns[5].HeaderText = "Kullanıcı Mail";
        }
    }
}
