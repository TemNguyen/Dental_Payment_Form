using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalPaymentForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        int TinhTien()
        {
            int Total = 0;
            if (cbCaoVoi.Checked) Total += 100000;
            if (cbTayTrang.Checked) Total += 1200000;
            if (cbTaoHinhRang.Checked) Total += 20000;
            Total += Convert.ToInt32(numericUpDown1.Value) * 80000;
            return Total;
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Vui long nhap ten KH!!");
                return;
            }
            tbTotal.Text = "$" + TinhTien().ToString();
        }
    }
}
