using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDI
{
    public partial class DocForm : Form
    {
        private static int _counter = 0;

        public DocForm()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateForm();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Rich text files|*.rtf";
            var result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.documentTextBox.LoadFile(dialog.FileName);
                this.Text = dialog.FileName;
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Rich text files|*.rtf";
            dialog.AddExtension = true;
            var result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.documentTextBox.SaveFile(dialog.FileName);
                this.Text = dialog.FileName;
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.documentTextBox.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.documentTextBox.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.documentTextBox.Paste();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.documentTextBox.SelectAll();
        }

        public static DocForm CreateForm()
        {
            var form = new DocForm();
            form.Text = "New Document " + ++_counter;
            SdiApplication.Instance.ApplicationContext.MainForm = this;
            form.Show();

            return form;
        }
    }
}
