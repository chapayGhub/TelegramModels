namespace TelegramModels
{
    public class editMessageReplyMarkup
    {
        public string chat_id { get; set; }

        public int message_id { get; set; }

        public string inline_message_id { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }
    }
}
