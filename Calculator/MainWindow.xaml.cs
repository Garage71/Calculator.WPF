﻿using System.Windows.Input;

namespace Calculator
{
    /// <summary>
    ///  Main window code-behind
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}