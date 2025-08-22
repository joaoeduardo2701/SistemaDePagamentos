using Newtonsoft.Json;

namespace SistemaDePagamento.WinApp.Models
{
    public class CartaoCredito : PagamentoBase, IPagamento
    {
        [JsonProperty(Order = 2)]
        public string NumeroCartao { get; set; }

        [JsonProperty(Order = 3)]
        public string NomeTitular { get; set; }

        [JsonProperty(Order = 4)]
        public string DataValidade { get; set; }

        [JsonProperty(Order = 5)]
        public string Cvv { get; set; }

        [JsonProperty(Order = 6)]
        public double Limite { get; set; }

        public CartaoCredito(string numeroCartao, string nomeTitular, string dataValidade, string cvv, double limite, double valorCompra)
        {
            NumeroCartao = numeroCartao;
            NomeTitular = nomeTitular;
            DataValidade = dataValidade;
            Cvv = cvv;
            Limite = limite;
            ValorCompra = valorCompra;
        }

        public bool RealizarPagamento(double valor)
        {
            if (valor <= 0)
            {
                MessageBox.Show("O valor deve ser maior que zero!");
                return false;
            }

            if (Limite < valor)
            {
                MessageBox.Show("Limite insuficiente!");
                return false;
            }

            Limite -= valor;

            return true;
        }
    }
}
