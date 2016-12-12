using System;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class ComboBoxFind : Form
    {
        public ComboBoxFind()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            cbox_Find.Items.Clear();//清空ComboBox集合
            cbox_Find.Items.Add("C#編程詞典");//向ComboBox集合新增元素
            cbox_Find.Items.Add("C#編程寶典");//向ComboBox集合新增元素
            cbox_Find.Items.Add("C#視頻學");//向ComboBox集合新增元素
            cbox_Find.Items.Add("C#範例寶典");//向ComboBox集合新增元素
            cbox_Find.Items.Add("C#從入門到精通");//向ComboBox集合新增元素
            cbox_Find.Items.Add("C#範例大全");//向ComboBox集合新增元素
        }

        private void btn_Begin_Click(object sender, EventArgs e)
        {
            cbox_Find.AutoCompleteMode = //設定自動完成的模式
                AutoCompleteMode.SuggestAppend;
            cbox_Find.AutoCompleteSource = //設定自動完成字串的源
                AutoCompleteSource.ListItems;
        }
    }
}
