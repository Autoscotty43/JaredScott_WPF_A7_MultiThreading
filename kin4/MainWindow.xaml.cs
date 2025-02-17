using System;
using System.Collections.Generic;
using System.Collections;
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
using System.Threading;  //add Threading
using System.Threading.Tasks;

using System.IO;  // add File IO
using System.ComponentModel;
using System.Windows.Threading;  //add background worker

namespace kin4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Synch_Button_Click(object sender, RoutedEventArgs e)
        {
            // Use Task.Run to offload to a background thread
            Task.Run(() =>
            {
                kin4.synched.Main synchedMain = new kin4.synched.Main();
                synchedMain.Main1(outputTextBox); // Perform work in the background
            });
        }

        private void NotSynch_Button_Click(object sender, RoutedEventArgs e)
        {
            // Use Task.Run to offload to a background thread
            Task.Run(() =>
            {
                kin4.notsynched.Main notSynchedMain = new kin4.notsynched.Main();
                notSynchedMain.Main1(outputTextBox); // Perform work in the background
            });
        }

    }
}