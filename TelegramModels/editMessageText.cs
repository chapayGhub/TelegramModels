namespace TelegramModels
{
    public class editMessageText
    {
        public string chat_id { get; set; }

        public int message_id { get; set; }

        public string inline_message_id { get; set; }

        public string text { get; set; }

        public string parse_mode { get; set; }

        public bool disable_web_page_preview { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }
    }
}
