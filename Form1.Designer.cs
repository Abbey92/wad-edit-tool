namespace wad_edit_tool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Export = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Modify = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Select1 = new System.Windows.Forms.Button();
            this.Select2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Export
            // 
            this.Export.AllowDrop = true;
            this.Export.Location = new System.Drawing.Point(657, 253);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(100, 50);
            this.Export.TabIndex = 0;
            this.Export.Text = "Export_all";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            this.Export.DragDrop += new System.Windows.Forms.DragEventHandler(this.Export_DragDrop);
            this.Export.DragEnter += new System.Windows.Forms.DragEventHandler(this.Export_DragEnter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(727, 154);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(655, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "导出文件_全部";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(530, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "保存文件_全部";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Save
            // 
            this.Save.AllowDrop = true;
            this.Save.Location = new System.Drawing.Point(532, 253);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 50);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save_all";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            this.Save.DragDrop += new System.Windows.Forms.DragEventHandler(this.Save_DragDrop);
            this.Save.DragEnter += new System.Windows.Forms.DragEventHandler(this.Save_DragEnter);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(339, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "替换文件_全部";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(395, 312);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(103, 50);
            this.Modify.TabIndex = 5;
            this.Modify.Text = "2.Modify_all";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 21);
            this.textBox2.TabIndex = 7;
            // 
            // Select1
            // 
            this.Select1.Location = new System.Drawing.Point(277, 312);
            this.Select1.Name = "Select1";
            this.Select1.Size = new System.Drawing.Size(112, 50);
            this.Select1.TabIndex = 8;
            this.Select1.Text = "1.Select wadfile";
            this.Select1.UseVisualStyleBackColor = true;
            this.Select1.Click += new System.EventHandler(this.Select1_Click);
            // 
            // Select2
            // 
            this.Select2.Location = new System.Drawing.Point(23, 312);
            this.Select2.Name = "Select2";
            this.Select2.Size = new System.Drawing.Size(110, 50);
            this.Select2.TabIndex = 12;
            this.Select2.Text = "1.Select wadfile";
            this.Select2.UseVisualStyleBackColor = true;
            this.Select2.Click += new System.EventHandler(this.Select2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 256);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 21);
            this.textBox3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(82, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "导出搜索文件";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(139, 312);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(103, 50);
            this.Filter.TabIndex = 9;
            this.Filter.Text = "2.Export_Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(30, 283);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 21);
            this.textBox4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Select2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.Select1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Export);
            this.Name = "Form1";
            this.Text = "wad edit tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Select1;
        private System.Windows.Forms.Button Select2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.TextBox textBox4;
    }
}

