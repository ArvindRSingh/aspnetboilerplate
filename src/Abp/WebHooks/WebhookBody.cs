﻿namespace Abp.WebHooks
{
    public class WebhookBody
    {
        public string Event { get; set; }

        public int Attempt { get; set; }

        public dynamic Data { get; set; }
    }
}