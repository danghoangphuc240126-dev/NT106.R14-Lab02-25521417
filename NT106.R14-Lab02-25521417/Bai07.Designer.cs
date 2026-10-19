using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace UIT.LAB02.NT106.R14
{
    partial class Bai07
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
            caythumuc = new TreeView();
            groupBox1 = new GroupBox();
            khunganh = new PictureBox();
            khungchu = new RichTextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)khunganh).BeginInit();
            SuspendLayout();
            // 
            // caythumuc
            // 
            caythumuc.Location = new Point(12, 12);
            caythumuc.Name = "caythumuc";
            caythumuc.Size = new Size(273, 552);
            caythumuc.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(khungchu);
            groupBox1.Controls.Add(khunganh);
            groupBox1.Location = new Point(314, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(758, 561);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "File Content";
            // 
            // khunganh
            // 
            khunganh.Location = new Point(6, 26);
            khunganh.Name = "khunganh";
            khunganh.Size = new Size(746, 529);
            khunganh.SizeMode = PictureBoxSizeMode.StretchImage;
            khunganh.TabIndex = 0;
            khunganh.TabStop = false;
            // 
            // khungchu
            // 
            khungchu.Location = new Point(6, 26);
            khungchu.Name = "khungchu";
            khungchu.Size = new Size(746, 529);
            khungchu.TabIndex = 1;
            khungchu.Text = "";
            // 
            // Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 576);
            Controls.Add(groupBox1);
            Controls.Add(caythumuc);
            Name = "Bai07";
            Text = "Bai07";

            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)khunganh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView caythumuc;
        private GroupBox groupBox1;
        private RichTextBox khungchu;
        private PictureBox khunganh;
    }
}