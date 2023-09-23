using System;
using System.Windows;
using VK_AutoSender.ViewModel;

namespace VK_AutoSender.View
{
    public partial class LoginAuthorization : Window
    {
        public LoginAuthorization() => InitializeComponent();

        private void SignInToken(object sender, RoutedEventArgs e)
        {
            TokenAuthorization tokenAutorization = new TokenAuthorization();
            tokenAutorization.Show();
            tokenAutorization.Left = this.Left;
            tokenAutorization.Top = this.Top;
            this.Close();
        }

        private void AuthVerify(object sender, RoutedEventArgs e)
        {
            try
            {
                var login = login_TextBox.Text;
                var password = password_TextBox.Password;
                var appID = ulong.Parse(AppID_TextBox.Text);
                var isAuth = Authentification.AuthLoginVerify(login, password, appID);

                if (isAuth.Item1)
                {
                    var mainWindow = new MainWindow(isAuth.Item3, "login");
                    MainWindow.isAuthorized = true;
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    var exceptionMessage = isAuth.Item2;
                    MessageBox.Show(exceptionMessage.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TimePicker_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
