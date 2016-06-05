namespace TelegramModels
{
    public class MessageEntity
    {
        public string Type { get; set; }

        public int offset { get; set; }

        public int length { get; set; }

        public string url { get; set; }

        public User user { get; set; }

    }
}