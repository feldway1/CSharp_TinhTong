using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TinhTong
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtSo1.Text);
            so2 = Convert.ToDouble(txtSo2.Text);
            ketqua = so1 + so2;
            txtketqua.Text = ketqua.ToString();
            lblketqua.Text = ketqua.ToString();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
