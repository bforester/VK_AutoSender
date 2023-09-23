namespace VK_AutoSender.Model
{
    public class UserData
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public long ID { get; set; }
        public string Token { get; set; }
        public ulong AppID { get; set; }

        public UserData(string login, string password, ulong appID, long id)
        {
            Login = login;
            Password = password;
            ID = id;
            AppID = appID;
        }

        public UserData(string token) => Token = token;

    }
}
