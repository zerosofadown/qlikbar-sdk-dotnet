﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace QlikBar.SDK.DTOs
{

    public class OrderPart
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("article")]
        public int Article { get; set; }

        public override string ToString() { return Id + " - " + Article; }
    }

}
