﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new XINEntities())
            {
                //第一筆使用者記錄
                XINUsers NewUsers1 = new XINUsers();
                //填滿NewUsers1的每個屬性
                NewUsers1.EmployeeNo = employeeNo1TextBox.Text;
                NewUsers1.EmployeeName = employeeName1TextBox.Text;
                NewUsers1.PasswordCode = passwordCode1TextBox.Text;
                //將NewUsers1加入XINUsers實體類型
                context.AddObject("XINUsers", NewUsers1);

                //第二筆使用者記錄
                XINUsers NewUsers2 = new XINUsers();
                //填滿NewUsers2的每個屬性
                NewUsers2.EmployeeNo = employeeNo2TextBox.Text;
                NewUsers2.EmployeeName = employeeName2TextBox.Text;
                NewUsers2.PasswordCode = passwordCode2TextBox.Text;
                //將NewUsers2加入XINUsers實體類型
                context.AddObject("XINUsers", NewUsers2);                
                
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }
    }
}
