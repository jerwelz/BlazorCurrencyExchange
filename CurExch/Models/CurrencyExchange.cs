using System.Text.Json.Serialization;

namespace CurExch.Models
{
    public class CurrencyExchange
    {
        [JsonPropertyName("date")]
        public string? Date { get; set; }

        [JsonPropertyName("base")]
        public string? Base { get; set; }

        [JsonPropertyName("quote")]
        public string? Quote { get; set; }

        [JsonPropertyName("rate")]
        public decimal Rate { get; set; }
    }
}
