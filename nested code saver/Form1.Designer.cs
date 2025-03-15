namespace NestedCodeSaver
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lstCodes = new System.Windows.Forms.ListBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.copycode = new System.Windows.Forms.Button();
            this.pastecode = new System.Windows.Forms.Button();
            this.newpagebtn = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.folderpathlable = new System.Windows.Forms.Label();
            this.vihancode = new System.Windows.Forms.Label();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(349, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ذخیره کد";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnsavecode_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDelete.Location = new System.Drawing.Point(268, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف کد";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(349, 48);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(493, 370);
            this.txtCode.TabIndex = 3;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lstCodes
            // 
            this.lstCodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCodes.FormattingEnabled = true;
            this.lstCodes.ItemHeight = 16;
            this.lstCodes.Location = new System.Drawing.Point(12, 64);
            this.lstCodes.Name = "lstCodes";
            this.lstCodes.Size = new System.Drawing.Size(331, 354);
            this.lstCodes.TabIndex = 4;
            this.lstCodes.SelectedIndexChanged += new System.EventHandler(this.lstCodes_SelectedIndexChanged);
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(548, 427);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(68, 22);
            this.txtExtension.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(622, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "پسوند فایل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(803, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "نام کد";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(697, 425);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 22);
            this.txtFileName.TabIndex = 7;
            // 
            // copycode
            // 
            this.copycode.BackColor = System.Drawing.Color.LightSeaGreen;
            this.copycode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copycode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copycode.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.copycode.Location = new System.Drawing.Point(791, 12);
            this.copycode.Name = "copycode";
            this.copycode.Size = new System.Drawing.Size(51, 30);
            this.copycode.TabIndex = 9;
            this.copycode.Text = "کپی";
            this.copycode.UseVisualStyleBackColor = false;
            this.copycode.Click += new System.EventHandler(this.copycode_Click);
            // 
            // pastecode
            // 
            this.pastecode.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pastecode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pastecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pastecode.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pastecode.Location = new System.Drawing.Point(722, 12);
            this.pastecode.Name = "pastecode";
            this.pastecode.Size = new System.Drawing.Size(63, 30);
            this.pastecode.TabIndex = 10;
            this.pastecode.Text = "پیست";
            this.pastecode.UseVisualStyleBackColor = false;
            this.pastecode.Click += new System.EventHandler(this.pastecode_Click);
            // 
            // newpagebtn
            // 
            this.newpagebtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.newpagebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newpagebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newpagebtn.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.newpagebtn.Location = new System.Drawing.Point(620, 12);
            this.newpagebtn.Name = "newpagebtn";
            this.newpagebtn.Size = new System.Drawing.Size(96, 30);
            this.newpagebtn.TabIndex = 12;
            this.newpagebtn.Text = "صفحه جدید";
            this.newpagebtn.UseVisualStyleBackColor = false;
            this.newpagebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChooseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFolder.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnChooseFolder.Location = new System.Drawing.Point(430, 425);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(105, 30);
            this.btnChooseFolder.TabIndex = 13;
            this.btnChooseFolder.Text = "انتخاب مسیر";
            this.btnChooseFolder.UseVisualStyleBackColor = false;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // folderpathlable
            // 
            this.folderpathlable.AutoSize = true;
            this.folderpathlable.Location = new System.Drawing.Point(12, 45);
            this.folderpathlable.Name = "folderpathlable";
            this.folderpathlable.Size = new System.Drawing.Size(97, 16);
            this.folderpathlable.TabIndex = 14;
            this.folderpathlable.Text = "folderpathlable";
            // 
            // vihancode
            // 
            this.vihancode.AutoSize = true;
            this.vihancode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vihancode.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vihancode.Location = new System.Drawing.Point(12, 434);
            this.vihancode.Name = "vihancode";
            this.vihancode.Size = new System.Drawing.Size(174, 21);
            this.vihancode.TabIndex = 15;
            this.vihancode.Text = "made by VihanCode | v1.1.0";
            this.vihancode.Click += new System.EventHandler(this.vihancode_Click);
            // 
            // searchbar
            // 
            this.searchbar.Location = new System.Drawing.Point(12, 20);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(174, 22);
            this.searchbar.TabIndex = 16;
            this.searchbar.TextChanged += new System.EventHandler(this.searchbar_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 462);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.vihancode);
            this.Controls.Add(this.folderpathlable);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.newpagebtn);
            this.Controls.Add(this.pastecode);
            this.Controls.Add(this.copycode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.lstCodes);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "کدام😁";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ListBox lstCodes;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button copycode;
        private System.Windows.Forms.Button pastecode;
        private System.Windows.Forms.Button newpagebtn;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Label folderpathlable;
        private System.Windows.Forms.Label vihancode;
        private System.Windows.Forms.TextBox searchbar;
    }
}

