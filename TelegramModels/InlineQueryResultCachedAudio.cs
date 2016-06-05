namespace TelegramModels
{
    public class InlineQueryResultCachedAudio
    {
        public string type { get; set; }

        public string id { get; set; }

        public string audio_file_id { get; set; }

        public InlineKeyboardMarkup reply_markup { get; set; }

        public object input_message_content { get; set; }
    }
}
