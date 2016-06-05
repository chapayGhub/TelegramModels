namespace TelegramModels
{
    public class forwardMessage
    {
        public string chat_id { get; set; }

        public string from_chat_id { get; set; }

        public bool disable_notification { get; set; }

        public int message_id { get; set; }

        public object reply_markup { get; set; }

    }
}
