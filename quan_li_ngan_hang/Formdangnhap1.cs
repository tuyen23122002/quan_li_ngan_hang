using System;
using System.Data;
using System.Windows.Forms;

namespace quan_li_ngan_hang
{
    public partial class Formdangnhap1 : System.Windows.Forms.Form
    {
        ConnectionSQL con = new ConnectionSQL();
        public Formdangnhap1()
        {
            InitializeComponent();
        }

        private void Formdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt = con.GetData("select * from dangnhap where tendangnhap='" + txttendangnhap.Text + "' and matkhau ='" + txtmatkhau.Text + "'");
            if (dt.Rows.Count > 0)
            {
               
                Formchuongtrinh b = new Formchuongtrinh(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                b.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dang nhap bị lỗi !", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); ;
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn muốn thoát hay không ?", "Thông báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                Application.Exit();
            }
        }


    }
}

