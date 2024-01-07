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
    public partial class Formtinhtienlai : Form
    {
        public Formtinhtienlai()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntinhsotienlai_Click(object sender, EventArgs e)
        {
            double soTienGui = double.Parse(txtsotien.Text);
            double laiSuat = double.Parse(txtlaisuat.Text);
            DateTime ngayGui = dateTimengaygui.Value;
            DateTime ngayRut = dateTimengayrut.Value;

            // Tính số ngày gửi tiền và số tiền lãi
            int soNgayGui = (ngayRut - ngayGui).Days;
            double lai = (soTienGui * laiSuat * soNgayGui) / (365 * 100);

            // Hiển thị kết quả
           txtTienLai.Text = lai.ToString();
        }

        private void Formtinhtienlai_Load(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Formchuongtrinh frm10 = new Formchuongtrinh();
            frm10.Show();
            this.Hide();
        }
    }
}
