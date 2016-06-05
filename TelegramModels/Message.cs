namespace TelegramModels
{
    public class Message
    {
        public int message_id { get; set; }

        public User from { get; set; }

        public int date { get; set; }

        public Chat chat { get; set; }

        public User forward_from { get; set; }

        public Chat forward_from_chat { get; set; }

        public int forward_date { get; set; }

        public Message reply_to_message { get; set; }

        public int edit_date { get; set; }

        public string text { get; set; }

        public MessageEntity[] entities { get; set; }

        public Audio audio { get; set; }

        public Document document { get; set; }

        public PhotoSize photo { get; set; }

        public Sticker sticker { get; set; }

        public Video video { get; set; }

        public Voice voice { get; set; }

        public string caption { get; set; }

        public Contact contact { get; set; }

        public Location location { get; set; }

        public Venue venue { get; set; }

        public User new_chat_member { get; set; }

        public User left_chat_member { get; set; }

        public string new_chat_title { get; set; }

        public PhotoSize new_chat_photo { get; set; }

        public bool delete_chat_photo { get; set; }

        public bool group_chat_created { get; set; }

        public bool supergroup_chat_created { get; set; }

        public bool channel_chat_created { get; set; }

        public int migrate_to_chat_id { get; set; }

        public int migrate_from_chat_id { get; set; }

        public Message pinned_message { get; set; }


    }
}