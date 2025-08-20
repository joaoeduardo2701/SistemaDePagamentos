using Newtonsoft.Json;

namespace SistemaDePagamento.WinApp.Models
{
    public class Pix : PagamentoBase, IPagamento
    {
        [JsonProperty(Order = 2)]
        public string ChavePix { get; set; }
        [JsonProperty(Order = 3)]
        public double Saldo { get; set; }

        public Pix(string chavePix, double saldo)
        {
            ChavePix = chavePix;
            Saldo = saldo;
        }

        public void RealizarPagamento(double valor)
        {
            if (valor <= 0)
            {
                MessageBox.Show("O valor deve ser maior que zero!");
                return;
            }

            if (Saldo < valor)
            {
                MessageBox.Show("Saldo insuficiente!");
                return;
            }

            Saldo += valor;
        }
    }
}
