namespace Delete
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnLL = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPathName = new System.Windows.Forms.Label();
            this.lblLete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLL
            // 
            this.btnLL.Location = new System.Drawing.Point(439, 32);
            this.btnLL.Name = "btnLL";
            this.btnLL.Size = new System.Drawing.Size(72, 39);
            this.btnLL.TabIndex = 9;
            this.btnLL.Text = "浏览";
            this.btnLL.UseVisualStyleBackColor = true;
            this.btnLL.Click += new System.EventHandler(this.btnLL_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(439, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 39);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "开始";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(152, 36);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(272, 104);
            this.txtPath.TabIndex = 7;
            this.txtPath.Click += new System.EventHandler(this.txtPath_Click);
            // 
            // lblPathName
            // 
            this.lblPathName.AutoSize = true;
            this.lblPathName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblPathName.Location = new System.Drawing.Point(29, 40);
            this.lblPathName.Name = "lblPathName";
            this.lblPathName.Size = new System.Drawing.Size(129, 20);
            this.lblPathName.TabIndex = 6;
            this.lblPathName.Text = "请输入路径：";
            // 
            // lblLete
            // 
            this.lblLete.AutoSize = true;
            this.lblLete.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLete.ForeColor = System.Drawing.Color.Red;
            this.lblLete.Location = new System.Drawing.Point(211, 164);
            this.lblLete.Name = "lblLete";
            this.lblLete.Size = new System.Drawing.Size(139, 20);
            this.lblLete.TabIndex = 10;
            this.lblLete.Text = "乐特 s\' Blog";
            this.lblLete.Click += new System.EventHandler(this.lblLete_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 205);
            this.Controls.Add(this.lblLete);
            this.Controls.Add(this.btnLL);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblPathName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lete乐特自制删除空文件夹(目录)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLL;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPathName;
        private System.Windows.Forms.Label lblLete;
    }
}

