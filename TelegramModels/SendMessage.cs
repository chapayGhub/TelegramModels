namespace TelegramModels
{
    public class SendMessage
    {
        public int chat_id { get; set; }

        public string text { get; set; }

        public string parse_mode { get; set; }

        public bool disable_web_page_preview { get; set; }

        public int reply_to_message_id { get; set; }

        public object reply_markup { get; set; }

    }
}