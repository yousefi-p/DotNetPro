namespace LibraryApp.Forms
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
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            loginBtn = new Button();
            errorLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 36);
            label1.Name = "label1";
            label1.Size = new Size(131, 24);
            label1.TabIndex = 0;
            label1.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 83);
            label2.Name = "label2";
            label2.Size = new Size(126, 24);
            label2.TabIndex = 1;
            label2.Text = "Password: ";
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(172, 41);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(217, 23);
            usernameTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(172, 84);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(217, 23);
            passwordTxt.TabIndex = 3;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.GradientActiveCaption;
            loginBtn.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = SystemColors.MenuHighlight;
            loginBtn.Location = new Point(172, 125);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(217, 37);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // errorLbl
            // 
            errorLbl.AutoSize = true;
            errorLbl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            errorLbl.ForeColor = Color.Red;
            errorLbl.Location = new Point(35, 9);
            errorLbl.Name = "errorLbl";
            errorLbl.Size = new Size(0, 25);
            errorLbl.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(438, 228);
            Controls.Add(errorLbl);
            Controls.Add(loginBtn);
            Controls.Add(passwordTxt);
            Controls.Add(usernameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Log into Library App";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Button loginBtn;
        private Label errorLbl;
    }
}