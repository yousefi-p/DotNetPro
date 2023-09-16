namespace LibraryApp
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
            usersBtn = new Button();
            booksBtn = new Button();
            SuspendLayout();
            // 
            // usersBtn
            // 
            usersBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            usersBtn.Location = new Point(12, 12);
            usersBtn.Name = "usersBtn";
            usersBtn.Size = new Size(233, 70);
            usersBtn.TabIndex = 0;
            usersBtn.Text = "USERS";
            usersBtn.UseVisualStyleBackColor = true;
            // 
            // booksBtn
            // 
            booksBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            booksBtn.Location = new Point(12, 103);
            booksBtn.Name = "booksBtn";
            booksBtn.Size = new Size(233, 70);
            booksBtn.TabIndex = 1;
            booksBtn.Text = "BOOKS";
            booksBtn.UseVisualStyleBackColor = true;
            booksBtn.Click += booksBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 194);
            Controls.Add(booksBtn);
            Controls.Add(usersBtn);
            Name = "Form1";
            Text = "Library App";
            ResumeLayout(false);
        }

        #endregion

        private Button usersBtn;
        private Button booksBtn;
    }
}