using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.R14_Lab02_25521417
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai01 formBai1 = new Bai01();
            formBai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02 formBai2 = new Bai02();
            formBai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03 formBai3 = new Bai03();
            formBai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai04 formBai4 = new Bai04();
            formBai4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UIT.LAB02.NT106.R14.Bai05 formBai5 = new UIT.LAB02.NT106.R14.Bai05();
            formBai5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UIT.LAB02.NT106.R14.Bai06 formBai6 = new UIT.LAB02.NT106.R14.Bai06();
            formBai6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UIT.LAB02.NT106.R14.Bai07 formBai7 = new UIT.LAB02.NT106.R14.Bai07();
            formBai7.Show();
        }
    }
}
