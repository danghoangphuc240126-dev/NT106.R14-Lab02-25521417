using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace UIT.LAB02.NT106.R14
{
    public partial class Bai06 : Form
    {
        private readonly string chuoiKetNoiDB = "Data Source=homnayangi.db;Version=3;";

        public Bai06()
        {
            InitializeComponent();
            SetupCotListView();
            KhoiTaoDuLieuDB();
        }

        private void SetupCotListView()
        {
            danhsachmon.View = View.Details;
            danhsachmon.GridLines = true;
            danhsachmon.FullRowSelect = true;

            danhsachmon.Columns.Add("Mã Món", 70);
            danhsachmon.Columns.Add("Tên Món Ăn", 130);
            danhsachmon.Columns.Add("Đường Dẫn Ảnh", 120);
            danhsachmon.Columns.Add("Mã NCC", 70);
        }

        private void KhoiTaoDuLieuDB()
        {
            try
            {
                string dbName = "homnayangi.db";
                if (!File.Exists(dbName))
                {
                    SQLiteConnection.CreateFile(dbName);
                }

                using (var conn = new SQLiteConnection(chuoiKetNoiDB))
                {
                    conn.Open();

                    string taoBangUser = @"CREATE TABLE IF NOT EXISTS NguoiDung (
                                            IDNCC TEXT PRIMARY KEY, 
                                            HoVaTen TEXT, 
                                            QuyenHan TEXT)";

                    string taoBangMon = @"CREATE TABLE IF NOT EXISTS MonAn (
                                            IDMA TEXT PRIMARY KEY, 
                                            TenMonAn TEXT, 
                                            HinhAnh TEXT, 
                                            IDNCC TEXT)";

                    using (var cmd1 = new SQLiteCommand(taoBangUser, conn))
                    {
                        cmd1.ExecuteNonQuery();
                    }

                    using (var cmd2 = new SQLiteCommand(taoBangMon, conn))
                    {
                        cmd2.ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }

        private void nutthemnguoi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SQLiteConnection(chuoiKetNoiDB))
                {
                    conn.Open();
                    string sqlInsert = "INSERT OR REPLACE INTO NguoiDung(IDNCC, HoVaTen, QuyenHan) VALUES (@id, @name, @role)";
                    using (var cmd = new SQLiteCommand(sqlInsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", nhapidncc.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", nhaphoten.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", nhapquyen.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                nhapidncc.Text = "";
                nhaphoten.Text = "";
                nhapquyen.Text = "";

                MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        private void nutchonanh_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                    ofd.Title = "Chọn hình ảnh món ăn";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        nhaphinhanh.Text = ofd.FileName;
                    }
                }
            }
            catch { }
        }

        private void nutthemmon_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SQLiteConnection(chuoiKetNoiDB))
                {
                    conn.Open();
                    string sqlInsertFood = "INSERT OR REPLACE INTO MonAn(IDMA, TenMonAn, HinhAnh, IDNCC) VALUES (@ma, @ten, @anh, @ncc)";
                    using (var cmd = new SQLiteCommand(sqlInsertFood, conn))
                    {
                        cmd.Parameters.AddWithValue("@ma", nhapidma.Text.Trim());
                        cmd.Parameters.AddWithValue("@ten", nhaptenmon.Text.Trim());
                        cmd.Parameters.AddWithValue("@anh", nhaphinhanh.Text.Trim());
                        cmd.Parameters.AddWithValue("@ncc", nhapidnccmon.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                nhapidma.Text = "";
                nhaptenmon.Text = "";
                nhaphinhanh.Text = "";
                nhapidnccmon.Text = "";

                nuttai_Click(sender, e);
            }
            catch { }
        }

        private void nuttai_Click(object sender, EventArgs e)
        {
            try
            {
                danhsachmon.Items.Clear();
                using (var conn = new SQLiteConnection(chuoiKetNoiDB))
                {
                    conn.Open();
                    string sqlSelect = "SELECT IDMA, TenMonAn, HinhAnh, IDNCC FROM MonAn";
                    using (var cmd = new SQLiteCommand(sqlSelect, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ListViewItem(reader["IDMA"]?.ToString() ?? "");
                            item.SubItems.Add(reader["TenMonAn"]?.ToString() ?? "");
                            item.SubItems.Add(reader["HinhAnh"]?.ToString() ?? "");
                            item.SubItems.Add(reader["IDNCC"]?.ToString() ?? "");
                            danhsachmon.Items.Add(item);
                        }
                    }
                }
            }
            catch { }
        }

        private void nutngau_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SQLiteConnection(chuoiKetNoiDB))
                {
                    conn.Open();
                    string sqlRandom = @"SELECT m.TenMonAn, m.HinhAnh, n.HoVaTen, m.IDNCC 
                                         FROM MonAn m 
                                         LEFT JOIN NguoiDung n ON m.IDNCC = n.IDNCC 
                                         ORDER BY RANDOM() LIMIT 1";

                    using (var cmd = new SQLiteCommand(sqlRandom, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tenMon = reader["TenMonAn"]?.ToString() ?? "Không rõ";
                            string duongDanAnh = reader["HinhAnh"]?.ToString() ?? "";
                            string tenNguoiDongGop = reader["HoVaTen"]?.ToString() ?? "Ẩn danh";
                            string maNcc = reader["IDNCC"]?.ToString() ?? "N/A";

                            khungketqua.Text = $"Hôm nay ăn món: {tenMon}\r\nNgười đóng góp: {tenNguoiDongGop} ({maNcc})";

                            if (File.Exists(duongDanAnh))
                            {
                                using (var ms = new MemoryStream(File.ReadAllBytes(duongDanAnh)))
                                {
                                    khunganh.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                khunganh.Image = null;
                            }
                        }
                        else
                        {
                            khungketqua.Text = "Chưa có dữ liệu món ăn để chọn!";
                            khunganh.Image = null;
                        }
                    }
                }
            }
            catch { }
        }
    }
}