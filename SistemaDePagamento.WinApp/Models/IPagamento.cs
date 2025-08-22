namespace SistemaDePagamento.WinApp.Models
{
    public interface IPagamento
    {
        bool RealizarPagamento(double valor);
    }
}
