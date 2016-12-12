using System;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class CheckBoxInTreeView : Form
    {
        public CheckBoxInTreeView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.CheckBoxes = true;//顯示復選框
        }
    }
}