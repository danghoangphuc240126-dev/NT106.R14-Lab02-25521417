using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.R14_Lab02_25521417
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void file_name_txt(object sender, EventArgs e) { }
        private void size_txt(object sender, EventArgs e) { }
        private void url_txt(object sender, EventArgs e) { }
        private void line_count_txt(object sender, EventArgs e) { }
        private void words_count_txt(object sender, EventArgs e) { }
        private void character_count_txt(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        private void read_from_file_butt(object sender, EventArgs e)
        {
         
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string content = sr.ReadToEnd();
                        richTextBox1.Text = content;

                        textBox1.Text = ofd.SafeFileName.ToString();

                        textBox2.Text = fs.Length.ToString() + " bytes";

                        textBox3.Text = fs.Name.ToString();

                        string[] lines = content.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                        textBox4.Text = lines.Length.ToString();

                        string[] words = content.Split(new char[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        textBox5.Text = words.Length.ToString();

                        textBox6.Text = content.Length.ToString();
                    }
                }
            }
        }

        private void exit_butt(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bai02_Load(object sender, EventArgs e)
        {

        }
    }
}