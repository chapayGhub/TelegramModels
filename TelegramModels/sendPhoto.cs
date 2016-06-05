namespace TelegramModels
{
    public class sendPhoto
    {
        public string chat_id { get; set; }

        public object audio { get; set; }

        public int duration { get; set; }

        public string performer { get; set; }

        public string title { get; set; }

        public bool disable_notification { get; set; }

        public int reply_to_message_id { get; set; }

        public object reply_markup { get; set; }

    }
}
