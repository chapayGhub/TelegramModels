namespace TelegramModels
{
    public class InlineQueryResultGif
    {
        public string type { get; set; }

        public string id { get; set; }

        public string gif_url { get; set; }

        public int gif_width { get; set; }

        public int gif_height { get; set; }

        public string thumb_url { get; set; }

        public string title { get; set; }

        public string caption { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }

        public object input_message_content { get; set; }

    }
}
