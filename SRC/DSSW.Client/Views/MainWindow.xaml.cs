﻿using DSSW.Client.Utils;
using System.Windows;
using System.Windows.Input;

namespace DSSW.Client.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DragMoveWindow(object sender, MouseButtonEventArgs e)
            => DragMove();

        private void SetWindowSize(object sender, RoutedEventArgs e)
            => WindowPositionHelper.SetSize(this);

        private void SaveWindowSize(object sender, System.ComponentModel.CancelEventArgs e)
            => WindowPositionHelper.SaveSize(this);
    }
}
