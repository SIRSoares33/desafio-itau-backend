using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using DesafioItau.DataAnotations;

namespace DesafioItau.Models
{
    public class Transacao
    {
        [JsonPropertyName("valor")]
        [Required]
        [NotNegative]
        public decimal Valor { get; set; }

        [JsonPropertyName("dataHora")]
        [Required]
        [InPast]
        public DateTime DataHora { get; set; }
    }
}