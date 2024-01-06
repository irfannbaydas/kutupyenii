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
    public partial class kulsilform : Form
    {
        public kulsilform()
        {
            InitializeComponent();
        }
        kutupEntities db = new kutupEntities();

        public void Listele()
        {
            var kulveri = db.kullanicilar.ToList();
            dataGridView1.DataSource = kulveri.ToList();

        }
        private void kulsilform_Load(object sender, EventArgs e)
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

        private void silbut_Click(object sender, EventArgs e)
        {
            int secilenid = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.kullanicilar.Where(x => x.kullanici_id == secilenid).FirstOrDefault();
            db.kullanicilar.Remove(kullanici);
            db.SaveChanges();
            Listele();
        }
    }
}
