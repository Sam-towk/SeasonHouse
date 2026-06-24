namespace seasonPlusHouse
{
    partial class LoginView
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
            btLogin = new Button();
            btRegistrar = new Button();
            txtUser = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.Location = new Point(153, 281);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(100, 26);
            btLogin.TabIndex = 0;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            // 
            // btRegistrar
            // 
            btRegistrar.Location = new Point(153, 331);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(100, 26);
            btRegistrar.TabIndex = 1;
            btRegistrar.Text = "Registrar";
            btRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(100, 124);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(201, 23);
            txtUser.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(100, 190);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(201, 23);
            txtSenha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 106);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(100, 172);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(401, 402);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            Controls.Add(btRegistrar);
            Controls.Add(btLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLogin;
        private Button btRegistrar;
        private TextBox txtUser;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
    }
}
