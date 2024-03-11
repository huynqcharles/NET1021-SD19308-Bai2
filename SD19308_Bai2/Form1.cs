using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD19308_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (listBox1.GetItemText(listBox1.SelectedItem) == "A")
            {
                MessageBox.Show("Dung");
            }
            else
            {
                MessageBox.Show("Sai");
            }
        }

        private void btnDoiMau_Click(object sender, EventArgs e)
        {
            if (cbbMauSac.Text == "")
            {
                MessageBox.Show("Hay chon mot mau!");
            }
            if (cbbMauSac.Text == "Do")
            {
                label1.ForeColor = Color.Red;
            }
            if (cbbMauSac.Text == "Vang")
            {
                label1.ForeColor = Color.Yellow;
            }
            if (cbbMauSac.Text == "Den")
            {
                label1.ForeColor = Color.Black;
            }
            if (cbbMauSac.Text == "Xanh")
            {
                label1.ForeColor = Color.Blue;
            }
        }
    }
}
