using SistemaDePagamento.WinApp.Forms;

namespace SistemaDePagamento.WinApp
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void EfetuarPagamento_Click(object sender, EventArgs e)
        {
            if (rdbCredito.Checked)
            {
                FormCartaoCredito formCartao = new FormCartaoCredito();
                formCartao.ShowDialog();
            }
            else if (rdbPix.Checked)
            {
                FormPix formPix = new FormPix();
                formPix.ShowDialog();
            }
            else if (rdbBoleto.Checked)
            {
                FormBoleto formBoleto = new FormBoleto();
                formBoleto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um método de pagamento.");
            }
        }
    }
}
