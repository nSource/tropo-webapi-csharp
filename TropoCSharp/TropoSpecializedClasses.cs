using System;
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TropoCSharp.Tropo.Specialized
{
    /// <summary>
    /// This is a extended version of Say used in situations such as Ask, where 
    /// Say requires an 'event' key.
    /// </summary>
    public class EventSay : Say
    {
        [JsonProperty(PropertyName = "event")]
        public string Event { get; set; }

        public EventSay(string @value, string @event)
        {
            Value = @value;
            Event = @event;
        }
    }
  
}
