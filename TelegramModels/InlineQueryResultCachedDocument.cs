namespace TelegramModels
{
    public class InlineQueryResultCachedDocument
    {
        public string type { get; set; }

        public string id { get; set; }

        public string title { get; set; }

        public string document_file_id { get; set; }

        public string description { get; set; }

        public string caption { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }

        public object input_message_content { get; set; }
    }
}
