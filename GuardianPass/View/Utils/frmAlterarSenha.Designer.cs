namespace GuardianPass
{
    partial class frmAlterarSenha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarSenha));
            txtBoxSenhaNovamente = new TextBox();
            label4 = new Label();
            btnVoltar = new Button();
            btnAlterar = new Button();
            cBoxMostrarSenha = new CheckBox();
            txtBoxSenhaNova = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtBoxSenhaAtual = new TextBox();
            label2 = new Label();
            Notificacao = new NotifyIcon(components);
            SuspendLayout();
            // 
            // txtBoxSenhaNovamente
            // 
            txtBoxSenhaNovamente.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxSenhaNovamente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenhaNovamente.ForeColor = Color.White;
            txtBoxSenhaNovamente.Location = new Point(100, 240);
            txtBoxSenhaNovamente.MaxLength = 50;
            txtBoxSenhaNovamente.Name = "txtBoxSenhaNovamente";
            txtBoxSenhaNovamente.PlaceholderText = "Senha Novamente";
            txtBoxSenhaNovamente.Size = new Size(200, 34);
            txtBoxSenhaNovamente.TabIndex = 29;
            txtBoxSenhaNovamente.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(100, 210);
            label4.Name = "label4";
            label4.Size = new Size(205, 31);
            label4.TabIndex = 28;
            label4.Text = "Senha novamente:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(115, 380);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(170, 55);
            btnVoltar.TabIndex = 27;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(0, 180, 216);
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.Location = new Point(115, 320);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(170, 55);
            btnAlterar.TabIndex = 26;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cBoxMostrarSenha.ForeColor = Color.FromArgb(176, 176, 176);
            cBoxMostrarSenha.Location = new Point(120, 285);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(159, 29);
            cBoxMostrarSenha.TabIndex = 25;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // txtBoxSenhaNova
            // 
            txtBoxSenhaNova.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxSenhaNova.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenhaNova.ForeColor = Color.White;
            txtBoxSenhaNova.Location = new Point(100, 170);
            txtBoxSenhaNova.MaxLength = 50;
            txtBoxSenhaNova.Name = "txtBoxSenhaNova";
            txtBoxSenhaNova.PlaceholderText = "Senha";
            txtBoxSenhaNova.Size = new Size(200, 34);
            txtBoxSenhaNova.TabIndex = 24;
            txtBoxSenhaNova.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(176, 176, 176);
            label3.Location = new Point(100, 140);
            label3.Name = "label3";
            label3.Size = new Size(140, 31);
            label3.TabIndex = 23;
            label3.Text = "Senha nova:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(104, 10);
            label1.Name = "label1";
            label1.Size = new Size(192, 38);
            label1.TabIndex = 20;
            label1.Text = "Alterar senha";
            // 
            // txtBoxSenhaAtual
            // 
            txtBoxSenhaAtual.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxSenhaAtual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenhaAtual.ForeColor = Color.White;
            txtBoxSenhaAtual.Location = new Point(100, 100);
            txtBoxSenhaAtual.MaxLength = 50;
            txtBoxSenhaAtual.Name = "txtBoxSenhaAtual";
            txtBoxSenhaAtual.PlaceholderText = "Senha";
            txtBoxSenhaAtual.Size = new Size(200, 34);
            txtBoxSenhaAtual.TabIndex = 31;
            txtBoxSenhaAtual.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(176, 176, 176);
            label2.Location = new Point(100, 70);
            label2.Name = "label2";
            label2.Size = new Size(140, 31);
            label2.TabIndex = 30;
            label2.Text = "Senha atual:";
            // 
            // Notificacao
            // 
            Notificacao.Icon = (Icon)resources.GetObject("Notificacao.Icon");
            Notificacao.Text = "Notificacao";
            Notificacao.Visible = true;
            // 
            // frmAlterarSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(400, 453);
            Controls.Add(txtBoxSenhaAtual);
            Controls.Add(label2);
            Controls.Add(txtBoxSenhaNovamente);
            Controls.Add(label4);
            Controls.Add(btnVoltar);
            Controls.Add(btnAlterar);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(txtBoxSenhaNova);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAlterarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxSenhaNovamente;
        private Label label4;
        private Button btnVoltar;
        private Button btnAlterar;
        private CheckBox cBoxMostrarSenha;
        private TextBox txtBoxSenhaNova;
        private Label label3;
        private Label label1;
        private TextBox txtBoxSenhaAtual;
        private Label label2;
        private NotifyIcon Notificacao;
    }
}