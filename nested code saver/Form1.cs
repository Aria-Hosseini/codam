using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing; 
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
        private const string SearchPlaceholder = "جستجو..."; 

        public Form1()
        {
            InitializeComponent();
            InitializeFolder();
            LoadCodes();

            SetupSearchbarPlaceholder();
        }

        private void SetupSearchbarPlaceholder()
        {
            searchbar.Text = SearchPlaceholder;
            searchbar.ForeColor = Color.Gray; 
            searchbar.Enter += Searchbar_Enter; 
            searchbar.Leave += Searchbar_Leave; 
        }

        private void Searchbar_Enter(object sender, EventArgs e)
        {
            if (searchbar.Text == SearchPlaceholder)
            {
                searchbar.Text = "";
                searchbar.ForeColor = Color.Black; 
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

                File.WriteAllText(fullPath, "[SavedByNestedCodeSaver]\n" + txtCode.Text);

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

            bool showAllFiles = (cmbExtensions.SelectedItem?.ToString() == "همه فایل‌ها");

            foreach (var file in files)
            {
                try
                {
                    string content = File.ReadAllText(file);
                    if (content.StartsWith("[SavedByNestedCodeSaver]")) 
                    {
                        if (showAllFiles)
                        {
                            codeFiles.Add(file);
                        }
                        else if (file.EndsWith(extension, StringComparison.OrdinalIgnoreCase))
                        {
                            codeFiles.Add(file);
                        }
                    }
                }
                catch
                {
                    continue; 
                }
            }

            UpdateCodeList();
        }


        private void UpdateCodeList()
        {
            lstCodes.Items.Clear();
            string searchText = searchbar.Text.Trim().ToLower();
            if (searchText == SearchPlaceholder.ToLower()) searchText = ""; 

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
                    LoadExtensions();

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            folderpathlable.Text = folderPath;
            LoadExtensions();
            cmbExtensions.SelectedIndex = 0;
            LoadCodes();
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

        private void LoadExtensions()
        {
            if (!Directory.Exists(folderPath)) return;

            var extensions = Directory.GetFiles(folderPath)
                                      .Where(f => File.ReadAllText(f).StartsWith("[SavedByNestedCodeSaver]"))
                                      .Select(f => Path.GetExtension(f).ToLower())
                                      .Distinct()
                                      .OrderBy(e => e)
                                      .ToList();

            cmbExtensions.Items.Clear();
            cmbExtensions.Items.Add("همه فایل‌ها");
            cmbExtensions.Items.AddRange(extensions.ToArray());

            cmbExtensions.SelectedIndex = 0;
        }

        private void cmbExtensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExtensions.SelectedItem == null) return;

            string selectedExt = cmbExtensions.SelectedItem.ToString();
            if (selectedExt == "همه فایل‌ها")
            {
                LoadCodes(); 
            }
            else
            {
                codeFiles = Directory.GetFiles(folderPath)
                                    .Where(file => file.EndsWith(selectedExt, StringComparison.OrdinalIgnoreCase) &&
                                                   File.ReadAllText(file).StartsWith("[SavedByNestedCodeSaver]"))
                                    .ToList();
                UpdateCodeList();
            }
        }
    }
}