using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quan_li_ngan_hang
{
    public partial class Formdoimatkhau1 : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-J7IC1MF0\SQLEXPRESS;Initial Catalog=Quan_li_ngan_hang_new;Integrated Security=True");
        public Formdoimatkhau1()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
             SqlDataAdapter da = new SqlDataAdapter("select  count (*) from dangnhap where tendangnhap = '" + txttendangnhap.Text + "' and matkhau='" + txtmatkhaucu.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() =="1")
            {
                if (txtmatkhaumoi.Text == txtmkmoi.Text)
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("update dangnhap set matkhau ='" + txtmatkhaumoi.Text + "' where tendangnhap ='" + txttendangnhap.Text + "' and matkhau ='" + txtmatkhaucu.Text + "'", cn);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    MessageBox.Show("Doi mat khau thanh cong");
                }
               else
                {
                    errorProvider1.SetError(txtmatkhaumoi, "Ban chua dien mat khau");
                    errorProvider1.SetError(txtmkmoi, "Ban nhap khong dung");
                }
            }
           else
            {
                errorProvider1.SetError(txttendangnhap, "Ten dang nhap khong dung");
                errorProvider1.SetError(txtmatkhaucu, "Mat khau khong dung");
            
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            Formdangnhap1 frm6 = new Formdangnhap1();
            frm6.Show();
            this.Hide();
        }

        private void Formdoimatkhau1_Load(object sender, EventArgs e)
        {

        }
    }
}


