
using System;
using System.Collections.Generic;
using System.Windows;

namespace NumericRangeControlClient {

    public partial class MainWindow : Window {

        int[] dataArray = new int[] { 0, 4, 2, 5, 4, 5, 3, 4, 8, 9, 10 };

        public MainWindow() {
            InitializeComponent();
            DataContext = dataArray;
        }
    }
}
