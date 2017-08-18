using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ListView1.Columns.Add("Name", 250);
                ListView1.Columns.Add("Date modified", 150);
                ListView1.Columns.Add("Size", 75, HorizontalAlignment.Right);
                ViewToolStripComboBox.SelectedIndex = 0;

                var docs = new TreeNode("My Documents");
                docs.Tag = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                TreeView1.Nodes.Add(docs);

                GetFolders(docs);
                docs.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var dir = new DirectoryInfo(e.Node.Tag.ToString());

            ListView1.Items.Clear();
            SmallImageList.Images.RemoveByKey(".exe");
            LargeImageList.Images.RemoveByKey(".exe");
            foreach (var file in dir.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name);
                var lastWrite = file.LastWriteTime;
                item.SubItems.Add(lastWrite.ToShortDateString() + " " + lastWrite.ToShortTimeString());
                item.SubItems.Add(Math.Ceiling(file.Length / 1024.0) + " KB");

                if (!(LargeImageList.Images.ContainsKey(file.Extension)))
                {
                    var thisIcon = Icon.ExtractAssociatedIcon(file.FullName);
                    SmallImageList.Images.Add(file.Extension, thisIcon);
                    LargeImageList.Images.Add(file.Extension, thisIcon);
                }

                item.ImageKey = file.Extension;
                ListView1.Items.Add(item);
            }
        }

        private void ViewToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ViewToolStripComboBox.Text)
            {
                case "Large Icons":
                    ListView1.View = View.LargeIcon;
                    break;
                case "Small Icons":
                    ListView1.View = View.SmallIcon;
                    break;
                case "Details":
                    ListView1.View = View.Details;
                    break;
            }
        }

        private void GetFolders(TreeNode node)
        {
            var dir = new DirectoryInfo(node.Tag.ToString());

            try
            {
                foreach (var childDir in dir.GetDirectories())
                {
                    if (childDir.Attributes.HasFlag(FileAttributes.Hidden))
                    {
                        continue;
                    }

                    var childNode = new TreeNode(childDir.Name);
                    childNode.Tag = childDir.FullName;
                    node.Nodes.Add(childNode);

                    GetFolders(childNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
            }
        }
    }
}
