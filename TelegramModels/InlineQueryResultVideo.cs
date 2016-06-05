namespace TelegramModels
{
    public class InlineQueryResultVideo
    {
        public string type { get; set; }

        public string id { get; set; }

        public string video_url { get; set; }

        public string mime_type { get; set; }

        public string thumb_url { get; set; }

        public string title { get; set; }

        public string caption { get; set; }

        public int video_width { get; set; }

        public int video_height { get; set; }

        public int video_duration { get; set; }

        public string description { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }

        public object input_message_content { get; set; }
    }
}
