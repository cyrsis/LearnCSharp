using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Category(int id, string name)
        {
            this.CategoryID = id;
            this.CategoryName = name;
        }
    }
}
