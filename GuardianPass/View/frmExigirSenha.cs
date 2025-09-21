using GuardianPass.Controller;
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
    public partial class frmExigirSenha : Form
    {
        DadosApp dadosApp = null;
        DadosUsuario user = new DadosUsuario();

        #region Eventos
        public frmExigirSenha(DadosApp dadosApp)
        {
            this.dadosApp = dadosApp;
            InitializeComponent();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VerificarSenha();
        }

        #endregion

        #region Metodos
        private void VerificarSenha()
        {
            user = user.Carregar();
            if (txtBoxSenha.Text == user.Senha)
                AbrirForms();
            else
                MessageBox.Show("Senha incorreta. Tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AbrirForms()
        {
            frmAdicionar frmAdicionar = new frmAdicionar(dadosApp);
            frmAdicionar.Show();
            this.Close();
        }

        #endregion
    }
}
