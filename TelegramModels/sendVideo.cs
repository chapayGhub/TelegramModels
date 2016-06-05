namespace TelegramModels
{
    public class sendVideo
    {
        public string chat_id { get; set; }

        public object video { get; set; }

        public int duration { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public string caption { get; set; }

        public bool disable_notification { get; set; }

        public int reply_to_message_id { get; set; }

        public object reply_markup { get; set; }
    }
}
