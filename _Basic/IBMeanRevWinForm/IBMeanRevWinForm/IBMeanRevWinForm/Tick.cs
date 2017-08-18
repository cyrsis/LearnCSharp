using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBMeanRevWinForm
{
    class Tick
    {

        int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        int size;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}
