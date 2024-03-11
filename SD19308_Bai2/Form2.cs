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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string tuoi = txtTuoi.Text;
            int stt = listView1.Items.Count + 1;

            ListViewItem item = new ListViewItem(stt.ToString());
            item.SubItems.Add(ten);
            item.SubItems.Add(tuoi);

            listView1.Items.Add(item);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //listView1.Columns.Add("STT");
            //listView1.Columns.Add("Ten");
            //listView1.Columns.Add("Tuoi");
            int count = 0;
            foreach (var item in imageList1.Images)
            {
                count++;
                comboBox1.Items.Add("Anh " + count);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[comboBox1.SelectedIndex];
        }
    }
}
