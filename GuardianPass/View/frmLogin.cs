using GuardianPass.Controller;
using GuardianPass.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardianPass
{
    public partial class frmLogin : Form
    {
        LembrarDeMim lembrarDeMim = new LembrarDeMim();
        HashSenha hashSenha = new HashSenha(SHA256.Create());
        Conexao conexao = new Conexao();

        #region Eventos
        public frmLogin()
        {
            InitializeComponent();
            CarregarLembrarDeMim();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            EfetuarLogin();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void cBoxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxSenha.UseSystemPasswordChar = !cBoxMostrarSenha.Checked;
        }

        private void cBoxLembrarDeMim_CheckedChanged(object sender, EventArgs e)
        {
            LembrarDeMim();
        }

        #endregion

        #region Metodos
        public void CarregarLembrarDeMim()
        {
            if (Properties.Settings.Default.Lembrar)
            {
                txtBoxUsuario.Text = Properties.Settings.Default.Usuario;
                txtBoxSenha.Text = Properties.Settings.Default.Senha;
                cBoxLembrarDeMim.Checked = true;
            }
            else
            {
                txtBoxUsuario.Text = "";
                txtBoxSenha.Text = "";
                cBoxLembrarDeMim.Checked = false;
            }
        }

        private void EfetuarLogin()
        {
            if (conexao.Login(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text)))
            {
                PopularDadosUsuario();
                AbrirFomrsMenuPrincipal();
            }
            else
                ExibirMensagemErro("Usuário ou senha inválidos.");
        }

        private void PopularDadosUsuario()
        {
            DadosUsuario user = new DadosUsuario
            {
                Id = conexao.PegarId(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text)),
                Usuario = txtBoxUsuario.Text,
                Senha = txtBoxSenha.Text,
                Exigir = conexao.PegarExigirSenha(txtBoxUsuario.Text, hashSenha.CriptografarSenha(txtBoxSenha.Text))
            };
            user.Salvar(user);
        }

        private void AbrirFomrsMenuPrincipal()
        {
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Close();
        }

        private void ExibirMensagemErro(string erro)
        {
            MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LembrarDeMim()
        {
            if (cBoxLembrarDeMim.Checked)
                lembrarDeMim.Salvar(txtBoxUsuario.Text, txtBoxSenha.Text, cBoxLembrarDeMim.Checked);
            else
                lembrarDeMim.Apagar();
        }

        #endregion
    }
}
