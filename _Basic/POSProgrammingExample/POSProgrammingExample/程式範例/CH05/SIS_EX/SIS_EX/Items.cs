using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    class Items
    {
        /// <summary>
        /// 商品編號
        /// </summary>
        public string ItemsID { get; set; }
        /// <summary>
        /// 商品名稱
        /// </summary>
        public string NAME { get; set; }
        /// <summary>
        /// 數量
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 基本單位-個 台 張 本 片 箱 對 瓶
        /// </summary>
        public string ItemsUnit { get; set; }
        /// <summary>
        /// 單價
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// 合計
        /// </summary>
        public int Totals { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        public string Notes { get; set; }
    }
}
