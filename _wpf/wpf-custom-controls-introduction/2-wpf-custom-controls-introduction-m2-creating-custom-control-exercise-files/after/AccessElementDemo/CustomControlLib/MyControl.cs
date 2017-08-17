using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomControlLib
{
    [TemplatePart(Name = TextBlockPart, Type = typeof(TextBlock))]
    public class MyControl : Control
    {
        private const string TextBlockPart = "PART_TextBlock";

        TextBlock textblock;
        protected TextBlock TextBlock
        {
            get { return textblock; }
            set
            {
                if (textblock != null)
                {
                    textblock.TextInput -= new TextCompositionEventHandler(textblock_TextInput);
                }

                textblock = value;

                if (textblock != null)
                {
                    textblock.Text = "Set from code";
                    textblock.TextInput += new TextCompositionEventHandler(textblock_TextInput);
                }
            }

        }

        static MyControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyControl), new FrameworkPropertyMetadata(typeof(MyControl)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();



            TextBlock = GetTemplateChild(TextBlockPart) as TextBlock;


        }

        void textblock_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
