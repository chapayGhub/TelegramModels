namespace TelegramModels
{
    public class InlineQueryResultAudio
    {
        public string type { get; set; }

        public string id { get; set; }

        public string audio_url { get; set; }

        public string title { get; set; }

        public string performer { get; set; }

        public int audio_duration { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }

        public object input_message_content { get; set; }
    }
}
