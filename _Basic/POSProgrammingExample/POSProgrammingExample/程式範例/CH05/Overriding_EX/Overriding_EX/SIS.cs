using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_EX
{
    class SIS
    {
        /// <summary>
        /// 單號
        /// </summary>
        public virtual  string ID { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public virtual string Date { get; set; }
        /// <summary>
        /// 商品集合
        /// </summary>
        public virtual List<Item> Items { get; set; }
        /// <summary>
        /// 金額
        /// </summary>
        public virtual int Amount { get; set; }

        public virtual int getTotals()
        {
            return 1000;
        }
        public virtual int getInventory()
        {
            return 50;
        }

    }
    class Item
    {
        public string Name { get; set; }
    }
}
