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
            try
            {
                double preco = double.Parse(valorCompra.Text);

                CartaoCredito cartaoCredito = new CartaoCredito(txtNumeroCartao.Text,txtNomeTitular.Text,txtDataValidade.Text, txtCvv.Text, preco);

                cartaoCredito.RealizarPagamento(preco);                 
            }
            catch
            {
                
                MessageBox.Show("Erro ao realizar o pagamento. Verifique os dados informados.", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
