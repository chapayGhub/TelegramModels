namespace TelegramModels
{
    public class sendContact
    {
        public string chat_id { get; set; }

        public string phone_number { get; set; }

        public string first_name { get; set; }

        public string last_name { get; set; }

        public string disable_notification { get; set; }

        public int reply_to_message_id { get; set; }

        public object reply_markup { get; set; }
    }
}
