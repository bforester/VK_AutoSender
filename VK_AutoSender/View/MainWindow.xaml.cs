using System;
using System.Threading;
using System.Windows;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using VK_AutoSender.ViewModel;

namespace VK_AutoSender.View
{
    public partial class MainWindow : Window
    {
        public static bool isAuthorized = false;
        public VkApi api;
        public MainWindow(VkApi vkApi, string typeAuth)
        {
            InitializeComponent();
            api = vkApi;


            if(typeAuth == "login")
            {
                userLabel.Text = api.UserId.Value.ToString();

                FriendsHandler.AddFriendsList(api);

                var friends = FriendsHandler.GetFriendsList();

                foreach (var friend in friends)
                {
                    var friendItem = $"{friend.FirstName}  {friend.LastName} | {friend.Id}";
                    friendsListBox.Items.Add(friendItem);
                }
            }           
        }

        private void LogOut(object sender, EventArgs e)
        {
            LoginAuthorization loginAutorization = new LoginAuthorization();
            loginAutorization.Show();
            this.Close();
        }

        private void AddTask(object sender, RoutedEventArgs e)
        {
            var messageText = messageTextBox.Text;
            var user = friendsListBox.SelectedItem.ToString();
            var time = GetTime();

            string task = $"{messageText} TO: {user} | {time}";

            taskListBox.Items.Add(task);

            SendMessage(messageText, 1, new DateTime());
        }

        private void SendMessage(string messageText, long userID, DateTime dateTime)
        {
            Random rnd = new Random();

            api.Messages.Send(new MessagesSendParams
            {
                RandomId = rnd.Next(),
                UserId = long.Parse(friendsListBox.SelectedItem.ToString().Substring(friendsListBox.SelectedItem.ToString().IndexOf('|') + 2)),
                Message = messageTextBox.Text
            }
            );
        }

        private Xceed.Wpf.Toolkit.DateTimePicker GetTime()
        {
            Xceed.Wpf.Toolkit.DateTimePicker result = null;

            Thread t = new Thread(() =>
            {
                Timing timing = new Timing();
                if (timing.ShowDialog() == true)
                {
                    result = timing.DateTimePicker;
                }
            });

            t.SetApartmentState(ApartmentState.STA);
            t.IsBackground = true;

            t.Start();
            t.Join();

            return result;
        }
    }
}
