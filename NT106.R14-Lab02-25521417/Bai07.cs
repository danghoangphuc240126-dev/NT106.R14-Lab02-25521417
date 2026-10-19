using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UIT.LAB02.NT106.R14
{
    public partial class Bai07 : Form
    {
        private readonly string[] dsDuoiAnh = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

        public Bai07()
        {
            InitializeComponent();

            khunganh.Visible = false;
            khungchu.Visible = false;

            caythumuc.BeforeExpand += XuLyTruocKhiMoRong;
            caythumuc.NodeMouseDoubleClick += XuLyClickKep;
            caythumuc.AfterSelect += XuLyChonNode;

            LoadDanhSachODia();
        }

        private void LoadDanhSachODia()
        {
            try
            {
                var danhSachODia = DriveInfo.GetDrives();

                int i = 0;
                while (i < danhSachODia.Length)
                {
                    var drive = danhSachODia[i];
                    if (drive.IsReady)
                    {
                        string tenHienThi = $"{drive.VolumeLabel} ({drive.Name})";
                        var rootNode = new TreeNode(tenHienThi)
                        {
                            Tag = drive.Name
                        };

                        rootNode.Nodes.Add("*DUMMY*");
                        caythumuc.Nodes.Add(rootNode);
                    }
                    i++;
                }
            }
            catch { }
        }

        private void TaiDuLieuVaoNode(TreeNode nodeHienTai)
        {
            if (nodeHienTai.Nodes.Count > 0 && nodeHienTai.Nodes[0].Text == "*DUMMY*")
            {
                nodeHienTai.Nodes.Clear();
                string path = nodeHienTai.Tag as string;
                if (string.IsNullOrEmpty(path)) return;

                try
                {
                    var thuMucList = Directory.GetDirectories(path);

                    for (int j = 0; j < thuMucList.Length; j++)
                    {
                        string thuMuc = thuMucList[j];
                        DirectoryInfo dirInfo = new DirectoryInfo(thuMuc);
                        TreeNode nodeCon = new TreeNode(dirInfo.Name)
                        {
                            Tag = thuMuc
                        };
                        nodeCon.Nodes.Add("*DUMMY*");
                        nodeHienTai.Nodes.Add(nodeCon);
                    }

                    var tapTinList = Directory.GetFiles(path);
                    foreach (var tapTin in tapTinList)
                    {
                        FileInfo fileInfo = new FileInfo(tapTin);
                        TreeNode nodeFile = new TreeNode(fileInfo.Name)
                        {
                            Tag = tapTin
                        };
                        nodeHienTai.Nodes.Add(nodeFile);
                    }
                }
                catch (UnauthorizedAccessException) { }
                catch (Exception) { }
            }
        }

        private void XuLyTruocKhiMoRong(object sender, TreeViewCancelEventArgs e)
        {
            TaiDuLieuVaoNode(e.Node);
        }

        private void XuLyClickKep(object sender, TreeNodeMouseClickEventArgs e)
        {
            TaiDuLieuVaoNode(e.Node);
            e.Node.Expand();
        }

        private void XuLyChonNode(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Tag == null) return;

                string fullPath = e.Node.Tag.ToString();
                if (!File.Exists(fullPath)) return;

                string extension = Path.GetExtension(fullPath).ToLowerInvariant();

                if (dsDuoiAnh.Contains(extension))
                {
                    HienThiHinhAnh(fullPath);
                }
                else
                {
                    HienThiVanBan(fullPath);
                }
            }
            catch { }
        }

        private void HienThiHinhAnh(string filePath)
        {
            try
            {
                khungchu.Visible = false;
                khunganh.Visible = true;

                using (var ms = new MemoryStream(File.ReadAllBytes(filePath)))
                {
                    khunganh.Image = Image.FromStream(ms);
                }
            }
            catch { }
        }

        private void HienThiVanBan(string filePath)
        {
            try
            {
                khunganh.Visible = false;
                khungchu.Visible = true;
                khungchu.Text = File.ReadAllText(filePath);
            }
            catch { }
        }
    }
}