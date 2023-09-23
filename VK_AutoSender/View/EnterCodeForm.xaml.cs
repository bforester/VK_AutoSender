using System.Windows;

namespace VK_AutoSender.View
{
    public partial class EnterCodeForm : Window
    {
        public string codeReturn;

        public EnterCodeForm() => InitializeComponent();

        public void Send(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }
    }
}
