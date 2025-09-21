using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardianPass
{
    public partial class frmGerarSenha : Form
    {
        #region Eventos
        public frmGerarSenha()
        {
            InitializeComponent();
            OrganizarValores();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            txtBoxSenha.Text = GeradorDeSenha(nupQuantidade.Value, cBoxLetra.Checked, cBoxNumeros.Checked, cBoxSimbolos.Checked);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
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
                MessageBox.Show("Senha copiada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Não há senha para copiar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion
    }
}
