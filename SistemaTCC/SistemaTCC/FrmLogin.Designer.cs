namespace SistemaTCC
{
    partial class FrmLogin
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
            senha = new Label();
            label2 = new Label();
            txtsenha = new TextBox();
            txtEmail = new TextBox();
            btnAcessar = new Button();
            SuspendLayout();
            // 
            // senha
            // 
            senha.AutoSize = true;
            senha.Location = new Point(51, 37);
            senha.Name = "senha";
            senha.Size = new Size(52, 20);
            senha.TabIndex = 0;
            senha.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 77);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(152, 33);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(125, 27);
            txtsenha.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 3;
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(64, 141);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(94, 29);
            btnAcessar.TabIndex = 4;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAcessar);
            Controls.Add(txtEmail);
            Controls.Add(txtsenha);
            Controls.Add(label2);
            Controls.Add(senha);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label senha;
        private Label label2;
        private TextBox txtsenha;
        private TextBox txtEmail;
        private Button btnAcessar;
    }
}