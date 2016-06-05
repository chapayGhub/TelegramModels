namespace TelegramModels
{
    public class InlineQueryResultContact
    {
        public string type { get; set; }

        public string id { get; set; }

        public string phone_number { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }

        public object input_message_content { get; set; }

        public string thumb_url { get; set; }

        public int thumb_width { get; set; }

        public int thumb_height { get; set; }
    }
}
