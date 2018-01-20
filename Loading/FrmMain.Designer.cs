namespace Loading
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLoading = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLoading
            // 
            this.BtnLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLoading.Location = new System.Drawing.Point(135, 100);
            this.BtnLoading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLoading.Name = "BtnLoading";
            this.BtnLoading.Size = new System.Drawing.Size(120, 40);
            this.BtnLoading.TabIndex = 0;
            this.BtnLoading.Text = "Show";
            this.BtnLoading.UseVisualStyleBackColor = true;
            this.BtnLoading.Click += new System.EventHandler(this.BtnLoading_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 253);
            this.Controls.Add(this.BtnLoading);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoading;
    }
}

