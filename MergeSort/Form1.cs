using OfficeOpenXml;
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

namespace MergeSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        private void mergeSortButton_Click(object sender, EventArgs e)
        {
            // Lấy danh sách từ ListBox và chuyển đổi sang List<Tuple<int, string>>
            List<Tuple<int, string>> items = new List<Tuple<int, string>>();
            foreach (var item in listBox1.Items)
            {
                string[] parts = item.ToString().Split(new char[] { ':' }, 2);
                if (parts.Length == 2 && int.TryParse(parts[0].Trim(), out int number))
                {
                    string name = parts[1].Trim();
                    items.Add(new Tuple<int, string>(number, name));
                }
            }

            // Sắp xếp danh sách
            items.Sort((x, y) => x.Item1.CompareTo(y.Item1));

            // Hiển thị danh sách đã sắp xếp trong ListBox
            listBox1.Items.Clear();
            foreach (var item in items)
            {
                listBox1.Items.Add($"{item.Item1}: {item.Item2}");
            }
        }

        private List<Tuple<int, string>> ReadDataFromExcel(string filePath)
        {
            List<Tuple<int, string>> data = new List<Tuple<int, string>>();

            using (var package = new OfficeOpenXml.ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 1; row <= rowCount; row++)
                {
                    if (int.TryParse(worksheet.Cells[row, 1].Text, out int number))
                    {
                        string name = worksheet.Cells[row, 2].Text;
                        data.Add(new Tuple<int, string>(number, name));
                    }
                }
            }

            return data;
        }

        private void btLoadExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                Title = "Select an Excel File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<Tuple<int, string>> data = ReadDataFromExcel(filePath);

                // Hiển thị kết quả trong ListBox
                listBox1.Items.Clear();
                foreach (var entry in data)
                {
                    listBox1.Items.Add($"{entry.Item1}: {entry.Item2}");
                }
            }
        }

        private void btAddtoLB_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            string[] parts = input.Split(new char[] { ',' }, 2);

            if (parts.Length == 2 && int.TryParse(parts[0].Trim(), out int number))
            {
                string name = parts[1].Trim();
                listBox1.Items.Add($"{number}: {name}");
                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu theo định dạng 'số, tên'.");
            }
        }
    }
}
