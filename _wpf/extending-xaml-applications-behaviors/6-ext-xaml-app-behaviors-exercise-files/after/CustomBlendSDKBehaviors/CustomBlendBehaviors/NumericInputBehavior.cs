using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace CustomBlendBehaviors
{
    public class NumericInputBehavior : Behavior<TextBox>
    {
        private static string regexFormat;

        static NumericInputBehavior()
        {
            CultureInfo cInfo = CultureInfo.CurrentCulture;
            regexFormat = @"^([" + cInfo.NumberFormat.PercentDecimalSeparator + @"]?)(\d*)$";
        }

        public bool EnableDecimalInput
        {
            get { return (bool)GetValue(EnableDecimalInputProperty); }
            set { SetValue(EnableDecimalInputProperty, value); }
        }

        public static readonly DependencyProperty EnableDecimalInputProperty =
            DependencyProperty.Register("EnableDecimalInput", typeof(bool), 
            typeof(NumericInputBehavior), new PropertyMetadata(false));

        protected override void OnAttached()
        {
            AssociatedObject.PreviewTextInput += OnPreviewTextInput;
            AssociatedObject.PreviewKeyDown += OnPreviewKeyDown;
        }

        protected override void OnDetaching()
        {
            AssociatedObject.PreviewTextInput -= OnPreviewTextInput;
            AssociatedObject.PreviewKeyDown -= OnPreviewKeyDown;
        }

        private void OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (EnableDecimalInput)
            {
                Regex regExpr = new Regex(regexFormat);
                if (regExpr.IsMatch(e.Text) == false)
                    e.Handled = true;
            }
            else
            {
                foreach (char ch in e.Text)
                {
                    if (!Char.IsDigit(ch))
                        e.Handled = true;
                }
            }
        }
        private void OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
                e.Handled = true;
        }
    }
}
