using System.Windows;
namespace VK_AutoSender.View
{
    public partial class Timing : Window
    {
        public Timing()
        {
            InitializeComponent();        
        }

        private void OkTiming(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }
    }
}
