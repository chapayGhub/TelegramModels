namespace TelegramModels
{
    public class InlineQueryResultVoice
    {
        public string type { get; set; }

        public string id { get; set; }

        public string voice_url { get; set; }

        public string title { get; set; }

        public int voice_duration { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }

        public object input_message_content { get; set; }
    }
}