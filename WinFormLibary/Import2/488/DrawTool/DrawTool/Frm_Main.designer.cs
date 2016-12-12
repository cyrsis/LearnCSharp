﻿namespace DrawTool
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的設計器變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放托管資源，為 true；否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 視窗設計器產生的程式碼

        /// <summary>
        /// 設計器支持所需的方法 - 不要
        /// 使用程式碼編輯器修改此方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pen = new System.Windows.Forms.ToolStripButton();
            this.line = new System.Windows.Forms.ToolStripButton();
            this.rectangle = new System.Windows.Forms.ToolStripButton();
            this.ellipse = new System.Windows.Forms.ToolStripButton();
            this.text = new System.Windows.Forms.ToolStripButton();
            this.rubber = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.顏色ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(363, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打開ToolStripMenuItem,
            this.新建ToolStripMenuItem,
            this.儲存ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打開ToolStripMenuItem
            // 
            this.打開ToolStripMenuItem.Name = "打開ToolStripMenuItem";
            this.打開ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打開ToolStripMenuItem.Text = "打開";
            this.打開ToolStripMenuItem.Click += new System.EventHandler(this.打開ToolStripMenuItem_Click);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 儲存ToolStripMenuItem
            // 
            this.儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem";
            this.儲存ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.儲存ToolStripMenuItem.Text = "儲存";
            this.儲存ToolStripMenuItem.Click += new System.EventHandler(this.儲存ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 顏色ToolStripMenuItem
            // 
            this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            this.顏色ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.顏色ToolStripMenuItem.Text = "顏色";
            this.顏色ToolStripMenuItem.Click += new System.EventHandler(this.顏色ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pen,
            this.line,
            this.rectangle,
            this.ellipse,
            this.text,
            this.rubber});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(363, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pen
            // 
            this.pen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pen.Image = ((System.Drawing.Image)(resources.GetObject("pen.Image")));
            this.pen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(36, 22);
            this.pen.Text = "鉛筆";
            this.pen.Click += new System.EventHandler(this.pen_Click);
            // 
            // line
            // 
            this.line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.line.Image = ((System.Drawing.Image)(resources.GetObject("line.Image")));
            this.line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(36, 22);
            this.line.Text = "直線";
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // rectangle
            // 
            this.rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(36, 22);
            this.rectangle.Text = "矩形";
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // ellipse
            // 
            this.ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ellipse.Image = ((System.Drawing.Image)(resources.GetObject("ellipse.Image")));
            this.ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(36, 22);
            this.ellipse.Text = "橢圓";
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // text
            // 
            this.text.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.text.Image = ((System.Drawing.Image)(resources.GetObject("text.Image")));
            this.text.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(36, 22);
            this.text.Text = "文字";
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // rubber
            // 
            this.rubber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rubber.Image = ((System.Drawing.Image)(resources.GetObject("rubber.Image")));
            this.rubber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rubber.Name = "rubber";
            this.rubber.Size = new System.Drawing.Size(36, 22);
            this.rubber.Text = "橡皮";
            this.rubber.Click += new System.EventHandler(this.rubber_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 273);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "簡單畫圖程式";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_Main_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_Main_Paint);
            this.SizeChanged += new System.EventHandler(this.Frm_Main_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_Main_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打開ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton pen;
        private System.Windows.Forms.ToolStripButton line;
        private System.Windows.Forms.ToolStripButton rectangle;
        private System.Windows.Forms.ToolStripButton ellipse;
        private System.Windows.Forms.ToolStripButton text;
        private System.Windows.Forms.ToolStripButton rubber;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

