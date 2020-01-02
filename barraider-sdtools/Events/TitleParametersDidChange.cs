﻿using BarRaider.SdTools.Payloads;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarRaider.SdTools.Events
{
    public class TitleParametersDidChange
    {
        [JsonProperty("action")]
        public string Action { get; private set; }

        [JsonProperty("context")]
        public string Context { get; private set; }

        [JsonProperty("device")]
        public string Device { get; private set; }

        [JsonProperty("payload")]
        public TitleParametersPayload Payload { get; private set; }

        public TitleParametersDidChange(string action, string context, string device, TitleParametersPayload payload)
        {
            Action = action;
            Context = context;
            Device = device;
            Payload = payload;
        }
    }
}
