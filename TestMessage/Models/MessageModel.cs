using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMessage.Models
{
    public class MessageModel
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
