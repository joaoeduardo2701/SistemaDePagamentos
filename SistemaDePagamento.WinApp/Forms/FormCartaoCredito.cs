using Newtonsoft.Json;
using SistemaDePagamento.WinApp.Models;

namespace SistemaDePagamento.WinApp
{
    public partial class FormCartaoCredito : Form
    {
        public FormCartaoCredito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numCartaoInput = txtNumeroCartao.Text.Replace(" ", ""); 
            string nomeInput = txtNomeTitular.Text.Trim();
            string dataValInput = txtDataValidade.Text.Trim();
            string cvvInput = txtCvv.Text.Trim();
            double valorInput = double.Parse(valorCompra.Text);

            var caminhoArquivo = @"C:\Users\Dudu\source\repos\SistemaDePagamento.WinApp\SistemaDePagamento.WinApp\Data\cartaoCredito.json";
            var cartaoCreditoJson = File.ReadAllText(caminhoArquivo);

            List<CartaoCredito> cartoes = JsonConvert.DeserializeObject<List<CartaoCredito>>(cartaoCreditoJson)!;

            var encontrado = false;

            foreach (var cartao in cartoes)
            {
                string numCartaoJson = cartao.NumeroCartao?.Replace(" ", "") ?? "";
                string titularJson = cartao.NomeTitular?.Trim() ?? "";
                string validadeJson = cartao.DataValidade?.Trim() ?? "";
                string cvvJson = cartao.Cvv?.Trim() ?? "";

                if (numCartaoJson == numCartaoInput && titularJson == nomeInput && validadeJson == dataValInput && cvvJson == cvvInput)
                {
                    encontrado = true;

                    if (cartao.Limite < cartao.ValorCompra)
                    {
                        MessageBox.Show("Limite da conta insuficiente!");
                        break;  
                    }

                    cartao.ValorCompra = valorInput;

                    cartao.RealizarPagamento(double.Parse(valorCompra.Text));

                    string jsonAlterado = JsonConvert.SerializeObject(cartoes, Formatting.Indented);

                    break;
                }
            }

            if (encontrado)
            {
                string jsonAlterado = JsonConvert.SerializeObject(cartoes, Formatting.Indented);
                File.WriteAllText(caminhoArquivo, jsonAlterado);

                MessageBox.Show("Pagamento autorizado!");
               
            }
            else
            {
                MessageBox.Show("Dados não encontrados ou não batem!");
            }
        }
    }
}
