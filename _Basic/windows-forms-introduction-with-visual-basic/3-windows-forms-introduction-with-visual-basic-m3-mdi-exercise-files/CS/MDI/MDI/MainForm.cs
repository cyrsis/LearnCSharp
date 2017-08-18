using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int _counter = 0;

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = new ChildForm();
            childForm.MdiParent = this;
            childForm.Text = "New Document " + ++_counter;
            childForm.Show();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Rich text files|*.rtf";
            var result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var childForm = new ChildForm();
                childForm.documentTextBox.LoadFile(dialog.FileName);
                childForm.Text = dialog.FileName;
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;

                var dialog = new SaveFileDialog();
                dialog.Filter = "Rich text files|*.rtf";
                dialog.AddExtension = true;
                var result = dialog.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    childForm.documentTextBox.SaveFile(dialog.FileName);
                    childForm.Text = dialog.FileName;
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.documentTextBox.Undo();
            }
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.documentTextBox.Redo();
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.documentTextBox.Cut();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.documentTextBox.Copy();
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.documentTextBox.Paste();
            }
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                var childForm = (ChildForm)this.ActiveMdiChild;
                childForm.documentTextBox.SelectAll();
            }
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void TileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
