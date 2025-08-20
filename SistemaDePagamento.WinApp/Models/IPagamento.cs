namespace SistemaDePagamento.WinApp.Models
{
    public interface IPagamento
    {
        void RealizarPagamento(double valor);
    }
}
