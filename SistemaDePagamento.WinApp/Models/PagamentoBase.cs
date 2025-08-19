using Newtonsoft.Json;

namespace SistemaDePagamento.WinApp.Models
{
    public class PagamentoBase
    {
        [JsonProperty(Order = 1)]
        public int Id { get; set; }
        [JsonIgnore]
        public double ValorCompra { get; set; }
    }
}
