using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;

namespace _10_04_01
{
    public partial class Form1 : Form
    {

        XINEntities context;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new XINEntities();
            //定義傳回可列舉的物件集合
            ObjectResult<Product> query;
            //取得Product類型的資料
            query = context.Product.Execute(MergeOption.OverwriteChanges);
            //將BindingSource物件繫結至資料來源
            productBindingSource.DataSource = query;
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //結束編輯
            productBindingSource.EndEdit();
            //將異動更新回資料庫
            context.SaveChanges();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "bmp files (*.bmp)|*.bmp|" +
                                     "jpeg files (*.jpg)|*.jpg|" +
                                     "png files (*.png)|*.png|" +
                                     "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image pic;
                pic = Image.FromFile(openFileDialog1.FileName);
                picturePictureBox.Image = pic;
            }
        }
    }
}
