namespace TelegramModels
{
    public class InlineQueryResultCachedMpeg4Gif
    {
        public string type { get; set; }

        public string id { get; set; }

        public string mpeg4_file_id { get; set; }

        public string title { get; set; }

        public string caption { get; set; }

        InlineKeyboardMarkup reply_markup { get; set; }

        public object input_message_content { get; set; }
    }
}
