﻿using Newtonsoft.Json;

namespace Auth0.ManagementApi.Models
{
    /// <summary>
    /// Represents a rule. A hook is arbitrary JavaScript code that can be used to extend Auth0's default behavior when executed in selected extension points.
    /// </summary>
    public class Hook : HookBase
    {
        /// <summary>
        /// Gets or sets the identifier for the hook.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}