using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutup.Kayit
{
    public partial class gerial : Form
    {
        public gerial()
        {
            InitializeComponent();
        }
        kutupEntities db = new kutupEntities();
        private void gerial_Load(object sender, EventArgs e)
        {
            var kayitlar = db.kayitlar.Where(x=>x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();


            
            dataGridView1.Columns[0].HeaderText = "Kayıt ID";
            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[2].HeaderText = "Kitap ID";
            dataGridView1.Columns[3].HeaderText = "Alış Tarihi";
            dataGridView1.Columns[4].HeaderText = "Son Tarih";
            dataGridView1.Columns[5].HeaderText = "Durum";

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKayitId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = db.kayitlar.Where(x=>x.kayit_id == secilenKayitId).FirstOrDefault();
            kayit.durum = true;
            db.SaveChanges();
            var kayitlar = db.kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();
            
        }
    }
}
