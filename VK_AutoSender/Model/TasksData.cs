using System;

namespace VK_AutoSender.Model
{
    public class TasksData
    {
        public DateTime SendingTime { get; set; }
        public int UserID { get; set; }
        public string TextMessage { get; set; }

        public TasksData(DateTime sendingTime, int userID, string textMessage)
        {
            SendingTime = sendingTime;
            UserID = userID;
            TextMessage = textMessage;
        }
    }
}
