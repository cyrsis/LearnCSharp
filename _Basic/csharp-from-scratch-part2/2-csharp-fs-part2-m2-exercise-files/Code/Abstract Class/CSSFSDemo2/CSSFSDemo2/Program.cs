using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSFSDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Control c = new Control();
            Control button = new Button(0, 0, "Click Me!");
            Control textBlock = new TextBlock(20, 20, "Hello world");

            List<Control> controls = new List<Control>();
            controls.Add(button);
            controls.Add(textBlock);

            foreach (Control ctrl in controls)
            {
                ctrl.DrawMe();
            }
        }
    }
}
