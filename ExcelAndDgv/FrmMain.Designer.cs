namespace ExcelAndDgv
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.packageData = new System.Windows.Forms.DataGridView();
            this.loadGridBtn = new System.Windows.Forms.Button();
            this.packageBtn = new System.Windows.Forms.Button();
            this.saveFileBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.packageData)).BeginInit();
            this.SuspendLayout();
            // 
            // packageData
            // 
            this.packageData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.packageData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packageData.Location = new System.Drawing.Point(12, 12);
            this.packageData.Name = "packageData";
            this.packageData.RowTemplate.Height = 23;
            this.packageData.Size = new System.Drawing.Size(962, 370);
            this.packageData.TabIndex = 0;
            this.packageData.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.packageData_SortCompare);
            // 
            // loadGridBtn
            // 
            this.loadGridBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadGridBtn.Location = new System.Drawing.Point(12, 388);
            this.loadGridBtn.Name = "loadGridBtn";
            this.loadGridBtn.Size = new System.Drawing.Size(75, 23);
            this.loadGridBtn.TabIndex = 1;
            this.loadGridBtn.Text = "导入表格";
            this.loadGridBtn.UseVisualStyleBackColor = true;
            this.loadGridBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // packageBtn
            // 
            this.packageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.packageBtn.Location = new System.Drawing.Point(146, 388);
            this.packageBtn.Name = "packageBtn";
            this.packageBtn.Size = new System.Drawing.Size(75, 23);
            this.packageBtn.TabIndex = 2;
            this.packageBtn.Text = "分类打包";
            this.packageBtn.UseVisualStyleBackColor = true;
            this.packageBtn.Click += new System.EventHandler(this.package_Click);
            // 
            // saveFileBtn
            // 
            this.saveFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveFileBtn.Location = new System.Drawing.Point(283, 388);
            this.saveFileBtn.Name = "saveFileBtn";
            this.saveFileBtn.Size = new System.Drawing.Size(75, 23);
            this.saveFileBtn.TabIndex = 3;
            this.saveFileBtn.Text = "保存文件";
            this.saveFileBtn.UseVisualStyleBackColor = true;
            this.saveFileBtn.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(408, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveFileBtn);
            this.Controls.Add(this.packageBtn);
            this.Controls.Add(this.loadGridBtn);
            this.Controls.Add(this.packageData);
            this.Name = "FrmMain";
            this.Text = "家具分类打包";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView packageData;
        private System.Windows.Forms.Button loadGridBtn;
        private System.Windows.Forms.Button packageBtn;
        private System.Windows.Forms.Button saveFileBtn;
        private System.Windows.Forms.Button button1;
    }
}

