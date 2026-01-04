using GuardianPass.Data;
using System.Text;

namespace GuardianPass
{
    #region Eventos
    public partial class frmGerarSenha : Form
    {
        private readonly AppDbContext _db;
        public frmGerarSenha(AppDbContext Db)
        {
            InitializeComponent();
            OrganizarValores();
            _db = Db;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            txtBoxSenha.Text = GeradorDeSenha(nupQuantidade.Value, cBoxLetra.Checked, cBoxNumeros.Checked, cBoxSimbolos.Checked);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(_db);
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            CopiarSenha();
        }
        #endregion

        #region Metodos
        public void OrganizarValores()
        {
            nupQuantidade.Value = 12;
            cBoxLetra.Checked = true;
            cBoxNumeros.Checked = true;
            cBoxSimbolos.Checked = true;
        }

        private void ExibirMesagemDeErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool VerificarCaixasDeSelecao(bool usarLetras, bool usarNumeros, bool usarSimbolos)
        {
            if (!usarLetras && !usarNumeros && !usarSimbolos)
            { ExibirMesagemDeErro("Você precisa selecionar pelo menos uma opção."); return true; }
            else
                return false;
        }

        public string GeradorDeSenha(decimal tamanho, bool usarLetras, bool usarNumeros, bool usarSimbolos)
        {
            string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string numeros = "0123456789";
            string simbolos = "!@#$%^&*()-_=+[]{};:,.<>?";
            Random random = new Random();

            if (VerificarCaixasDeSelecao(usarLetras, usarNumeros, usarSimbolos))
                return string.Empty;

            StringBuilder caracteresPossiveis = new StringBuilder();

            if (usarLetras) caracteresPossiveis.Append(letras);
            if (usarNumeros) caracteresPossiveis.Append(numeros);
            if (usarSimbolos) caracteresPossiveis.Append(simbolos);

            StringBuilder senha = new StringBuilder();

            for (int i = 0; i < tamanho; i++)
            {
                int indice = random.Next(caracteresPossiveis.Length);
                senha.Append(caracteresPossiveis[indice]);
            }

            return senha.ToString();
        }

        private void CopiarSenha()
        {
            if (!string.IsNullOrEmpty(txtBoxSenha.Text))
            {
                Clipboard.SetText(txtBoxSenha.Text);
                ExibirMensagemSucesso("Senha copiada!");
            }
            else
                ExibirMensagemErro("Não há senha para copiar.");
        }

        private void ExibirMensagemSucesso(string mensagem)
        {
            Notificacao.Visible = true;

            Notificacao.BalloonTipTitle = "GuardianPass";
            Notificacao.BalloonTipText = mensagem;
            Notificacao.BalloonTipIcon = ToolTipIcon.Info;

            Notificacao.ShowBalloonTip(2000);
        }

        private void ExibirMensagemErro(string mensagem)
        {
            Notificacao.Visible = true;

            Notificacao.BalloonTipTitle = "GuardianPass";
            Notificacao.BalloonTipText = mensagem;
            Notificacao.BalloonTipIcon = ToolTipIcon.Warning;

            Notificacao.ShowBalloonTip(2000);
        }

        #endregion
    }
}