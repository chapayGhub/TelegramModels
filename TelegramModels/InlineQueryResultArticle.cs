namespace TelegramModels
{
    public class InlineQueryResultArticle
    {
        public string type { get; set; }

        public string id { get; set; }

        public string title { get; set; }

        //InputMessageContent
        public object input_message_content { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }

        public string url { get; set; }

        public bool hide_url { get; set; }

        public string description { get; set; }

        public string thumb_url { get; set; }

        public int thumb_width { get; set; }

        public int thumb_height { get; set; }

    }
}
