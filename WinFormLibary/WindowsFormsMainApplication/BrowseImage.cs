﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class BrowseImage : Form
    {
        public BrowseImage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //設定文件的類型
            openFileDialog1.Filter = "*.jpg,*.jpeg,*.bmp,*.gif,*.ico,*.png,*.tif,*.wmf|*.jpg;*.jpeg;*.bmp;*.gif;*.ico;*.png;*.tif;*.wmf";
            openFileDialog1.ShowDialog();								//打開文件對話框
            //根據文件的路徑和名稱實例化Image類
            Image myImage = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = myImage;//顯示圖片
            pictureBox1.Height = myImage.Height; 							//設定控制元件的高度
            pictureBox1.Width = myImage.Width; 							//設定控制元件的寬度
        }
    }
}