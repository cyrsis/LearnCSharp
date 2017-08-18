using SampleAssembly;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Documents;

namespace ReflectionDangers.WPF
{
    public partial class MainWindow : Window
    {
        SampleClass publicSample;
        SampleClass privateSample;

        public MainWindow()
        {
            InitializeComponent();
            publicSample = new SampleClass();
            privateSample = new SampleClass();
        }

        private void PublicMembersButton_Click(object sender, RoutedEventArgs e)
        {
            PublicListBox.ItemsSource = null;
            PublicListBox.ItemsSource = publicSample.CachedItems;
            PublicDataTime.Text = publicSample.DataTime;
            CurrentTimeTextBlock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void PrivateMembersButton_Click(object sender, RoutedEventArgs e)
        {
            Type sampleType = typeof(SampleClass);
            FieldInfo cacheField = sampleType.GetField("cachedItems", 
                                              BindingFlags.NonPublic | BindingFlags.Instance);
            List<string> cacheValue = cacheField.GetValue(privateSample) as List<string>;

            PrivateListBox.ItemsSource = null;
            PrivateListBox.ItemsSource = cacheValue;
            PrivateDataTime.Text = privateSample.DataTime;
            CurrentTimeTextBlock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
