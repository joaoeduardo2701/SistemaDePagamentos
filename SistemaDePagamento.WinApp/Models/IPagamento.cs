namespace SistemaDePagamento.WinApp.Models
{
    public interface IPagamento
    {
        double RealizarPagamento(double valor);
    }
}
