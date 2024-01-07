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
    public partial class FormSovay : System.Windows.Forms.Form
    {
        public FormSovay()
        {
            InitializeComponent();
        }

       

        private void FormSovay_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formchuongtrinh frm10 = new Formchuongtrinh();
            frm10.Show();
            this.Hide();
        }
    }
}
