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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }
        kutupEntities db = new kutupEntities();
        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            kuleklebtn.Visible = false;
            Kullaniciguncellebtn.Visible = false;
            Kullanicisilbtn.Visible = false;

            kaynakeklebtn.Visible = false;
            kaynaksilbtn.Visible = false;
            kaynakguncellebtn.Visible = false;
            
        }

        private void Kullaniciislembtn_Click(object sender, EventArgs e)
        {
            if (kuleklebtn.Visible == false)
            {
                kuleklebtn.Visible = true;
                Kullaniciguncellebtn.Visible = true;
                Kullanicisilbtn.Visible = true;
            }

            else
            {
                kuleklebtn.Visible = false;
                Kullaniciguncellebtn.Visible = false;
                Kullanicisilbtn.Visible = false;
            }
            kullanicilarform klisteform = new kullanicilarform();
            klisteform.MdiParent = this;
            klisteform.Show();
        }

        private void kuleklebtn_Click(object sender, EventArgs e)
        {
            kullaniciekleform ekleform = new kullaniciekleform();
            ekleform.MdiParent = this;
            ekleform.Show();
        }

        private void Kullanicisilbtn_Click(object sender, EventArgs e)
        {
            kulsilform ksil = new kulsilform();
            ksil.MdiParent = this;
            ksil.Show();
        }

        private void kuleklebtn_Click_1(object sender, EventArgs e)
        {

            kullaniciekleform ekleform = new kullaniciekleform();
            ekleform.MdiParent = this;
            ekleform.Show();
        }

        private void Kullanicisilbtn_Click_1(object sender, EventArgs e)
        {
            kulsilform ksil = new kulsilform();
            ksil.MdiParent = this;
            ksil.Show();
        }

        private void Kullaniciguncellebtn_Click(object sender, EventArgs e)
        {
            Kullaniciguncelle kguncel = new Kullaniciguncelle();
            kguncel.MdiParent = this;
            kguncel.Show();
        }

        private void kaynaklarbtn_Click(object sender, EventArgs e)
        {
            if (kaynakeklebtn.Visible == false)
            {
                kaynakeklebtn.Visible = true;
                kaynaksilbtn.Visible = true;
                kaynakguncellebtn.Visible = true;
            }

            else
            {
                kaynakeklebtn.Visible = false;
                kaynaksilbtn.Visible = false;
                kaynakguncellebtn.Visible = false;
                
            }
           
            kaynakliste kliste = new kaynakliste();
            kliste.MdiParent = this;
            kliste.Show();
        }
    }
}
