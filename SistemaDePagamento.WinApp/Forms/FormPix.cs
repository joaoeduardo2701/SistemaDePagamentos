using Newtonsoft.Json;
using SistemaDePagamento.WinApp.Models;

namespace SistemaDePagamento.WinApp.Forms
{
    public partial class FormPix : Form
    {
        public FormPix()
        {
            InitializeComponent();
        }

        private void efetuarPagamento_Click(object sender, EventArgs e)
        {
            var chave = txtChavePix.Text.Trim();
            double valorInput = double.Parse(valorCompra.Text);

            var caminhoArquivo = @"C:\Users\Dudu\source\repos\SistemaDePagamento.WinApp\SistemaDePagamento.WinApp\Data\pix.json";
            var pixJson = File.ReadAllText(caminhoArquivo);

            List<Pix> chavesPix = JsonConvert.DeserializeObject<List<Pix>>(pixJson)!;

            var encontrado = false;

            foreach (var chavePix in chavesPix)
            {
                if (chavePix.ChavePix == chave)
                {
                    chavePix.RealizarPagamento(valorInput);
                    MessageBox.Show("Pagamento Efetuado com sucesso");

                    string jsonAlterado = JsonConvert.SerializeObject(chavesPix, Formatting.Indented);

                    File.WriteAllText(caminhoArquivo, jsonAlterado);

                    encontrado = true;
                }

            }

            if (!encontrado)
            {
                MessageBox.Show("Chave Pix não encontrada!");
            }

        }
    }
}
