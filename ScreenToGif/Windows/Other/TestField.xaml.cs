﻿using System;
using System.Windows;
using System.Windows.Interop;
using ScreenToGif.Util;

namespace ScreenToGif.Windows.Other
{
    public partial class TestField : Window
    {
        private IntPtr _handle;

        public TestField()
        {
            InitializeComponent();
        }

        private void WindowTest_OnLoaded(object sender, RoutedEventArgs e)
        {
            _handle = new WindowInteropHelper(this).Handle;
        }

        private void WindowTest_OnLocationChanged(object sender, EventArgs e)
        {
            Native.Rect rect;
            Native.GetWindowRect(_handle, out rect);

            //LeftLabel2.Content = rect.Left;
            //TopLabel2.Content = rect.Top;
            //RightLabel2.Content = rect.Right - rect.Left;
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //ExamplePath.Data = Geometry.Parse(InputTextBox.Text);
            }
            catch (Exception ex)
            {
                //LogWriter.Log(ex, "Geometry Parse error", InputTextBox.Text);
            }
        }
    }
}
