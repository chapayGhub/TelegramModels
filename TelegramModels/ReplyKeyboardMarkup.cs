namespace TelegramModels
{
    public class ReplyKeyboardMarkup
    {
        public KeyboardButton[][] keyboard { get; set; }

        public bool resize_keyboard { get; set; }

        public bool one_time_keyboard { get; set; }

        public bool selective { get; set; }
    }
}
