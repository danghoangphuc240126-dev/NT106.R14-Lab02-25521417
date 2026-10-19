using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NT106.R14_Lab02_25521417
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

      
        private void btnRead(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Chọn file input1.txt";
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FileName = "input1.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate, FileAccess.Read))
                    using (StreamReader sr = new StreamReader(fs))
                    {
                    
                        richTextBox1.Text = sr.ReadToEnd();
                    }
                    MessageBox.Show("Đọc file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void btnWrite(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrEmpty(richTextBox1.Text))
                {
                    MessageBox.Show("Chưa có nội dung để ghi! Vui lòng đọc file trước.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Lưu file output1.txt";
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FileName = "output1.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                     
                        sw.Write(richTextBox1.Text.ToUpper());
                    }
                    MessageBox.Show("Ghi file in hoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void rtbContent(object sender, EventArgs e)
        {

        }
    }
}