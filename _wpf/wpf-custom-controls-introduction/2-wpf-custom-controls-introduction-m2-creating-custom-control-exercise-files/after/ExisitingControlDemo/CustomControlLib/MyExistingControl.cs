﻿using System;
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
    public class MyExistingControl : Button
    {
        static MyExistingControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyExistingControl), new FrameworkPropertyMetadata(typeof(MyExistingControl)));
        }
    }
}
