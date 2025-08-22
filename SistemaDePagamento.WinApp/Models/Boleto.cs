using Newtonsoft.Json;

namespace SistemaDePagamento.WinApp.Models
{
    public class Boleto : PagamentoBase, IPagamento
    {
        [JsonProperty(Order = 2)]
        public string Nome { get; set; }

        [JsonProperty(Order = 3)]
        public string CPF { get; set; }

        [JsonProperty(Order = 4)]
        public double Saldo { get; set; }

        public bool RealizarPagamento(double valor)
        {
            if (valor <= 0)
            {
                MessageBox.Show("O valor deve ser maior que zero!");
                return false;
            }

            if (Saldo < valor)
            {
                MessageBox.Show("Saldo insuficiente!");
                return false;
            }

            Saldo += valor;

            return true;
        }
    }
}
