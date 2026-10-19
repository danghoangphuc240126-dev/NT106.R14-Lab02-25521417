using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace NT106.R14_Lab02_25521417
{
    public partial class Bai04 : Form
    {
        private List<Student> inputList = new List<Student>();
        private List<Student> outputList = new List<Student>();
        private int currentIndex = 0;

        public Bai04()
        {
            InitializeComponent();
        }

        private void write_to_a_file_butt(object sender, EventArgs e)
        {
            if (inputList.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập thông tin và nhấn Add trước khi ghi file.");
                return;
            }

            string json = JsonSerializer.Serialize(inputList);
            File.WriteAllText("input4.txt", json);
            MessageBox.Show("Ghi file input4.txt thành công!");
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void add_butt(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 8 || !int.TryParse(textBox2.Text, out int id)) { MessageBox.Show("ID phải gồm 8 chữ số!"); return; }
            if (textBox3.Text.Length != 10 || !textBox3.Text.StartsWith("0")) { MessageBox.Show("Phone phải gồm 10 chữ số và bắt đầu bằng số 0!"); return; }
            if (!float.TryParse(textBox4.Text, out float c1) || c1 < 0 || c1 > 10) { MessageBox.Show("Course 1 phải từ 0 đến 10!"); return; }
            if (!float.TryParse(textBox5.Text, out float c2) || c2 < 0 || c2 > 10) { MessageBox.Show("Course 2 phải từ 0 đến 10!"); return; }
            if (!float.TryParse(textBox6.Text, out float c3) || c3 < 0 || c3 > 10) { MessageBox.Show("Course 3 phải từ 0 đến 10!"); return; }

            Student st = new Student
            {
                Name = textBox1.Text,
                ID = id,
                Phone = textBox3.Text,
                Course1 = c1,
                Course2 = c2,
                Course3 = c3
            };
            inputList.Add(st);

            richTextBox1.Text += $"{st.Name}\r\n{st.ID}\r\n{st.Phone}\r\n{st.Course1}\r\n{st.Course2}\r\n{st.Course3}\r\n\r\n";

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void back_butt(object sender, EventArgs e)
        {
            if (outputList.Count > 0 && currentIndex > 0)
            {
                currentIndex--;
                textBox8.Text = outputList[currentIndex].Name;
                textBox9.Text = outputList[currentIndex].ID.ToString();
                textBox10.Text = outputList[currentIndex].Phone;
                textBox11.Text = outputList[currentIndex].Course1.ToString();
                textBox12.Text = outputList[currentIndex].Course2.ToString();
                textBox13.Text = outputList[currentIndex].Course3.ToString();
                textBox14.Text = outputList[currentIndex].Average.ToString("0.00");
                label12.Text = (currentIndex + 1).ToString();
            }
        }

        private void next_butt(object sender, EventArgs e)
        {
            if (outputList.Count > 0 && currentIndex < outputList.Count - 1)
            {
                currentIndex++;
                textBox8.Text = outputList[currentIndex].Name;
                textBox9.Text = outputList[currentIndex].ID.ToString();
                textBox10.Text = outputList[currentIndex].Phone;
                textBox11.Text = outputList[currentIndex].Course1.ToString();
                textBox12.Text = outputList[currentIndex].Course2.ToString();
                textBox13.Text = outputList[currentIndex].Course3.ToString();
                textBox14.Text = outputList[currentIndex].Average.ToString("0.00");
                label12.Text = (currentIndex + 1).ToString();
            }
        }

        private void to_read_a_filr_butt(object sender, EventArgs e)
        {
            if (!File.Exists("input4.txt"))
            {
                MessageBox.Show("Không tìm thấy file input4.txt.");
                return;
            }

            string json = File.ReadAllText("input4.txt");
            outputList = JsonSerializer.Deserialize<List<Student>>(json);

            foreach (var st in outputList)
            {
                st.Average = (st.Course1 + st.Course2 + st.Course3) / 3.0f;
            }

            string outJson = JsonSerializer.Serialize(outputList);
            File.WriteAllText("output4.txt", outJson);

            if (outputList.Count > 0)
            {
                currentIndex = 0;
                textBox8.Text = outputList[currentIndex].Name;
                textBox9.Text = outputList[currentIndex].ID.ToString();
                textBox10.Text = outputList[currentIndex].Phone;
                textBox11.Text = outputList[currentIndex].Course1.ToString();
                textBox12.Text = outputList[currentIndex].Course2.ToString();
                textBox13.Text = outputList[currentIndex].Course3.ToString();
                textBox14.Text = outputList[currentIndex].Average.ToString("0.00");
                label12.Text = (currentIndex + 1).ToString();
            }
        }

        private void label12_Click(object sender, EventArgs e) { }
        private void output_txt(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void Bai04_Load(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }
        private void textBox11_TextChanged(object sender, EventArgs e) { }
        private void textBox12_TextChanged(object sender, EventArgs e) { }
        private void textBox13_TextChanged(object sender, EventArgs e) { }
        private void textBox14_TextChanged(object sender, EventArgs e) { }
    }

    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Phone { get; set; }
        public float Course1 { get; set; }
        public float Course2 { get; set; }
        public float Course3 { get; set; }
        public float Average { get; set; }
    }
}