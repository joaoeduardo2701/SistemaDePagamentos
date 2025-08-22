using Newtonsoft.Json;
using SistemaDePagamento.WinApp.Models;

namespace SistemaDePagamento.WinApp.Forms
{
    public partial class FormBoleto : Form
    {
        public FormBoleto()
        {
            InitializeComponent();

            txtCPF.Mask = "000.000.000-00";
            txtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtCPF.Culture = System.Globalization.CultureInfo.InvariantCulture;
        }

        private void efetuarPagamento_Click(object sender, EventArgs e)
        {
            var nome = textNome.Text.Trim();
            var cpf = txtCPF.Text;
            double valorInput = double.Parse(valorCompra.Text);

            var caminhoArquivo = @"C:\Users\Dudu\source\repos\SistemaDePagamento.WinApp\SistemaDePagamento.WinApp\Data\boleto.json";
            var pixJson = File.ReadAllText(caminhoArquivo);

            List<Boleto> boletos = JsonConvert.DeserializeObject<List<Boleto>>(pixJson)!;

            var encontrado = false;

            foreach (var boleto in boletos)
            {
                if (boleto.CPF == cpf && boleto.Nome == nome)
                {
                    encontrado = true;

                    if (!boleto.RealizarPagamento(valorInput))
                    {
                        break;
                    }

                    MessageBox.Show("Pagamento Efetuado com sucesso");

                    string jsonAlterado = JsonConvert.SerializeObject(boletos, Formatting.Indented);

                    File.WriteAllText(caminhoArquivo, jsonAlterado);

                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Chave Pix não encontrada!");
            }
        }
    }
}
