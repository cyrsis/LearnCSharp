using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonPattern_ex
{
    public partial class FrmRMA : Form
    {
        public FrmRMA()
        {
            InitializeComponent();
        }
         //實作Singleton Pattern
        private static object syncRoot = new Object();
        private static FrmRMA RMA;
        public static FrmRMA Instance
        {
            get
            {
                lock(syncRoot)
                {
                    if (RMA ==null)
                    {
                        RMA = new FrmRMA();
                    }
                    return RMA;
                }
            }
        }
        ~FrmRMA()
        {
            RMA = null;
        }

        private void FrmRMA_FormClosing(object sender, FormClosingEventArgs e)
        {
            //因為獨體模式若表單整個關閉，當重新開啟表單會產生錯誤，故採用隱藏方式處理表單。
            this.Hide();
            e.Cancel = true;
        }

    }
}
