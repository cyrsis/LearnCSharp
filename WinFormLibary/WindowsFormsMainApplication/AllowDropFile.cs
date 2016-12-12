﻿using System;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class AllowDropFile : Form
    {
        public AllowDropFile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);		//取得拖入文件的基本訊息
                for (int i = 0; i < files.Length; i++)							//拖放入視窗的文件的文件名加入ListBox
                {
                    listBox1.Items.Add(files[i]);									//新增文件的路徑
                }
            }
        }
    }
}