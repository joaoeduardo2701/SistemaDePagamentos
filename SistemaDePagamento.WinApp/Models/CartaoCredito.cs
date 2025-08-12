namespace SistemaDePagamento.WinApp.Models
{
    public class CartaoCredito : MetodoPagamento
    {
        public string NumeroCartao { get; set; }
        public string NomeTitular { get; set; }
        public string DataValidade { get; set; }
        public string Cvv { get; set; }

        public CartaoCredito(string numeroCartao, string nomeTitular, string dataValidade, string cvv, double valorCompra)
        {
            NumeroCartao = numeroCartao;
            NomeTitular = nomeTitular;
            DataValidade = dataValidade;
            Cvv = cvv;
            ValorCompra = valorCompra;
        }

        public double RealizarPagamento(double valor)
        {
            throw new NotImplementedException();
        }
    }
}
