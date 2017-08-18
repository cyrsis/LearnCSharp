using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_EX
{
    class Ship : iToolStrip 
    {
        public string Insert()
        {
            string result = "新增出貨單成功!!";
            return result;
        }

        public string Update()
        {
            string result = "更改出貨單成功!!";
            return result;
        }
        public string Delete()
        {
            string result = "刪除出貨單成功!!";
            return result;
        }
        public string Close()
        {
            string result = "關閉出貨作業表單!!";
            return result;
        }
    }
}
