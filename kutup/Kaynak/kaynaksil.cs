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
    public partial class kaynaksil : Form
    {
        public kaynaksil()
        {
            InitializeComponent();
        }
        kutupEntities db = new kutupEntities();
        private void kaynaksil_Load(object sender, EventArgs e)
        {
            var kaynaklar = db.kaynaklar.ToList();
            dataGridView2.DataSource = kaynaklar.ToList();
            dataGridView2.Columns[6].Visible = false;

            dataGridView2.Columns[0].HeaderText = "Kaynak ID";
            dataGridView2.Columns[1].HeaderText = "Kaynak Adı";
            dataGridView2.Columns[2].HeaderText = "Kaynak Yazar";
            dataGridView2.Columns[3].HeaderText = "Kaynak Yayıncı";
            dataGridView2.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridView2.Columns[5].HeaderText = "Basım Tarihi";
        }

        private void kaynaksilbtn_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var silinenKaynak = db.kaynaklar.Where(x=>x.kaynak_id == secilenId).FirstOrDefault();
            db.kaynaklar.Remove(silinenKaynak);
            db.SaveChanges();

            var kaynaklar = db.kaynaklar.ToList();
            dataGridView2.DataSource = kaynaklar.ToList();
        }
    }
}
