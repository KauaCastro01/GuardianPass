namespace GuardianPass
{
    partial class frmGerarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerarSenha));
            txtBoxSenha = new TextBox();
            label4 = new Label();
            btnVoltar = new Button();
            btnGerar = new Button();
            cBoxLetra = new CheckBox();
            label1 = new Label();
            cBoxNumeros = new CheckBox();
            cBoxSimbolos = new CheckBox();
            nupQuantidade = new NumericUpDown();
            btnCopiar = new Button();
            Notificacao = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)nupQuantidade).BeginInit();
            SuspendLayout();
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.BackColor = Color.FromArgb(27, 38, 59);
            txtBoxSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSenha.ForeColor = Color.White;
            txtBoxSenha.Location = new Point(70, 100);
            txtBoxSenha.MaxLength = 50;
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PlaceholderText = "Senha";
            txtBoxSenha.ReadOnly = true;
            txtBoxSenha.Size = new Size(200, 34);
            txtBoxSenha.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(176, 176, 176);
            label4.Location = new Point(70, 70);
            label4.Name = "label4";
            label4.Size = new Size(156, 31);
            label4.TabIndex = 24;
            label4.Text = "Senha gerada";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(181, 23, 30);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(100, 360);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(200, 55);
            btnVoltar.TabIndex = 23;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnGerar
            // 
            btnGerar.BackColor = Color.FromArgb(0, 180, 216);
            btnGerar.FlatAppearance.BorderSize = 0;
            btnGerar.FlatStyle = FlatStyle.Flat;
            btnGerar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerar.Image = (Image)resources.GetObject("btnGerar.Image");
            btnGerar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGerar.Location = new Point(100, 240);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(200, 55);
            btnGerar.TabIndex = 22;
            btnGerar.Text = "Gerar senha";
            btnGerar.UseVisualStyleBackColor = false;
            btnGerar.Click += btnGerar_Click;
            // 
            // cBoxLetra
            // 
            cBoxLetra.AutoSize = true;
            cBoxLetra.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cBoxLetra.ForeColor = Color.FromArgb(176, 176, 176);
            cBoxLetra.Location = new Point(70, 140);
            cBoxLetra.Name = "cBoxLetra";
            cBoxLetra.Size = new Size(85, 29);
            cBoxLetra.TabIndex = 21;
            cBoxLetra.Text = "Letras";
            cBoxLetra.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 10);
            label1.Name = "label1";
            label1.Size = new Size(258, 38);
            label1.TabIndex = 27;
            label1.Text = "Criar senha segura";
            // 
            // cBoxNumeros
            // 
            cBoxNumeros.AutoSize = true;
            cBoxNumeros.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cBoxNumeros.ForeColor = Color.FromArgb(176, 176, 176);
            cBoxNumeros.Location = new Point(70, 170);
            cBoxNumeros.Name = "cBoxNumeros";
            cBoxNumeros.Size = new Size(113, 29);
            cBoxNumeros.TabIndex = 28;
            cBoxNumeros.Text = "Números";
            cBoxNumeros.UseVisualStyleBackColor = true;
            // 
            // cBoxSimbolos
            // 
            cBoxSimbolos.AutoSize = true;
            cBoxSimbolos.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cBoxSimbolos.ForeColor = Color.FromArgb(176, 176, 176);
            cBoxSimbolos.Location = new Point(70, 200);
            cBoxSimbolos.Name = "cBoxSimbolos";
            cBoxSimbolos.Size = new Size(112, 29);
            cBoxSimbolos.TabIndex = 29;
            cBoxSimbolos.Text = "Símbolos";
            cBoxSimbolos.UseVisualStyleBackColor = true;
            // 
            // nupQuantidade
            // 
            nupQuantidade.BackColor = Color.FromArgb(27, 38, 59);
            nupQuantidade.Font = new Font("Segoe UI", 12F);
            nupQuantidade.ForeColor = Color.White;
            nupQuantidade.Location = new Point(276, 100);
            nupQuantidade.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nupQuantidade.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            nupQuantidade.Name = "nupQuantidade";
            nupQuantidade.ReadOnly = true;
            nupQuantidade.Size = new Size(50, 34);
            nupQuantidade.TabIndex = 30;
            nupQuantidade.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // btnCopiar
            // 
            btnCopiar.BackColor = Color.FromArgb(0, 180, 216);
            btnCopiar.FlatAppearance.BorderSize = 0;
            btnCopiar.FlatStyle = FlatStyle.Flat;
            btnCopiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopiar.Image = (Image)resources.GetObject("btnCopiar.Image");
            btnCopiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCopiar.Location = new Point(100, 300);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(200, 55);
            btnCopiar.TabIndex = 31;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = false;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // Notificacao
            // 
            Notificacao.Icon = (Icon)resources.GetObject("Notificacao.Icon");
            Notificacao.Text = "Notificacao";
            Notificacao.Visible = true;
            // 
            // frmGerarSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(400, 453);
            Controls.Add(btnCopiar);
            Controls.Add(nupQuantidade);
            Controls.Add(cBoxSimbolos);
            Controls.Add(cBoxNumeros);
            Controls.Add(label1);
            Controls.Add(txtBoxSenha);
            Controls.Add(label4);
            Controls.Add(btnVoltar);
            Controls.Add(btnGerar);
            Controls.Add(cBoxLetra);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmGerarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuardianPass";
            ((System.ComponentModel.ISupportInitialize)nupQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxSenha;
        private Label label4;
        private Button btnVoltar;
        private Button btnGerar;
        private CheckBox cBoxLetra;
        private Label label1;
        private CheckBox cBoxNumeros;
        private CheckBox cBoxSimbolos;
        private NumericUpDown nupQuantidade;
        private Button btnCopiar;
        private NotifyIcon Notificacao;
    }
}