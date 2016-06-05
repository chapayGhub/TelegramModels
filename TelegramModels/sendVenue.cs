namespace TelegramModels
{
    public class sendVenue
    {
        public string chat_id { get; set; }

        public float latitude { get; set; }

        public float longitude { get; set; }

        public string title { get; set; }

        public string address { get; set; }

        public string foursquare_id { get; set; }

        public bool disable_notification { get; set; }

        public int reply_to_message_id { get; set; }

        public object reply_markup { get; set; }
    }
}
