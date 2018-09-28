﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeepSpace.Messages
{
    public class CreateShipResponse : CreateShipRequest
    {
        [JsonProperty(PropertyName = "commandCode")]
        public string CommandCode { get; set; }
    }
}
