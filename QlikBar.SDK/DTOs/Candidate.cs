﻿// ***********************************************************************
// Assembly         : QlikBar.SDK
// Author           : Antonio Gil Espinosa
// Created          : 10-21-2013
//
// Last Modified By : Antonio Gil Espinosa
// Last Modified On : 10-17-2013
// ***********************************************************************
// <copyright file="Candidate.cs" company="">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace QlikBar.SDK.DTOs
{

    /// <summary>
    /// Class Candidate
    /// </summary>
    public class Candidate
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the article.
        /// </summary>
        /// <value>The article.</value>
        [JsonProperty("article")]
        public int Article { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() { return Article.ToString(); }
    }

}
