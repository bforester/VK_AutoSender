using System.Windows;
using VK_AutoSender.ViewModel;

namespace VK_AutoSender.View
{
    public partial class TokenAuthorization : Window
    {
        public TokenAuthorization() => InitializeComponent();

        private void AuthVerify(object sender, RoutedEventArgs e)
        {
            var isAuth = Authentification.AuthTokenVerify(token_TextBox.Text);

            if (isAuth.Item1)
            {
                MainWindow.isAuthorized = true;
                var mainWindow = new MainWindow(isAuth.Item3, "token");
                mainWindow.Show();
                this.Close();
            }
            else
            {
                var exceptionMessage = isAuth.Item2;
                MessageBox.Show(exceptionMessage.Message);
            }
        }

        private void GoingBack(object sender, RoutedEventArgs e)
        {
            LoginAuthorization loginAuthorization = new LoginAuthorization();
            loginAuthorization.Show();
            loginAuthorization.Left = this.Left;
            loginAuthorization.Top = this.Top;
            this.Close();
        }
    }
}
