﻿using InstagramAPI.ResponseWrappers.BaseResponse;
using Newtonsoft.Json;

namespace InstagramAPI.ResponseWrappers
{
    public class BadStatusResponse : BaseStatusResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("error_type")]
        public string ErrorType { get; set; }
    }
}