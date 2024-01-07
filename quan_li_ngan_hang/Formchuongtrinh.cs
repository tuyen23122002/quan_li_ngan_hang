using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_li_ngan_hang
{
    public partial class Formchuongtrinh : System.Windows.Forms.Form
    {
        string tendangnhap = "", manhanvien = "", matkhau = "", quyen = "";

        public Formchuongtrinh()
        {
            InitializeComponent();
        }
        public Formchuongtrinh(string tendangnhap, string manhanvien, string matkhau, string quyen)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.manhanvien = manhanvien;
            this.matkhau = matkhau;
            this.quyen = quyen;
        }
        private void sổTiếtKiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formsotietkiem frm0 = new Formsotietkiem();
            frm0.Show();
            this.Hide();
        }

        private void sổVayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSovay frm1 = new FormSovay();
            frm1.Show();
            this.Hide();
        }

        private void tàiKhoảnNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formnhanvien frm3 = new Formnhanvien();
            frm3.Show();
            this.Hide();
        }

        private void tàiKhoảnKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Formtaikhoankh frm9 = new Formtaikhoankh();
            frm9.Show();
            this.Hide();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thiếtLậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Formchuongtrinh_Load(object sender, EventArgs e)
        {

        }

        private void tínhTiềnLãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formtinhtienlai frm7 = new Formtinhtienlai();
            frm7.Show();
            this.Hide();
        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thôngKêSổTiếtKiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formdoimatkhau1 frm10 = new Formdoimatkhau1();
            frm10.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn muốn thoát hay không ?", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                Formdangnhap1 frm9 = new Formdangnhap1();
                frm9.Show();
                this.Hide();
            }
        }

      /*  private void Formchuongtrinh_Load(object sender, EventArgs e)
        {
           
        }
      */
        private void giaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
         /* if (quyen == "nhân viên")
           {
                MessageBox.Show("Ban khong co quyen dang nhap ", "Thong bao");
           }*/
        }
    }
}
