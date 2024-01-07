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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace quan_li_ngan_hang
{
    public partial class Formsotietkiem : System.Windows.Forms.Form
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
                string chuoi = "select *from sotietkiem";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                data.DataSource = dt;
                data.Columns[0].HeaderText = "Họ và Tên";
                data.Columns[1].HeaderText = "Mã Số Tài Khoản ";
                data.Columns[2].HeaderText = "Ngày lập sổ ";
                data.Columns[3].HeaderText = "Số Tiền ";
                data.Columns[4].HeaderText = "Kì Hạn ";
                data.Columns[5].HeaderText = "Lãi suất";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi that bai " + ex);
            }
        }
        public Formsotietkiem()
        {
            InitializeComponent();
            hienthi();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {

            try
            {
                string sql1 = "insert into sotietkiem (hovaten,masotaikhoan,ngaylapso,sotien,kihan,laisuat) values (N'" + txthovaten.Text + "','" + txtmasotaikhoan.Text + "','" + datengaylapso.Value.ToShortDateString() + "','" + txtsotien.Text + "','" + cmbkihan.SelectedItem.ToString() + "','" + combolaisuat.SelectedItem.ToString() + "')";
                mycon = new SqlConnection(sqlconn);
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                data.DataSource = tb;
                MessageBox.Show("Them thanh cong !", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienthi();
                mycon.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi that bai " + ex);
            }
        }

        private void Formsotietkiem_Load(object sender, EventArgs e)
        {
            
        }
        private void btnhienthisolai_Click(object sender, EventArgs e)
        {

            try
            {

                // Lấy dòng hiện tại trong data
                int index = data.CurrentCell.RowIndex;
                string masotaikhoan = data.Rows[index].Cells[1].Value.ToString();
                float sotien;
                if (!float.TryParse(data.Rows[index].Cells[3].Value.ToString(), out sotien))
                {
                    MessageBox.Show("Số tiền không hợp lệ");
                    return;
                }

                float laisuat;
                if (!float.TryParse(data.Rows[index].Cells[5].Value.ToString(), out laisuat))
                {
                    MessageBox.Show("Lãi suất không hợp lệ");
                    return;
                }
                 sotien = (float)data.Rows[index].Cells[3].Value;
                string kihan = data.Rows[index].Cells[4].Value.ToString();
                laisuat = (float)data.Rows[index].Cells[5].Value;

                float tienlai = sotien * laisuat * int.Parse(kihan) / 100;
                MessageBox.Show("Số tiền lãi của tài khoản " + masotaikhoan + " là: " + tienlai + " đồng");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
                string sql2 = "update sotietkiem set hovaten=N'" + txthovaten.Text + "',masotaikhoan='" + txtmasotaikhoan.Text + "',ngaylapso='" + datengaylapso.Value.ToShortDateString() + "',sotien='" + txtsotien.Text + "',kihan='" + cmbkihan.SelectedItem.ToString() + "',laisuat='" + combolaisuat.SelectedItem.ToString() + "' where masotaikhoan='" + txtmasotaikhoan.Text + "'";
            try
            {
                mycon = new SqlConnection(sqlconn);
                
                mycon.Open();
                com = new SqlCommand(sql2, mycon);
                int kq = com.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


    






    private void btnxoa_Click(object sender, EventArgs e)
        {

            string sql = "delete sotietkiem where masotaikhoan ='" + txtmasotaikhoan.Text + "'";
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

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string chuoi = "select * from sotietkiem where hovaten like N'%" + txttimkiem.Text + "%' or masotaikhoan like N'%" + txttimkiem.Text + "%'";
                ad = new SqlDataAdapter(chuoi, sqlconn);
                dt = new DataTable();
                ad.Fill(dt);
                data.DataSource = dt;
              
                    if (dt.Rows.Count > 0)
                    {
                    
                    MessageBox.Show("Tim kiém  dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi that bai " + ex);
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txthovaten.Text = "";
            txthovaten.Focus();
            txtmasotaikhoan.Text = "";
            txtsotien.Text = "";
            datengaylapso.Text = DateTime.Now.ToShortDateString();
            combolaisuat.SelectedIndex = 0;
            


        }

       
        private void btnthoat1_Click(object sender, EventArgs e)
        {
            Formchuongtrinh fm6 = new Formchuongtrinh();
            fm6.Show();
            this.Hide();
        }

       private void btnxuatfilepdf_Click(object sender, EventArgs e)
        {
            Document document = new Document();
           
            PdfWriter.GetInstance(document, new FileStream("Output.pdf", FileMode.Create));
           
            document.Open();

           
            PdfPTable table = new PdfPTable(data.ColumnCount);

           
            for (int i = 0; i < data.ColumnCount; i++)
            {
                table.AddCell(new Phrase(data.Columns[i].HeaderText));
            }

          
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    if (data.Rows[i].Cells[j].Value != null)
                    {
                        table.AddCell(new Phrase(data.Rows[i].Cells[j].Value.ToString()));
                    }
                }
            }

            
            document.Add(table);

           
            document.Close();

           
            MessageBox.Show("Xuất file PDF thành công!");
            System.Diagnostics.Process.Start("Output.pdf");
        }
        
    }
}
