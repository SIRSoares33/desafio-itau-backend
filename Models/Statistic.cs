using System.Text.Json.Serialization;

namespace DesafioItau.Models
{
    public class StatisticModel
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
        [JsonPropertyName("sum")]
        public decimal Sum { get; set; }
        [JsonPropertyName("avg")]
        public decimal Avg { get; set; }
        [JsonPropertyName("min")]
        public decimal Min { get; set; }
        [JsonPropertyName("max")]
        public decimal Max { get; set; }
    }
}