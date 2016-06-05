namespace TelegramModels
{
    public class InlineQueryResultLocation
    {
        public string type { get; set; }

        public string id { get; set; }

        public float latitude { get; set; }

        public float longitude { get; set; }

        public string title { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }

        public object input_message_content { get; set; }

        public string thumb_url { get; set; }

        public int thumb_width { get; set; }

        public int thumb_height { get; set; }
    }
}
