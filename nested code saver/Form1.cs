using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing; // برای رنگ‌ها
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NestedCodeSaver
{
    public partial class Form1 : Form
    {
        private string folderPath = "SavedCodes";
        private List<string> codeFiles = new List<string>();
        private string selectedFilePath = null;
        private const string SearchPlaceholder = "جستجو..."; // متن Placeholder

        public Form1()
        {
            InitializeComponent();
            InitializeFolder();
            LoadCodes();

            // تنظیم Placeholder برای searchbar
            SetupSearchbarPlaceholder();
        }

        private void SetupSearchbarPlaceholder()
        {
            searchbar.Text = SearchPlaceholder;
            searchbar.ForeColor = Color.Gray; // رنگ خاکستری برای Placeholder
            searchbar.Enter += Searchbar_Enter; // وقتی کاربر وارد تکست‌باکس می‌شه
            searchbar.Leave += Searchbar_Leave; // وقتی کاربر از تکست‌باکس خارج می‌شه
        }

        private void Searchbar_Enter(object sender, EventArgs e)
        {
            if (searchbar.Text == SearchPlaceholder)
            {
                searchbar.Text = "";
                searchbar.ForeColor = Color.Black; // رنگ معمولی برای تایپ
            }
        }

        private void Searchbar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchbar.Text))
            {
                searchbar.Text = SearchPlaceholder;
                searchbar.ForeColor = Color.Gray;
            }
        }

        private void InitializeFolder()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private void btnsavecode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCode.Text))
            {
                string extension = txtExtension.Text.Trim();
                if (string.IsNullOrWhiteSpace(extension))
                {
                    extension = "txt";
                }
                if (!extension.StartsWith(".")) extension = "." + extension;

                string fullPath;

                if (selectedFilePath != null)
                {
                    fullPath = selectedFilePath;
                }
                else
                {
                    string codename = txtFileName.Text.Trim();
                    if (string.IsNullOrWhiteSpace(codename))
                    {
                        codename = $"code_{DateTime.Now.Ticks}";
                    }
                    string fileName = $"{codename}{extension}";
                    fullPath = Path.Combine(folderPath, fileName);
                    codeFiles.Add(fullPath);
                }

                File.WriteAllText(fullPath, txtCode.Text);
                UpdateCodeList();
                txtCode.Clear();
                txtFileName.Clear();
                selectedFilePath = null;
                MessageBox.Show("کد با موفقیت ذخیره شد!");
            }
            else
            {
                MessageBox.Show("لطفاً کدی وارد کنید!");
            }
        }

        private void LoadCodes()
        {
            codeFiles.Clear();
            string[] files = Directory.GetFiles(folderPath);
            string extension = txtExtension.Text.Trim();
            if (string.IsNullOrWhiteSpace(extension))
            {
                extension = ".txt";
            }
            if (!extension.StartsWith(".")) extension = "." + extension;

            codeFiles.AddRange(files.Where(file => file.EndsWith(extension, StringComparison.OrdinalIgnoreCase)));
            UpdateCodeList();
        }

        private void UpdateCodeList()
        {
            lstCodes.Items.Clear();
            string searchText = searchbar.Text.Trim().ToLower();
            if (searchText == SearchPlaceholder.ToLower()) searchText = ""; // نادیده گرفتن Placeholder

            foreach (var file in codeFiles)
            {
                string fileName = Path.GetFileName(file);
                string content = File.ReadAllText(file).ToLower();

                if (string.IsNullOrWhiteSpace(searchText) || content.Contains(searchText) || fileName.ToLower().Contains(searchText))
                {
                    string preview = content.Substring(0, Math.Min(50, content.Length)) + "...";
                    lstCodes.Items.Add($"{fileName}: {preview}");
                }
            }
        }

        private void lstCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCodes.SelectedIndex >= 0)
            {
                selectedFilePath = codeFiles[lstCodes.SelectedIndex];
                txtCode.Text = File.ReadAllText(selectedFilePath);
            }
            else
            {
                selectedFilePath = null;
            }
            lstCodes.HorizontalScrollbar = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstCodes.SelectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("آیا مطمئن هستید که می‌خواهید این کد را حذف کنید؟",
                            "تأیید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    string filePath = codeFiles[lstCodes.SelectedIndex];
                    File.Delete(filePath);
                    codeFiles.RemoveAt(lstCodes.SelectedIndex);
                    UpdateCodeList();
                    txtCode.Clear();
                    selectedFilePath = null;
                }
            }
        }

        private void copycode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCode.Text);
        }

        private void pastecode_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                txtCode.Text = Clipboard.GetText();
            }
            else
            {
                MessageBox.Show("کلیپ‌بورد خالیه!");
            }
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            txtCode.ScrollBars = ScrollBars.Vertical;
            txtCode.Font = new System.Drawing.Font("vazir", 9);
        }

        private void btnnewfolder_Click(object sender, EventArgs e)
        {
            // هنوز پیاده‌سازی نشده
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            selectedFilePath = null;
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "مسیر ذخیره‌سازی را انتخاب کنید";
                folderDialog.SelectedPath = folderPath;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    folderPath = folderDialog.SelectedPath;
                    folderpathlable.Text = folderPath;
                    LoadCodes();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            folderpathlable.Text = folderPath;
        }

        private void vihancode_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Aria-Hosseini",
                UseShellExecute = true,
            });
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            UpdateCodeList();
        }
    }
}