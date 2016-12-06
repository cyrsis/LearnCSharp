using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SourceStrategy ss;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            ss = new InsertSource();
            ss.runCheckField();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ss = new UpdateSource();
            ss.runCheckField();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             ss = new UpdateSource();
            ss.runCheckField();
        }
    }

    public abstract class SourceStrategy
    {
        public iCheckField ICheckField;
        public SourceStrategy() { }

        public SourceStrategy(iCheckField cf)
        {
            this.ICheckField = cf;
        }

        public void runCheckField()
        {
            ICheckField.CheckField();
        }

        public void setIICheckField(iCheckField cf)
        {
            ICheckField = cf;
        }
    }


    public interface iCheckField
    {
        bool CheckField();
    }


    public class InsertSource : SourceStrategy
    {
        public InsertSource()
        {
            this.ICheckField = new CheckWithInsert();
        }
    }

    public class UpdateSource : SourceStrategy
    {
        public UpdateSource()
        {
            this.ICheckField = new CheckWithUpdate();
        }
    }

    public class DeleteSource : SourceStrategy
    {
        public DeleteSource()
        {
            this.ICheckField = new CheckWithDelete();
        }
    }

    public class CheckWithInsert : iCheckField
    {
        public bool CheckField()
        {
            MessageBox.Show(@"新增資料欄位驗證無誤 !!", "CheckWithInsert");
            return true;
        }
    }


    public class CheckWithUpdate : iCheckField
    {
        public bool CheckField()
        {
            MessageBox.Show(@"更改資料欄位驗證無誤 !!", "CheckWithUpdate");
            return true;
        }
    }


    public class CheckWithDelete : iCheckField
    {
        public bool CheckField()
        {
            MessageBox.Show(@"刪除資料欄位驗證無誤 !!", "CheckWithUpdate");
            return true;
        }
    }

}
