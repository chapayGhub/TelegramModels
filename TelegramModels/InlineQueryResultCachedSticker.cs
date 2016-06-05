namespace TelegramModels
{
    public class InlineQueryResultCachedSticker
    {
        public string type { get; set; }

        public string id { get; set; }

        public string sticker_file_id { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }

        public object input_message_content { get; set; }
    }
}
