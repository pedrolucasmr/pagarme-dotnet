﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PagarMe.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class UpdateSplitSettingsRequest
    {
        public bool Enabled { get; set; }
    }
}