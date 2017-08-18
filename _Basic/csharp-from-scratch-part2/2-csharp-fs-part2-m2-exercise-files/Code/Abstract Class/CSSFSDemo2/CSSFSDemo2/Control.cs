using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSFSDemo2
{
    public abstract class Control
    {
        protected int top;
        protected int left;

        public Control(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public Control()
            : this(0, 0)
        { }

        public abstract void DrawMe();

    }

    public class Button : Control
    {
        public string Contents { get; private set; }

        public Button(int top, int left, string contents)
            : base(top, left)
        {
            Contents = contents;
        }

        public override void DrawMe()
        {
            Console.WriteLine("Drawing button with contents: " + Contents);
        }
    }

    public class TextBlock : Control
    {
        public string Text { get; private set; }

        public TextBlock(int top, int left, string text)
            : base(top, left)
        {
            this.Text = text;
        }

        public override void DrawMe()
        {
            Console.WriteLine(Text);
        }
    }

}
