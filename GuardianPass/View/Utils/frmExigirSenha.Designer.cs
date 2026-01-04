namespace GuardianPass
{
    partial class frmExigirSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExigirSenha));
            txtBoxSenha = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnEntrar = new Button();
            btnVoltar = new Button();
            cBoxMostrarSenha = new CheckBox();
            Notificacao = new NotifyIcon(components);
            SuspendLayout();
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenha.ForeColor = Color.White;
            txtBoxSenha.Location = new Point(100, 90);
            txtBoxSenha.MaxLength = 50;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Senha";
            txtBoxSenha.Size = new Size(200, 34);
            txtBoxSenha.TabIndex = 15;
            txtBoxSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(176, 176, 176);
            label3.Location = new Point(100, 60);
            label3.Name = "label3";
            label3.Size = new Size(83, 31);
            label3.TabIndex = 14;
            label3.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 10);
            label1.Name = "label1";
            label1.Size = new Size(267, 38);
            label1.TabIndex = 16;
            label1.Text = "Informe Sua Senha";
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(0, 180, 216);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Image = (Image)resources.GetObject("btnEntrar.Image");
            btnEntrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntrar.Location = new Point(112, 165);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(175, 55);
            btnEntrar.TabIndex = 22;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(112, 225);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(175, 55);
            btnVoltar.TabIndex = 21;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // cBoxMostrarSenha
            // 
            cBoxMostrarSenha.AutoSize = true;
            cBoxMostrarSenha.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cBoxMostrarSenha.ForeColor = Color.FromArgb(176, 176, 176);
            cBoxMostrarSenha.Location = new Point(120, 130);
            cBoxMostrarSenha.Name = "cBoxMostrarSenha";
            cBoxMostrarSenha.Size = new Size(159, 29);
            cBoxMostrarSenha.TabIndex = 23;
            cBoxMostrarSenha.Text = "Mostrar Senha";
            cBoxMostrarSenha.UseVisualStyleBackColor = true;
            cBoxMostrarSenha.CheckedChanged += cBoxMostrarSenha_CheckedChanged;
            // 
            // Notificacao
            // 
            Notificacao.Text = "Notificacao";
            Notificacao.Visible = true;
            // 
            // frmExigirSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(400, 303);
            Controls.Add(cBoxMostrarSenha);
            Controls.Add(btnEntrar);
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Controls.Add(txtBoxSenha);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmExigirSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianPass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxSenha;
        private Label label3;
        private Label label1;
        private Button btnEntrar;
        private Button btnVoltar;
        private CheckBox cBoxMostrarSenha;
        private NotifyIcon Notificacao;
    }
}