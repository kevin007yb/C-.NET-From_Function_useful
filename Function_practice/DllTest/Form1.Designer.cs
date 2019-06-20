namespace DllTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.zipInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.zipOutput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.壓縮 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.解壓縮 = new System.Windows.Forms.TabPage();
            this.button_7z = new System.Windows.Forms.Button();
            this.壓所加密 = new System.Windows.Forms.TabPage();
            this.excel = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.壓縮.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.解壓縮.SuspendLayout();
            this.excel.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.file.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "excel 路徑檔名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "輸出檔案";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(227, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 29);
            this.textBox4.TabIndex = 8;
            // 
            // zipInput
            // 
            this.zipInput.Location = new System.Drawing.Point(209, 44);
            this.zipInput.Margin = new System.Windows.Forms.Padding(4);
            this.zipInput.Name = "zipInput";
            this.zipInput.Size = new System.Drawing.Size(148, 29);
            this.zipInput.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "7ZIP input";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "7ZIP output";
            // 
            // zipOutput
            // 
            this.zipOutput.Location = new System.Drawing.Point(209, 104);
            this.zipOutput.Margin = new System.Windows.Forms.Padding(4);
            this.zipOutput.Name = "zipOutput";
            this.zipOutput.Size = new System.Drawing.Size(148, 29);
            this.zipOutput.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.壓縮);
            this.tabControl1.Controls.Add(this.excel);
            this.tabControl1.Controls.Add(this.file);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 454);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.Tag = "";
            // 
            // 壓縮
            // 
            this.壓縮.Controls.Add(this.tabControl2);
            this.壓縮.Location = new System.Drawing.Point(4, 28);
            this.壓縮.Name = "壓縮";
            this.壓縮.Padding = new System.Windows.Forms.Padding(3);
            this.壓縮.Size = new System.Drawing.Size(827, 422);
            this.壓縮.TabIndex = 0;
            this.壓縮.Text = "壓縮";
            this.壓縮.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.解壓縮);
            this.tabControl2.Controls.Add(this.壓所加密);
            this.tabControl2.Location = new System.Drawing.Point(30, 25);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(776, 381);
            this.tabControl2.TabIndex = 0;
            // 
            // 解壓縮
            // 
            this.解壓縮.Controls.Add(this.button_7z);
            this.解壓縮.Controls.Add(this.zipInput);
            this.解壓縮.Controls.Add(this.label5);
            this.解壓縮.Controls.Add(this.zipOutput);
            this.解壓縮.Controls.Add(this.label6);
            this.解壓縮.Location = new System.Drawing.Point(4, 28);
            this.解壓縮.Name = "解壓縮";
            this.解壓縮.Padding = new System.Windows.Forms.Padding(3);
            this.解壓縮.Size = new System.Drawing.Size(768, 349);
            this.解壓縮.TabIndex = 0;
            this.解壓縮.Text = "解壓縮";
            this.解壓縮.UseVisualStyleBackColor = true;
            // 
            // button_7z
            // 
            this.button_7z.Location = new System.Drawing.Point(493, 132);
            this.button_7z.Name = "button_7z";
            this.button_7z.Size = new System.Drawing.Size(85, 31);
            this.button_7z.TabIndex = 13;
            this.button_7z.Text = "submit";
            this.button_7z.UseVisualStyleBackColor = true;
            this.button_7z.Click += new System.EventHandler(this.button_7z_Click);
            // 
            // 壓所加密
            // 
            this.壓所加密.Location = new System.Drawing.Point(4, 28);
            this.壓所加密.Name = "壓所加密";
            this.壓所加密.Padding = new System.Windows.Forms.Padding(3);
            this.壓所加密.Size = new System.Drawing.Size(768, 349);
            this.壓所加密.TabIndex = 1;
            this.壓所加密.Text = "壓縮(加密)";
            this.壓所加密.UseVisualStyleBackColor = true;
            // 
            // excel
            // 
            this.excel.Controls.Add(this.tabControl3);
            this.excel.Location = new System.Drawing.Point(4, 28);
            this.excel.Name = "excel";
            this.excel.Padding = new System.Windows.Forms.Padding(3);
            this.excel.Size = new System.Drawing.Size(827, 422);
            this.excel.TabIndex = 1;
            this.excel.Text = "excel 部分";
            this.excel.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Location = new System.Drawing.Point(27, 26);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(774, 379);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(766, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(227, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "加密";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listBox1);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.textBox8);
            this.tabPage5.Controls.Add(this.textBox7);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(766, 347);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "excel Row Count";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "sheetname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "excel path name";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(186, 152);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(195, 29);
            this.textBox8.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(184, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(198, 29);
            this.textBox7.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // file
            // 
            this.file.Controls.Add(this.textBox2);
            this.file.Controls.Add(this.label2);
            this.file.Location = new System.Drawing.Point(4, 28);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(827, 422);
            this.file.TabIndex = 2;
            this.file.Text = "檔案管理";
            this.file.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 29);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "搜尋檔案目錄路徑";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(73, 200);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(525, 130);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 523);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.壓縮.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.解壓縮.ResumeLayout(false);
            this.解壓縮.PerformLayout();
            this.excel.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.file.ResumeLayout(false);
            this.file.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox zipInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zipOutput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 壓縮;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage 解壓縮;
        private System.Windows.Forms.TabPage 壓所加密;
        private System.Windows.Forms.TabPage excel;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button_7z;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage file;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ListBox listBox1;
    }
}

