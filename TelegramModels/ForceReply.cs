namespace TelegramModels
{
    public class ForceReply
    {
        private bool _force_reply;

        public bool force_reply
        {
            get
            {
                return _force_reply;
            }
            private set
            {
                _force_reply = true;
            }
        }

        public bool selective { get; set; }

    }
}
