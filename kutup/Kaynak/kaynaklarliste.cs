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
    public partial class kaynaklarliste : Form
    {
        public kaynaklarliste()
        {
            InitializeComponent();
        }
        kutupEntities db = new kutupEntities(); 

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kaynaklarliste_Load(object sender, EventArgs e)
        {
            var  Kaynaklar = db.kaynaklar.ToList();
            dataGridView1.DataSource = Kaynaklar.ToList();
        }
    }
}
