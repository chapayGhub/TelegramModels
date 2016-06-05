namespace TelegramModels
{
    public class sendSticker
    {
        public string chat_id { get; set; }

        public object sticker { get; set; }

        public bool disable_notification { get; set; }

        public int reply_to_message_id { get; set; }

        public object reply_markup { get; set; }
    }
}
