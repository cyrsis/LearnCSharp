using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Delegate_Targets
{
    class Person
    {
        public string Name { get; set; }
        public void ShowName()
        {
            MessageBox.Show(Name);
        }
        public static void ShowClassName()
        {
            MessageBox.Show("Person");
        }
    }
}
