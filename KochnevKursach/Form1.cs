using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KochnevKursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String first = textBox1.Text;
            String second = textBox2.Text;
            String third = textBox3.Text;

            Form2 frm = new Form2();
            this.Hide();
            frm.first = first;
            frm.second = second;
            frm.third = third;
            frm.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
