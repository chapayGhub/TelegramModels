namespace TelegramModels
{
    public class sendLocation
    {
        public string chat_id { get; set; }

        public float latitude { get; set; }

        public float longitude { get; set; }

        public bool disable_notification { get; set; }

        public int reply_to_message_id { get; set; }

        public object reply_markup { get; set; }
    }
}
