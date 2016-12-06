using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_14_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //新增記錄
            using (var context = new XINEntities())
            {
                int rowsAffected;

                rowsAffected = context.ExecuteStoreCommand( 
                                       "INSERT INTO Programs VALUES ({0}, {1})",
                                       AddProgramID.Text, AddProgramName.Text);

                listBox1.Items.Add(String.Format("新增了{0}筆記錄", rowsAffected));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //修改記錄
            using (var context = new XINEntities())
            {
                int rowsAffected;

                rowsAffected = context.ExecuteStoreCommand(
                                       "UPDATE Programs SET ProgramName = {0} " +
                                       "WHERE ProgramID = {1}",
                                       UpdateProgramName.Text, UpdateProgramID.Text);

                listBox1.Items.Add(String.Format("修改了{0}筆記錄", rowsAffected));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //刪除記錄
            using (var context = new XINEntities())
            {
                int rowsAffected;
                rowsAffected = context.ExecuteStoreCommand( 
                                      "DELETE FROM Programs " +
                                      "WHERE ProgramID = {0}", DeleteProgramID.Text);

                listBox1.Items.Add(String.Format("刪除了{0}筆記錄", rowsAffected));
            }
        }
    }
}
