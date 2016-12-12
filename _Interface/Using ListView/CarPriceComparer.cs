using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Windows.Forms;

namespace Using_ListView
{
    public class CarPriceComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            ListViewItem item1 = x as ListViewItem;
            ListViewItem item2 = y as ListViewItem;
            Car car1 = item1.Tag as Car;
            Car car2 = item2.Tag as Car;

            return car1.Price.CompareTo(car2.Price);
        }
    }
}
