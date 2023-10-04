namespace Bra
{
    partial class Prog
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
            this.Json1 = new System.Windows.Forms.Button();
            this.Json2 = new System.Windows.Forms.Button();
            this.Json = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namemb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Error = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Start = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Json1
            // 
            this.Json1.AutoEllipsis = true;
            this.Json1.Location = new System.Drawing.Point(12, 12);
            this.Json1.Name = "Json1";
            this.Json1.Size = new System.Drawing.Size(125, 103);
            this.Json1.TabIndex = 0;
            this.Json1.Text = "文件1";
            this.Json1.UseVisualStyleBackColor = true;
            this.Json1.Click += new System.EventHandler(this.Json1_Click);
            // 
            // Json2
            // 
            this.Json2.AutoEllipsis = true;
            this.Json2.Location = new System.Drawing.Point(12, 154);
            this.Json2.Name = "Json2";
            this.Json2.Size = new System.Drawing.Size(125, 103);
            this.Json2.TabIndex = 1;
            this.Json2.Text = "文件2";
            this.Json2.UseVisualStyleBackColor = true;
            this.Json2.Click += new System.EventHandler(this.Json2_Click);
            // 
            // Json
            // 
            this.Json.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Json.CheckBoxes = true;
            this.Json.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Namemb,
            this.Error});
            this.Json.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Json.HideSelection = false;
            this.Json.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Json.LabelEdit = true;
            this.Json.Location = new System.Drawing.Point(143, 12);
            this.Json.MultiSelect = false;
            this.Json.Name = "Json";
            this.Json.ShowItemToolTips = true;
            this.Json.Size = new System.Drawing.Size(749, 245);
            this.Json.TabIndex = 2;
            this.Json.UseCompatibleStateImageBehavior = false;
            this.Json.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "序号";
            this.ID.Width = 40;
            // 
            // Namemb
            // 
            this.Namemb.Text = "词头";
            this.Namemb.Width = 270;
            // 
            // Error
            // 
            this.Error.Text = "原因";
            this.Error.Width = 434;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 340);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(125, 46);
            this.Start.TabIndex = 3;
            this.Start.Text = "开始对比";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(12, 392);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(125, 46);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "清空列表";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(143, 263);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(749, 175);
            this.textBox1.TabIndex = 5;
            // 
            // Prog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Json);
            this.Controls.Add(this.Json2);
            this.Controls.Add(this.Json1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prog";
            this.Text = "雷顿&遗忘——json词根比较器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Json1;
        private System.Windows.Forms.Button Json2;
        private System.Windows.Forms.ListView Json;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Namemb;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ColumnHeader Error;
        private System.Windows.Forms.TextBox textBox1;
    }
}

