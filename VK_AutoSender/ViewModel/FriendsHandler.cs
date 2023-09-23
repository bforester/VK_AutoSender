using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;

namespace VK_AutoSender.ViewModel
{
    public class FriendsHandler
    {
        private static VkNet.Utils.VkCollection<User> Friends { get; set; }

        public static VkNet.Utils.VkCollection<User> GetFriendsList() => Friends;


        public static void AddFriendsList(VkApi vkApi)
        {
            ProfileFields pf = ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.Online;
            Friends = vkApi.Friends.Get(new FriendsGetParams { UserId = vkApi.UserId.Value, Fields = pf });
        }

    }
}
