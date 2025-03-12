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
            this.btnnewfolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSave.Location = new System.Drawing.Point(687, 12);
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
            this.btnDelete.Location = new System.Drawing.Point(167, 12);
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
            this.txtCode.Size = new System.Drawing.Size(413, 370);
            this.txtCode.TabIndex = 3;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lstCodes
            // 
            this.lstCodes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCodes.FormattingEnabled = true;
            this.lstCodes.ItemHeight = 16;
            this.lstCodes.Location = new System.Drawing.Point(12, 48);
            this.lstCodes.Name = "lstCodes";
            this.lstCodes.Size = new System.Drawing.Size(331, 370);
            this.lstCodes.TabIndex = 4;
            this.lstCodes.SelectedIndexChanged += new System.EventHandler(this.lstCodes_SelectedIndexChanged);
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(349, 421);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(100, 22);
            this.txtExtension.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "پسوند فایل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(692, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "نام کد";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(586, 422);
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
            this.copycode.Location = new System.Drawing.Point(630, 12);
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
            this.pastecode.Location = new System.Drawing.Point(561, 12);
            this.pastecode.Name = "pastecode";
            this.pastecode.Size = new System.Drawing.Size(63, 30);
            this.pastecode.TabIndex = 10;
            this.pastecode.Text = "پیست";
            this.pastecode.UseVisualStyleBackColor = false;
            this.pastecode.Click += new System.EventHandler(this.pastecode_Click);
            // 
            // btnnewfolder
            // 
            this.btnnewfolder.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnnewfolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnewfolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewfolder.Font = new System.Drawing.Font("Vazir", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnnewfolder.Location = new System.Drawing.Point(248, 12);
            this.btnnewfolder.Name = "btnnewfolder";
            this.btnnewfolder.Size = new System.Drawing.Size(95, 30);
            this.btnnewfolder.TabIndex = 11;
            this.btnnewfolder.Text = "پوشه جدید";
            this.btnnewfolder.UseVisualStyleBackColor = false;
            this.btnnewfolder.Click += new System.EventHandler(this.btnnewfolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 462);
            this.Controls.Add(this.btnnewfolder);
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
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btnnewfolder;
    }
}

