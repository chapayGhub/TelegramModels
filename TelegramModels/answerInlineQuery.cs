namespace TelegramModels
{
    public class answerInlineQuery
    {
        public string inline_query_id { get; set; }

        //InlineQueryResult
        public object results { get; set; }

        public int cache_time { get; set; }

        public bool is_personal { get; set; }

        public string next_offset { get; set; }

        public string switch_pm_text { get; set; }

        public string switch_pm_parameter { get; set; }

    }
}
