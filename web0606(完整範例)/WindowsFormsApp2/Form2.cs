using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p2 = new Form3();
            p2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var p3 = new Form4();
            p3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var p4 = new Form5();
            p4.Show();
        }
    }
}
