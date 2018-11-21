namespace Trim
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空所有文本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.符号处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英文翻译ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unicode转中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.生成百度云分享ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uRL解码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 4);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(355, 319);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Location = new System.Drawing.Point(369, 54);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(355, 319);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.转化ToolStripMenuItem,
            this.清空所有文本ToolStripMenuItem,
            this.复制结果ToolStripMenuItem,
            this.保存文件ToolStripMenuItem,
            this.符号处理ToolStripMenuItem,
            this.英文翻译ToolStripMenuItem,
            this.unicode转中文ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(857, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click);
            // 
            // 转化ToolStripMenuItem
            // 
            this.转化ToolStripMenuItem.Name = "转化ToolStripMenuItem";
            this.转化ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.转化ToolStripMenuItem.Text = "转化";
            this.转化ToolStripMenuItem.Click += new System.EventHandler(this.转化ToolStripMenuItem_Click);
            // 
            // 清空所有文本ToolStripMenuItem
            // 
            this.清空所有文本ToolStripMenuItem.Name = "清空所有文本ToolStripMenuItem";
            this.清空所有文本ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.清空所有文本ToolStripMenuItem.Text = "清空所有文本";
            this.清空所有文本ToolStripMenuItem.Click += new System.EventHandler(this.清空所有文本ToolStripMenuItem_Click);
            // 
            // 复制结果ToolStripMenuItem
            // 
            this.复制结果ToolStripMenuItem.Name = "复制结果ToolStripMenuItem";
            this.复制结果ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.复制结果ToolStripMenuItem.Text = "复制结果";
            this.复制结果ToolStripMenuItem.Click += new System.EventHandler(this.复制结果ToolStripMenuItem_Click);
            // 
            // 保存文件ToolStripMenuItem
            // 
            this.保存文件ToolStripMenuItem.Name = "保存文件ToolStripMenuItem";
            this.保存文件ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.保存文件ToolStripMenuItem.Text = "保存文件";
            this.保存文件ToolStripMenuItem.Click += new System.EventHandler(this.保存文件ToolStripMenuItem_Click);
            // 
            // 符号处理ToolStripMenuItem
            // 
            this.符号处理ToolStripMenuItem.Name = "符号处理ToolStripMenuItem";
            this.符号处理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.符号处理ToolStripMenuItem.Text = "符号处理";
            this.符号处理ToolStripMenuItem.Click += new System.EventHandler(this.符号处理ToolStripMenuItem_Click);
            // 
            // 英文翻译ToolStripMenuItem
            // 
            this.英文翻译ToolStripMenuItem.Name = "英文翻译ToolStripMenuItem";
            this.英文翻译ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.英文翻译ToolStripMenuItem.Text = "英文翻译";
            this.英文翻译ToolStripMenuItem.Click += new System.EventHandler(this.英文翻译ToolStripMenuItem_Click);
            // 
            // unicode转中文ToolStripMenuItem
            // 
            this.unicode转中文ToolStripMenuItem.Name = "unicode转中文ToolStripMenuItem";
            this.unicode转中文ToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.unicode转中文ToolStripMenuItem.Text = "Unicode转中文";
            this.unicode转中文ToolStripMenuItem.Click += new System.EventHandler(this.unicode转中文ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成百度云分享ToolStripMenuItem,
            this.帮助ToolStripMenuItem1,
            this.uRL解码ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "其他";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(16, 50);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel1MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(713, 328);
            this.splitContainer1.SplitterDistance = 343;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 25);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 186);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 25);
            this.textBox2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 260);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "替换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "待替换文字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "目标文字";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(733, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(120, 328);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // 生成百度云分享ToolStripMenuItem
            // 
            this.生成百度云分享ToolStripMenuItem.Name = "生成百度云分享ToolStripMenuItem";
            this.生成百度云分享ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.生成百度云分享ToolStripMenuItem.Text = "生成百度云分享";
            this.生成百度云分享ToolStripMenuItem.Click += new System.EventHandler(this.生成百度云分享ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            this.帮助ToolStripMenuItem1.Click += new System.EventHandler(this.帮助ToolStripMenuItem1_Click);
            // 
            // uRL解码ToolStripMenuItem
            // 
            this.uRL解码ToolStripMenuItem.Name = "uRL解码ToolStripMenuItem";
            this.uRL解码ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.uRL解码ToolStripMenuItem.Text = "URL解码";
            this.uRL解码ToolStripMenuItem.Click += new System.EventHandler(this.uRL解码ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(857, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "文字处理小助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 转化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 保存文件ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 清空所有文本ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem 复制结果ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 符号处理ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 英文翻译ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unicode转中文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成百度云分享ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uRL解码ToolStripMenuItem;
    }
}

