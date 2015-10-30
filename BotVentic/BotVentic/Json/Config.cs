﻿using Newtonsoft.Json;

namespace BotVentic.Json
{
    class Config
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("editthreshold")]
        public int EditThreshold { get; set; }

        [JsonProperty("editmax")]
        public int EditMax { get; set; }
    }
}
