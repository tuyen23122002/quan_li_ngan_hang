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
    public partial class Formtaikhoankh : System.Windows.Forms.Form
    {
        public Formtaikhoankh()
        {
            InitializeComponent();
        }

        private void Formtaikhoankh_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Formchuongtrinh frm11 = new Formchuongtrinh();
            frm11.Show();
            this.Hide();
        }
    }
}
