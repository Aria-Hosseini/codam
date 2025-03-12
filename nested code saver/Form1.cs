using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NestedCodeSaver
{
    public partial class Form1 : Form
    {
        private string folderPath = "SavedCodes"; 
        private List<string> codeFiles = new List<string>(); 

        public Form1()
        {
            InitializeComponent();
            InitializeFolder(); 
            LoadCodes(); 
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

                string codename = txtFileName.Text.Trim();
                if (string.IsNullOrWhiteSpace(codename))
                {
                    codename = $"code_{DateTime.Now.Ticks}"; 
                }

                string fileName = $"{codename}{extension}";
                string fullPath = Path.Combine(folderPath, fileName);

                File.WriteAllText(fullPath, txtCode.Text);
                codeFiles.Add(fullPath);

                UpdateCodeList();
                txtCode.Clear();
                txtFileName.Clear(); 
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
            foreach (var file in codeFiles)
            {
                string fileName = Path.GetFileName(file);
                string content = File.ReadAllText(file);
                string preview = content.Substring(0, Math.Min(50, content.Length)) + "...";
                lstCodes.Items.Add($"{fileName}: {preview}");
            }
        }

        private void lstCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lstCodes.SelectedIndex >= 0)
            {
                string filePath = codeFiles[lstCodes.SelectedIndex];
                txtCode.Text = File.ReadAllText(filePath);
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
        }

        private void btnnewfolder_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "مسیر ذخیره سازی را انتخاب کنید";
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
    }
}