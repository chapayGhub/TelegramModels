namespace TelegramModels
{
    public class InlineQueryResultPhoto
    {
        public string type { get; set; }

        public string id { get; set; }

        public string photo_url { get; set; }

        public string thumb_url { get; set; }

        public int photo_width { get; set; }

        public int photo_height { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string caption { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }

        public object input_message_content { get; set; }
    }
}
