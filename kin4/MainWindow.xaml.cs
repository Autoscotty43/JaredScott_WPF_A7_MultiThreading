
using System.Windows;
using System.Threading.Tasks;

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