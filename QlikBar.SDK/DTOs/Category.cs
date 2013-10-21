﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QlikBar.SDK;

namespace QlikBar.SDK.DTOs
{

    public class Category
    {
        [JsonProperty("parent")]
        public int? Parent { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("remoteId")]
        public string RemoteId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("articles")]
        public Article[] Articles { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("categories")]
        public Category[] Subcategories { get; set; }



        public override string ToString() { return Id + " - " + Name; }

       
    }

}