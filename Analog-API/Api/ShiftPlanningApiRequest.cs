using Newtonsoft.Json;

namespace Analog_API.Api
{
    public class ShiftPlanningApiRequest
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("output")]
        public string Output { get; set; }

        [JsonProperty("request")]
        public Request Request { get; set; }

    }
}