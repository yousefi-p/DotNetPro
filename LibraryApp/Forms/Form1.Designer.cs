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
            addBtn = new Button();
            bookGridView = new DataGridView();
            modifyBtn = new Button();
            userGridData = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)bookGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userGridData).BeginInit();
            SuspendLayout();
            // 
            // usersBtn
            // 
            usersBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            usersBtn.Location = new Point(755, 502);
            usersBtn.Name = "usersBtn";
            usersBtn.Size = new Size(233, 40);
            usersBtn.TabIndex = 3;
            usersBtn.Text = "USERS";
            usersBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.Location = new Point(21, 502);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(233, 40);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add Book";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += booksBtn_Click;
            // 
            // bookGridView
            // 
            bookGridView.AllowUserToAddRows = false;
            bookGridView.AllowUserToDeleteRows = false;
            bookGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookGridView.Location = new Point(21, 43);
            bookGridView.Name = "bookGridView";
            bookGridView.ReadOnly = true;
            bookGridView.RowTemplate.Height = 25;
            bookGridView.Size = new Size(648, 444);
            bookGridView.TabIndex = 2;
            // 
            // modifyBtn
            // 
            modifyBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            modifyBtn.Location = new Point(21, 561);
            modifyBtn.Name = "modifyBtn";
            modifyBtn.Size = new Size(233, 39);
            modifyBtn.TabIndex = 2;
            modifyBtn.Text = "Modify Book";
            modifyBtn.UseVisualStyleBackColor = true;
            // 
            // userGridData
            // 
            userGridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGridData.Location = new Point(689, 43);
            userGridData.Name = "userGridData";
            userGridData.RowTemplate.Height = 25;
            userGridData.Size = new Size(299, 444);
            userGridData.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 5;
            label1.Text = "Books:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(669, 9);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 5;
            label2.Text = "Users:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 637);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(userGridData);
            Controls.Add(modifyBtn);
            Controls.Add(bookGridView);
            Controls.Add(addBtn);
            Controls.Add(usersBtn);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library App";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bookGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)userGridData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button usersBtn;
        private Button addBtn;
        private Button modifyBtn;
        public DataGridView bookGridView;
        private DataGridView userGridData;
        private Label label1;
        private Label label2;
    }
}