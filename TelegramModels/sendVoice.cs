namespace TelegramModels
{
    public class sendVoice
    {
        public string chat_id { get; set; }

        public object voice { get; set; }

        public int duration { get; set; }

        public bool disable_notification { get; set; }

        public int reply_to_message_id { get; set; }

        public object reply_markup { get; set; }
    }
}
