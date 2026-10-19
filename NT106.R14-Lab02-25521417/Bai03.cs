using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NT106.R14_Lab02_25521417
{
    public partial class Bai03 : Form
    {
        private string[] lines = new string[0];

        public Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lines = File.ReadAllLines(ofd.FileName);
                    richTextBox1.Text = string.Join(Environment.NewLine, lines);
                    MessageBox.Show("Đọc file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lines == null || lines.Length == 0)
            {
                MessageBox.Show("Vui lòng đọc file dữ liệu trước khi ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FileName = "output3.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<string> resultLines = new List<string>();

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        string expression = line.Replace("–", "-");

                        try
                        {
                            double result = EvaluateExpression(expression);
                            resultLines.Add($"{line} = {result}");
                        }
                        catch
                        {
                            resultLines.Add($"{line} = Error");
                        }
                    }

                    File.WriteAllLines(sfd.FileName, resultLines);

                    richTextBox1.Text = string.Join(Environment.NewLine, resultLines);

                    MessageBox.Show("Ghi kết quả ra file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private double EvaluateExpression(string expression)
        {
            Stack<double> values = new Stack<double>();
            Stack<char> ops = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ' ')
                    continue;

                if (char.IsDigit(expression[i]))
                {
                    StringBuilder sbuf = new StringBuilder();
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        sbuf.Append(expression[i++]);
                    }
                    values.Push(double.Parse(sbuf.ToString(), System.Globalization.CultureInfo.InvariantCulture));
                    i--;
                }
                else if (expression[i] == '(')
                {
                    ops.Push(expression[i]);
                }
                else if (expression[i] == ')')
                {
                    while (ops.Count > 0 && ops.Peek() != '(')
                    {
                        values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Pop();
                }
                else if (expression[i] == '+' || expression[i] == '-' || expression[i] == '*' || expression[i] == '/')
                {
                    if (expression[i] == '-' && (i == 0 || expression[i - 1] == ' ' || expression[i - 1] == '('))
                    {
                        int prevIndex = i - 1;
                        while (prevIndex >= 0 && expression[prevIndex] == ' ') prevIndex--;

                        if (prevIndex < 0 || expression[prevIndex] == '(' || IsOperator(expression[prevIndex]))
                        {
                            StringBuilder sbuf = new StringBuilder("-");
                            i++;
                            while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                            {
                                sbuf.Append(expression[i++]);
                            }
                            values.Push(double.Parse(sbuf.ToString(), System.Globalization.CultureInfo.InvariantCulture));
                            i--;
                            continue;
                        }
                    }

                    while (ops.Count > 0 && HasPrecedence(expression[i], ops.Peek()))
                    {
                        values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Push(expression[i]);
                }
            }

            while (ops.Count > 0)
            {
                values.Push(ApplyOp(ops.Pop(), values.Pop(), values.Pop()));
            }

            return values.Pop();
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        private bool HasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
                return false;
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
                return false;
            return true;
        }

        private double ApplyOp(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/':
                    if (b == 0) throw new DivideByZeroException("Lỗi chia cho 0");
                    return a / b;
            }
            return 0;
        }
    }
}