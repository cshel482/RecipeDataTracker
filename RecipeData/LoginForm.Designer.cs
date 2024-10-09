namespace RecipeData
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtUsername = new TextBox();
            lblError = new Label();
            BtnLogin = new Button();
            BtnCreateAccount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 0;
            label1.Text = "Please Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 63);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 230);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 188);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 150);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 4;
            label5.Text = "Username:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 108);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 5;
            label6.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(207, 60);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(207, 102);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(207, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 8;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(207, 230);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(150, 31);
            txtConfirmPassword.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(207, 144);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 31);
            txtUsername.TabIndex = 10;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(28, 279);
            lblError.Name = "lblError";
            lblError.Size = new Size(59, 25);
            lblError.TabIndex = 11;
            lblError.Text = "label7";
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(28, 323);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(112, 34);
            BtnLogin.TabIndex = 12;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnCreateAccount
            // 
            BtnCreateAccount.Location = new Point(190, 323);
            BtnCreateAccount.Name = "BtnCreateAccount";
            BtnCreateAccount.Size = new Size(167, 34);
            BtnCreateAccount.TabIndex = 13;
            BtnCreateAccount.Text = "Create Account";
            BtnCreateAccount.UseVisualStyleBackColor = true;
            BtnCreateAccount.Click += BtnCreateAccount_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCreateAccount);
            Controls.Add(BtnLogin);
            Controls.Add(lblError);
            Controls.Add(txtUsername);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtUsername;
        private Label lblError;
        private Button BtnLogin;
        private Button BtnCreateAccount;
    }
}