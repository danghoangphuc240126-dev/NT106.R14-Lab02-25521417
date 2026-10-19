using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace UIT.LAB02.NT106.R14
{
    partial class Bai06
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nhapidncc = new TextBox();
            nhaphoten = new TextBox();
            nhapquyen = new TextBox();
            nutthemnguoi = new Button();
            nutthemmon = new Button();
            nhaphinhanh = new TextBox();
            nhaptenmon = new TextBox();
            nhapidma = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            nhapidnccmon = new TextBox();
            label10 = new Label();
            label11 = new Label();
            nutchonanh = new Button();
            nuttai = new Button();
            danhsachmon = new ListView();
            nutngau = new Button();
            khungketqua = new RichTextBox();
            khunganh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)khunganh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "NHẬP DỮ LIỆU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 106);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "ID NCC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 165);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "HỌ VÀ TÊN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 224);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 3;
            label4.Text = "QUYỀN HẠN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 59);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 4;
            label5.Text = "THÊM NGƯỜI DÙNG";
            // 
            // nhapidncc
            // 
            nhapidncc.Location = new Point(173, 103);
            nhapidncc.Name = "nhapidncc";
            nhapidncc.Size = new Size(199, 27);
            nhapidncc.TabIndex = 5;
            // 
            // nhaphoten
            // 
            nhaphoten.Location = new Point(173, 162);
            nhaphoten.Name = "nhaphoten";
            nhaphoten.Size = new Size(199, 27);
            nhaphoten.TabIndex = 6;
            // 
            // nhapquyen
            // 
            nhapquyen.Location = new Point(173, 221);
            nhapquyen.Name = "nhapquyen";
            nhapquyen.Size = new Size(199, 27);
            nhapquyen.TabIndex = 7;
            // 
            // nutthemnguoi
            // 
            nutthemnguoi.Location = new Point(21, 283);
            nutthemnguoi.Name = "nutthemnguoi";
            nutthemnguoi.Size = new Size(351, 52);
            nutthemnguoi.TabIndex = 8;
            nutthemnguoi.Text = "THÊM NGƯỜI DÙNG";
            nutthemnguoi.UseVisualStyleBackColor = true;
            nutthemnguoi.Click += nutthemnguoi_Click;
            // 
            // nutthemmon
            // 
            nutthemmon.Location = new Point(21, 643);
            nutthemmon.Name = "nutthemmon";
            nutthemmon.Size = new Size(351, 52);
            nutthemmon.TabIndex = 16;
            nutthemmon.Text = "THÊM MÓN ĂN";
            nutthemmon.UseVisualStyleBackColor = true;
            nutthemmon.Click += nutthemmon_Click;
            // 
            // nhaphinhanh
            // 
            nhaphinhanh.Location = new Point(173, 523);
            nhaphinhanh.Name = "nhaphinhanh";
            nhaphinhanh.Size = new Size(159, 27);
            nhaphinhanh.TabIndex = 15;
            // 
            // nhaptenmon
            // 
            nhaptenmon.Location = new Point(173, 464);
            nhaptenmon.Name = "nhaptenmon";
            nhaptenmon.Size = new Size(199, 27);
            nhaptenmon.TabIndex = 14;
            // 
            // nhapidma
            // 
            nhapidma.Location = new Point(173, 405);
            nhapidma.Name = "nhapidma";
            nhapidma.Size = new Size(199, 27);
            nhapidma.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 365);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 12;
            label6.Text = "THÊM MÓN ĂN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 530);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 11;
            label7.Text = "ĐƯỜNG DẪN ẢNH";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 471);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 10;
            label8.Text = "TÊN MÓN ĂN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 412);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 9;
            label9.Text = "MÃ MÓN (IDMA)";
            // 
            // nhapidnccmon
            // 
            nhapidnccmon.Location = new Point(173, 587);
            nhapidnccmon.Name = "nhapidnccmon";
            nhapidnccmon.Size = new Size(199, 27);
            nhapidnccmon.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 594);
            label10.Name = "label10";
            label10.Size = new Size(145, 40);
            label10.TabIndex = 17;
            label10.Text = "MÃ NCC ĐÓNG GÓP\r\n(IDNCC)\r\n";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(496, 59);
            label11.Name = "label11";
            label11.Size = new Size(158, 20);
            label11.TabIndex = 19;
            label11.Text = "DANH SÁCH MÓN ĂN";
            // 
            // nutchonanh
            // 
            nutchonanh.BackColor = SystemColors.ActiveBorder;
            nutchonanh.Location = new Point(338, 523);
            nutchonanh.Name = "nutchonanh";
            nutchonanh.Size = new Size(34, 29);
            nutchonanh.TabIndex = 20;
            nutchonanh.Text = "...";
            nutchonanh.UseVisualStyleBackColor = false;
            nutchonanh.Click += nutchonanh_Click;
            // 
            // nuttai
            // 
            nuttai.Location = new Point(496, 97);
            nuttai.Name = "nuttai";
            nuttai.Size = new Size(400, 60);
            nuttai.TabIndex = 21;
            nuttai.Text = "TẢI VÀ LÀM MỚI DANH SÁCH";
            nuttai.UseVisualStyleBackColor = true;
            nuttai.Click += nuttai_Click;
            // 
            // danhsachmon
            // 
            danhsachmon.Location = new Point(496, 180);
            danhsachmon.Name = "danhsachmon";
            danhsachmon.Size = new Size(400, 515);
            danhsachmon.TabIndex = 22;
            danhsachmon.UseCompatibleStateImageBehavior = false;
            // 
            // nutngau
            // 
            nutngau.Location = new Point(1012, 59);
            nutngau.Name = "nutngau";
            nutngau.Size = new Size(369, 98);
            nutngau.TabIndex = 23;
            nutngau.Text = "CHỌN NGẪU NHIÊN MÓN ĂN";
            nutngau.UseVisualStyleBackColor = true;
            nutngau.Click += nutngau_Click;
            // 
            // khungketqua
            // 
            khungketqua.Location = new Point(1012, 180);
            khungketqua.Name = "khungketqua";
            khungketqua.ReadOnly = true;
            khungketqua.Size = new Size(369, 293);
            khungketqua.TabIndex = 24;
            khungketqua.Text = "";
            // 
            // khunganh
            // 
            khunganh.Location = new Point(1012, 479);
            khunganh.Name = "khunganh";
            khunganh.Size = new Size(369, 216);
            khunganh.SizeMode = PictureBoxSizeMode.StretchImage;
            khunganh.TabIndex = 25;
            khunganh.TabStop = false;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 724);
            Controls.Add(khunganh);
            Controls.Add(khungketqua);
            Controls.Add(nutngau);
            Controls.Add(danhsachmon);
            Controls.Add(nuttai);
            Controls.Add(nutchonanh);
            Controls.Add(label11);
            Controls.Add(nhapidnccmon);
            Controls.Add(label10);
            Controls.Add(nutthemmon);
            Controls.Add(nhaphinhanh);
            Controls.Add(nhaptenmon);
            Controls.Add(nhapidma);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(nutthemnguoi);
            Controls.Add(nhapquyen);
            Controls.Add(nhaphoten);
            Controls.Add(nhapidncc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai06";
            Text = "Bai06";

            ((System.ComponentModel.ISupportInitialize)khunganh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nhapidncc;
        private TextBox nhaphoten;
        private TextBox nhapquyen;
        private Button nutthemnguoi;
        private Button nutthemmon;
        private TextBox nhaphinhanh;
        private TextBox nhaptenmon;
        private TextBox nhapidma;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox nhapidnccmon;
        private Label label10;
        private Label label11;
        private Button nutchonanh;
        private Button nuttai;
        private ListView danhsachmon;
        private Button nutngau;
        private RichTextBox khungketqua;
        private PictureBox khunganh;
    }
}