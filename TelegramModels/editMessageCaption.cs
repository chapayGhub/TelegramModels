namespace TelegramModels
{
    public class editMessageCaption
    {
        public string chat_id { get; set; }

        public int message_id { get; set; }

        public string inline_message_id { get; set; }

        public string caption { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }
    }
}
