namespace Funcionario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCPF = new TextBox();
            txtEndereco = new TextBox();
            btnPesquisar = new Button();
            label5 = new Label();
            lblId = new Label();
            btnLimpar = new Button();
            btnAtualizar = new Button();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(113, 216);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(103, 32);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(15, 56);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(15, 95);
            label2.Name = "label2";
            label2.Size = new Size(62, 19);
            label2.TabIndex = 3;
            label2.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(15, 135);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 4;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(15, 169);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 5;
            label4.Text = "Endereço:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 9.75F);
            txtNome.Location = new Point(113, 52);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(430, 22);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 9.75F);
            txtEmail.Location = new Point(113, 91);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(430, 22);
            txtEmail.TabIndex = 2;
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Arial", 9.75F);
            txtCPF.Location = new Point(113, 131);
            txtCPF.MaxLength = 11;
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(430, 22);
            txtCPF.TabIndex = 3;
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Arial", 9.75F);
            txtEndereco.Location = new Point(113, 165);
            txtEndereco.MaxLength = 200;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(430, 22);
            txtEndereco.TabIndex = 4;
            // 
            // btnPesquisar
            // 
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPesquisar.Location = new Point(233, 216);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(103, 32);
            btnPesquisar.TabIndex = 6;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 23);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 7;
            label5.Text = "Funcionário Id:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(113, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 15);
            lblId.TabIndex = 8;
            // 
            // btnLimpar
            // 
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(461, 6);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(82, 32);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(354, 216);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(103, 32);
            btnAtualizar.TabIndex = 10;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 314);
            Controls.Add(btnAtualizar);
            Controls.Add(btnLimpar);
            Controls.Add(lblId);
            Controls.Add(label5);
            Controls.Add(btnPesquisar);
            Controls.Add(txtEndereco);
            Controls.Add(txtCPF);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionarios";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCPF;
        private TextBox txtEndereco;
        private Button btnPesquisar;
        private Label label5;
        private Label lblId;
        private Button btnLimpar;
        private Button btnAtualizar;
    }
}
