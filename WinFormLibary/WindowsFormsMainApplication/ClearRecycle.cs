﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class ClearRecycle : Form
    {
        public ClearRecycle()
        {
            InitializeComponent();
        }

        const int SHERB_NOCONFIRMATION = 0x000001;	//整型常量在API中表示刪除時沒有確認對話框
        const int SHERB_NOPROGRESSUI = 0x000002;		//在API中表示不顯示刪除進度列
        const int SHERB_NOSOUND = 0x000004;			//在API中表示刪除完畢時不播放聲音

        [DllImport("shell32.dll")]					//宣告API函數
        private static extern int SHEmptyRecycleBin(IntPtr handle, string root, int falgs);

        private void button1_Click(object sender, EventArgs e)
        {
            //清空回收站
            SHEmptyRecycleBin(this.Handle, "", SHERB_NOCONFIRMATION + SHERB_NOPROGRESSUI + SHERB_NOSOUND);
        }

    }
}