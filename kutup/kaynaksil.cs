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
