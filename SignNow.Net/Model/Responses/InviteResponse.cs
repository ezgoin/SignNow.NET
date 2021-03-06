using System;
using Newtonsoft.Json;

namespace SignNow.Net.Model
{
    /// <summary>
    /// Represents response from SignNow API for create invite request.
    /// </summary>
    public class InviteResponse
    {
        /// <summary>
        /// Identity of invite request.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
