namespace MDI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TileVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MenuStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.WindowToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.MdiWindowListItem = this.WindowToolStripMenuItem;
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(587, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.CloseToolStripMenuItem,
            this.toolStripSeparator,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripMenuItem.Image")));
            this.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NewToolStripMenuItem.Text = "&New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CloseToolStripMenuItem.Text = "&Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem,
            this.toolStripSeparator3,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.SelectAllToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.UndoToolStripMenuItem.Text = "&Undo";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // RedoToolStripMenuItem
            // 
            this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            this.RedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RedoToolStripMenuItem.Text = "&Redo";
            this.RedoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(136, 6);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CutToolStripMenuItem.Image")));
            this.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CutToolStripMenuItem.Text = "Cu&t";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CopyToolStripMenuItem.Image")));
            this.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CopyToolStripMenuItem.Text = "&Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PasteToolStripMenuItem.Image")));
            this.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PasteToolStripMenuItem.Text = "&Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(136, 6);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SelectAllToolStripMenuItem.Text = "Select &All";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // WindowToolStripMenuItem
            // 
            this.WindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CascadeToolStripMenuItem,
            this.TileHorizontallyToolStripMenuItem,
            this.TileVerticallyToolStripMenuItem});
            this.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem";
            this.WindowToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.WindowToolStripMenuItem.Text = "&Window";
            // 
            // CascadeToolStripMenuItem
            // 
            this.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem";
            this.CascadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CascadeToolStripMenuItem.Text = "&Cascade";
            this.CascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // TileHorizontallyToolStripMenuItem
            // 
            this.TileHorizontallyToolStripMenuItem.Name = "TileHorizontallyToolStripMenuItem";
            this.TileHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.TileHorizontallyToolStripMenuItem.Text = "Tile &Horizontally";
            this.TileHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontallyToolStripMenuItem_Click);
            // 
            // TileVerticallyToolStripMenuItem
            // 
            this.TileVerticallyToolStripMenuItem.Name = "TileVerticallyToolStripMenuItem";
            this.TileVerticallyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.TileVerticallyToolStripMenuItem.Text = "Tile &Vertically";
            this.TileVerticallyToolStripMenuItem.Click += new System.EventHandler(this.TileVerticallyToolStripMenuItem_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.toolStripSeparator1,
            this.CutToolStripButton,
            this.CopyToolStripButton,
            this.PasteToolStripButton});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(587, 25);
            this.ToolStrip1.TabIndex = 4;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStripButton.Image")));
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewToolStripButton.Text = "&New";
            this.NewToolStripButton.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButton.Image")));
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStripButton.Text = "&Open";
            this.OpenToolStripButton.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "&Save";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CutToolStripButton
            // 
            this.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CutToolStripButton.Image")));
            this.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutToolStripButton.Name = "CutToolStripButton";
            this.CutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CutToolStripButton.Text = "C&ut";
            this.CutToolStripButton.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripButton
            // 
            this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyToolStripButton.Image")));
            this.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStripButton.Name = "CopyToolStripButton";
            this.CopyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CopyToolStripButton.Text = "&Copy";
            this.CopyToolStripButton.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripButton
            // 
            this.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteToolStripButton.Image")));
            this.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteToolStripButton.Name = "PasteToolStripButton";
            this.PasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PasteToolStripButton.Text = "&Paste";
            this.PasteToolStripButton.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 478);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MDI Text Editor";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        internal System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RedoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        internal System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        internal System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem WindowToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CascadeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TileHorizontallyToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TileVerticallyToolStripMenuItem;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton NewToolStripButton;
        internal System.Windows.Forms.ToolStripButton OpenToolStripButton;
        internal System.Windows.Forms.ToolStripButton SaveToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton CutToolStripButton;
        internal System.Windows.Forms.ToolStripButton CopyToolStripButton;
        internal System.Windows.Forms.ToolStripButton PasteToolStripButton;
    }
}

