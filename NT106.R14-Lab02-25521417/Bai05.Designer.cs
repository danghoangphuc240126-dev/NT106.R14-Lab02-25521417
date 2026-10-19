using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace UIT.LAB02.NT106.R14
{
    partial class Bai05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nhapten = new System.Windows.Forms.TextBox();
            this.nhapgia = new System.Windows.Forms.TextBox();
            this.nhapphong = new System.Windows.Forms.TextBox();
            this.nhapban = new System.Windows.Forms.TextBox();
            this.nhaptong = new System.Windows.Forms.TextBox();
            this.nutthem = new System.Windows.Forms.Button();
            this.nutthongke = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.khungxuat = new System.Windows.Forms.RichTextBox();
            this.thanhchay = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN PHIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NHẬP THÔNG TIN PHIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "GIÁ VÉ CHUẨN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "PHÒNG CHIẾU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "VÉ BÁN RA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "TỔNG SỐ VÉ";
            // 
            // nhapten
            // 
            this.nhapten.Location = new System.Drawing.Point(169, 82);
            this.nhapten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhapten.Name = "nhapten";
            this.nhapten.Size = new System.Drawing.Size(256, 22);
            this.nhapten.TabIndex = 6;
            this.nhapten.TextChanged += new System.EventHandler(this.nhapten_TextChanged);
            // 
            // nhapgia
            // 
            this.nhapgia.Location = new System.Drawing.Point(169, 133);
            this.nhapgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhapgia.Name = "nhapgia";
            this.nhapgia.Size = new System.Drawing.Size(256, 22);
            this.nhapgia.TabIndex = 7;
            this.nhapgia.TextChanged += new System.EventHandler(this.nhapgia_TextChanged);
            // 
            // nhapphong
            // 
            this.nhapphong.Location = new System.Drawing.Point(169, 182);
            this.nhapphong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhapphong.Name = "nhapphong";
            this.nhapphong.Size = new System.Drawing.Size(256, 22);
            this.nhapphong.TabIndex = 8;
            this.nhapphong.TextChanged += new System.EventHandler(this.nhapphong_TextChanged);
            // 
            // nhapban
            // 
            this.nhapban.Location = new System.Drawing.Point(169, 233);
            this.nhapban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhapban.Name = "nhapban";
            this.nhapban.Size = new System.Drawing.Size(256, 22);
            this.nhapban.TabIndex = 9;
            this.nhapban.TextChanged += new System.EventHandler(this.nhapban_TextChanged);
            // 
            // nhaptong
            // 
            this.nhaptong.Location = new System.Drawing.Point(169, 289);
            this.nhaptong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nhaptong.Name = "nhaptong";
            this.nhaptong.Size = new System.Drawing.Size(256, 22);
            this.nhaptong.TabIndex = 10;
            this.nhaptong.TextChanged += new System.EventHandler(this.nhaptong_TextChanged);
            // 
            // nutthem
            // 
            this.nutthem.Location = new System.Drawing.Point(32, 338);
            this.nutthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nutthem.Name = "nutthem";
            this.nutthem.Size = new System.Drawing.Size(393, 52);
            this.nutthem.TabIndex = 11;
            this.nutthem.Text = "THÊM PHIM";
            this.nutthem.UseVisualStyleBackColor = true;
            this.nutthem.Click += new System.EventHandler(this.nutthem_Click_1);
            // 
            // nutthongke
            // 
            this.nutthongke.Location = new System.Drawing.Point(599, 10);
            this.nutthongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nutthongke.Name = "nutthongke";
            this.nutthongke.Size = new System.Drawing.Size(466, 52);
            this.nutthongke.TabIndex = 12;
            this.nutthongke.Text = "THỰC HIỆN THỐNG KÊ";
            this.nutthongke.UseCompatibleTextRendering = true;
            this.nutthongke.UseVisualStyleBackColor = true;
            this.nutthongke.Click += new System.EventHandler(this.nutthongke_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(599, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "THỐNG KẾ DOANH THU VÀ XẾP HẠNG";
            // 
            // khungxuat
            // 
            this.khungxuat.Location = new System.Drawing.Point(599, 110);
            this.khungxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.khungxuat.Name = "khungxuat";
            this.khungxuat.Size = new System.Drawing.Size(466, 254);
            this.khungxuat.TabIndex = 14;
            this.khungxuat.Text = "";
            this.khungxuat.TextChanged += new System.EventHandler(this.khungxuat_TextChanged);
            // 
            // thanhchay
            // 
            this.thanhchay.Location = new System.Drawing.Point(599, 381);
            this.thanhchay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thanhchay.Name = "thanhchay";
            this.thanhchay.Size = new System.Drawing.Size(466, 23);
            this.thanhchay.TabIndex = 15;
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 414);
            this.Controls.Add(this.thanhchay);
            this.Controls.Add(this.khungxuat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nutthongke);
            this.Controls.Add(this.nutthem);
            this.Controls.Add(this.nhaptong);
            this.Controls.Add(this.nhapban);
            this.Controls.Add(this.nhapphong);
            this.Controls.Add(this.nhapgia);
            this.Controls.Add(this.nhapten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bai05";
            this.Text = "Bai05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox nhapten;
        private TextBox nhapgia;
        private TextBox nhapphong;
        private TextBox nhapban;
        private TextBox nhaptong;
        private Button nutthem;
        private Button nutthongke;
        private Label label7;
        private RichTextBox khungxuat;
        private ProgressBar thanhchay;
    }
}