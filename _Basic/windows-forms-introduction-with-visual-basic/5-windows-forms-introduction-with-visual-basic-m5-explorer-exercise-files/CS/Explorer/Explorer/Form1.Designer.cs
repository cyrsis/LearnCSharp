namespace Explorer
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
            this.components = new System.ComponentModel.Container();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ViewToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.SmallImageList = new System.Windows.Forms.ImageList(this.components);
            this.LargeImageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabel1,
            this.ViewToolStripComboBox});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(729, 25);
            this.ToolStrip1.TabIndex = 2;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(33, 22);
            this.ToolStripLabel1.Text = "View:";
            // 
            // ViewToolStripComboBox
            // 
            this.ViewToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewToolStripComboBox.Items.AddRange(new object[] {
            "Large Icons",
            "Small Icons",
            "Details"});
            this.ViewToolStripComboBox.Name = "ViewToolStripComboBox";
            this.ViewToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.ViewToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ViewToolStripComboBox_SelectedIndexChanged);
            // 
            // SmallImageList
            // 
            this.SmallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.SmallImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.SmallImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LargeImageList
            // 
            this.LargeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.LargeImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.LargeImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TreeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ListView1);
            this.splitContainer1.Size = new System.Drawing.Size(729, 428);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 3;
            // 
            // TreeView1
            // 
            this.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView1.Location = new System.Drawing.Point(0, 0);
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.Size = new System.Drawing.Size(243, 428);
            this.TreeView1.TabIndex = 0;
            this.TreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // ListView1
            // 
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.LargeImageList = this.LargeImageList;
            this.ListView1.Location = new System.Drawing.Point(0, 0);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(482, 428);
            this.ListView1.SmallImageList = this.SmallImageList;
            this.ListView1.TabIndex = 0;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 453);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "Form1";
            this.Text = "Explorer-Style Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripComboBox ViewToolStripComboBox;
        internal System.Windows.Forms.ImageList SmallImageList;
        internal System.Windows.Forms.ImageList LargeImageList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TreeView1;
        private System.Windows.Forms.ListView ListView1;
    }
}

