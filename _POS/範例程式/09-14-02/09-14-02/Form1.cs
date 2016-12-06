using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_14_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (var context = new XINEntities())
            {
                if (ProgramID.Text.Trim() == "")
                {
                    //沒輸入程式代碼，找出程式代碼資料表所有的記錄
                    var qry = context.ExecuteStoreQuery<Programs>
                                      ("SELECT * FROM Programs");
                    foreach (Programs row in qry)
                    {
                        listBox1.Items.Add(row.ProgramID + "," + row.ProgramName);
                    }
                }
                else
                {
                    //找出指定程式代碼的程式名稱
                    string ProgramName;
                    ProgramName = context.ExecuteStoreQuery<string>
                                          ("SELECT ProgramName FROM Programs " +
                                           "WHERE ProgramID = {0} ",
                                           ProgramID.Text).FirstOrDefault();
                    listBox1.Items.Add(String.Format("程式名稱：{0}", ProgramName));
                }
            }
        }
    }
}
