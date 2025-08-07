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
        }
    }
}
