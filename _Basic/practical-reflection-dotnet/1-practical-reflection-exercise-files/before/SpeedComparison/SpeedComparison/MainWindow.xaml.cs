using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Windows;

namespace SpeedComparison
{
    public partial class MainWindow : Window
    {
        #region Events

        private void StaticCreateButton_Click(object sender, RoutedEventArgs e)
        {
            int iterations = GetIterations();

            var startTime = DateTimeOffset.Now;
            for (int i = 0; i < iterations; i++)
            {
                var list = new List<int>();
            }
            var endTime = DateTimeOffset.Now;

            StaticCreateDuration.Text = GetDurationString(startTime, endTime);
        }

        private void ReflectionCreateButton_Click(object sender, RoutedEventArgs e)
        {
            int iterations = GetIterations();

            Type listType = typeof(List<int>);

            var startTime = DateTimeOffset.Now;
            for (int i = 0; i < iterations; i++)
            {
                var list = Activator.CreateInstance(listType);
            }
            var endTime = DateTimeOffset.Now;

            ReflectionCreateDuration.Text = GetDurationString(startTime, endTime);
        }

        private void StaticMethodButton_Click(object sender, RoutedEventArgs e)
        {
            int iterations = GetIterations();

            var list = new List<int>();

            var startTime = DateTimeOffset.Now;
            for (int i = 0; i < iterations; i++)
            {
                list.Add(i);
            }
            var endTime = DateTimeOffset.Now;

            StaticMethodDuration.Text = GetDurationString(startTime, endTime);
        }

        private void ReflectionMethodButton_Click(object sender, RoutedEventArgs e)
        {
            int iterations = GetIterations();

            var list = new List<int>();

            Type listType = typeof(List<int>);
            Type[] parameterTypes = { typeof(int) };
            MethodInfo mi = listType.GetMethod("Add", parameterTypes);

            var startTime = DateTimeOffset.Now;
            for (int i = 0; i < iterations; i++)
            {
                mi.Invoke(list, new object[] { i });
            }
            var endTime = DateTimeOffset.Now;

            ReflectionMethodDuration.Text = GetDurationString(startTime, endTime);
        }

        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private int GetIterations()
        {
            return Int32.Parse(IterationTextBox.Text, NumberStyles.AllowThousands);
        }

        private string GetDurationString(DateTimeOffset startTime, DateTimeOffset endTime)
        {
            var duration = endTime - startTime;
            return string.Format("{0:F0} ms", duration.TotalMilliseconds);
        }
    }
}
