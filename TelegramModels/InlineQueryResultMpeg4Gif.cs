namespace TelegramModels
{
    public class InlineQueryResultMpeg4Gif
    {
        public string type { get; set; }

        public string id { get; set; }

        public string mpeg4_url { get; set; }

        public int mpeg4_width { get; set; }

        public int mpeg4_height { get; set; }

        public string thumb_url { get; set; }

        public string title { get; set; }

        public string caption { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }

        public object input_message_content { get; set; }
    }
}
