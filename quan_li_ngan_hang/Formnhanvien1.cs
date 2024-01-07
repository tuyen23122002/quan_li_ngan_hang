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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace quan_li_ngan_hang
{
    public partial class Formnhanvien : System.Windows.Forms.Form
    {

        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        private static SqlConnection mycon;
        private static string sqlconn = @"Data Source=LAPTOP-J7IC1MF0\SQLEXPRESS;Initial Catalog=Quan_li_ngan_hang_new;Integrated Security=True";
        private void hienthi()
        {
            try
            {
                string chuoi = "select *from nhanvien";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datanhanvien.DataSource = dt;
                datanhanvien.Columns[0].HeaderText = "Mã nhân viên ";
                datanhanvien.Columns[1].HeaderText = "Họ và tên  ";
                datanhanvien.Columns[2].HeaderText = "Ngày sinh  ";
                datanhanvien.Columns[3].HeaderText = "Giới tính  ";
                datanhanvien.Columns[4].HeaderText = "Số cmnd ";
                datanhanvien.Columns[5].HeaderText = "Địa chỉ  ";
                datanhanvien.Columns[6].HeaderText = "SDT ";
                datanhanvien.Columns[7].HeaderText = "Email ";
                datanhanvien.Columns[8].HeaderText = "Trình độ học vấn  ";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi that bai " + ex);
            }
        }
        public Formnhanvien()
        {
            InitializeComponent();
        }

        private void Formnhanvien_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Formchuongtrinh frm5 = new Formchuongtrinh();
            frm5.Show();
            this.Hide();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "insert into nhanvien (ma_nhan_vien,hovaten,ngaysinh,gioitinh,socmnd,diachi,sodienthoai,email,trinhdohocvan) values ('" + txtmanhanvien.Text + "',N'" + txthovaten.Text + "','" + datengaysinh.Value.ToShortDateString() + "',N'" +combogioitinh.SelectedItem.ToString() + "','" +txtsocmnd.Text+ "',N'" + txtdiachi.Text+ "','"+txtsodienthoai.Text+"','"+txtemail.Text+"',N'"+combohocvan.SelectedItem.ToString()+"')";
                mycon = new SqlConnection(sqlconn);
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                datanhanvien.DataSource = tb;
                MessageBox.Show("Them thanh cong !", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienthi();
                mycon.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi that bai " + ex);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
                string sql = "delete nhanvien where ma_nhan_vien ='" + txtmanhanvien.Text + "'";
                try
                {
                    mycon = new SqlConnection(sqlconn);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    int kq = com.ExecuteNonQuery();

                    if (kq > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienthi();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối bị lỗi " + ex);
                }
            

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sua = "update nhanvien set hovaten=N'" + txthovaten.Text + "',ngaysinh='" + datengaysinh.Value.ToShortDateString() + "',gioitinh=N'" + combogioitinh.SelectedItem.ToString() + "',socmnd='" + txtsocmnd.Text + "',diachi=N'" + txtdiachi.Text + "',sodienthoai='" + txtsodienthoai.Text + "',email='" + txtemail.Text + "',trinhdohocvan=N'" + combohocvan.SelectedItem.ToString() + "' where ma_nhan_vien='" + txtmanhanvien.Text + "'";
            try
            {
                mycon = new SqlConnection(sqlconn);
                // string sua = "update nhanvien set hovaten=N'" + txthovaten.Text + "',ngaysinh='" + datengaysinh.Value.ToShortDateString() + "',gioitinh=N'" + combogioitinh.SelectedItem.ToString() + "',socmnd='" + txtsocmnd.Text + "',diachi=N'" + txtdiachi.Text + "',sodienthoai='" + txtsodienthoai.Text + "',email='" + txtemail.Text + "',trinhdohocvan=N'" + combohocvan.SelectedItem.ToString() + "' where ma_nhan_vien='" + txtmanhanvien.Text + "'";
                mycon.Open();
                com = new SqlCommand(sua, mycon);
                int kq = com.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công","Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    hienthi();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu để sửa", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại " + ex);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string chuoi = "select * from nhanvien where ma_nhan_vien='" + txttimkiem.Text + "'";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                datanhanvien.DataSource = dt;
                
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Tìm kiếm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại " + ex);
            }
        }

        

       
    }
    

}




