using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace UIT.LAB02.NT106.R14
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        public class phim
        {
            public string ten { get; set; }
            public int gia { get; set; }
            public int phong { get; set; }
            public int veban { get; set; }
            public int tongve { get; set; }
            public long doanhthu { get; set; }
            public float tyle { get; set; }
        }

        List<phim> danhsach = new List<phim>() { };

        private void nhapten_TextChanged(object sender, EventArgs e) { }

        private void nhapgia_TextChanged(object sender, EventArgs e) { }

        private void nhapphong_TextChanged(object sender, EventArgs e) { }

        private void nhapban_TextChanged(object sender, EventArgs e) { }

        private void nhaptong_TextChanged(object sender, EventArgs e) { }

        private void nutthem_Click_1(object sender, EventArgs e)
        {
            string[] duLieu = { nhapten.Text, nhapgia.Text, nhapphong.Text, nhapban.Text, nhaptong.Text };
            File.AppendAllLines("input5.txt", duLieu);

            nhapten.Text = "";
            nhapgia.Text = "";
            nhapphong.Text = "";
            nhapban.Text = "";
            nhaptong.Text = "";
        }

        private void nutthongke_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists("input5.txt")) return;

            // Đã thêm bước lọc các dòng rỗng
            string[] doc = File.ReadAllLines("input5.txt").Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
            danhsach.Clear();

            int i = 0;
            while (i <= doc.Length - 5)
            {
                try
                {
                    phim p = new phim();
                    p.ten = doc[i];
                    p.gia = Convert.ToInt32(doc[i + 1].Trim());
                    p.phong = Convert.ToInt32(doc[i + 2].Trim());
                    p.veban = Convert.ToInt32(doc[i + 3].Trim());
                    p.tongve = Convert.ToInt32(doc[i + 4].Trim());
                    p.doanhthu = (long)p.gia * p.veban;
                    p.tyle = ((float)p.veban / p.tongve) * 100f;

                    danhsach.Add(p);
                }
                catch
                {
                    // Bỏ qua các block dữ liệu không đúng định dạng
                }
                i += 5;
            }

            danhsach.Sort((a, b) => b.doanhthu.CompareTo(a.doanhthu));

            ProgressBar pb = this.Controls.Find("thanhchay", true).FirstOrDefault() as ProgressBar;
            if (pb != null)
            {
                pb.Minimum = 0;
                pb.Maximum = danhsach.Count;
                pb.Value = 0;
            }

            StringBuilder kq = new StringBuilder();
            int hang = 1;

            foreach (var item in danhsach)
            {
                int ton = item.tongve - item.veban;
                kq.AppendLine("ten phim: " + item.ten);
                kq.AppendLine("ve ban ra: " + item.veban);
                kq.AppendLine("ve ton: " + ton);
                kq.AppendLine("ty le ban: " + item.tyle + "%");
                kq.AppendLine("doanh thu: " + item.doanhthu);
                kq.AppendLine("xep hang: " + hang);
                kq.AppendLine();

                if (pb != null)
                {
                    pb.Value = hang;
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(150);
                }
                hang++;
            }

            khungxuat.Text = kq.ToString();
            File.WriteAllText("output5.txt", kq.ToString());
        }

        private void khungxuat_TextChanged(object sender, EventArgs e) { }
    }
}