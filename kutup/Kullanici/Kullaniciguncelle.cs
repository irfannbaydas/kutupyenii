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
    public partial class Kullaniciguncelle : Form
    {
        public Kullaniciguncelle()
        {
            InitializeComponent();
        }
        kutupEntities db = new kutupEntities();


        public void Listele()
        {

            var kullanicilar = db.kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();

        }


        private void Kullaniciguncelle_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var kullanici = db.kullanicilar.Where(x=>x.kullanici_id == secilenId).FirstOrDefault();
            kullanici.kullanici_ad = kuladtxt.Text;
            kullanici.kullanici_soyad = kulsoyadtxt.Text;
            kullanici.kullanici_tc = kultctxt.Text;
            kullanici.kullanici_tel = kulteltxt.Text;
            kullanici.kullanici_mail = kulmailtxt.Text;

            db.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         kuladtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kulsoyadtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kultctxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kulmailtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kulteltxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

          
        }
    }
}
