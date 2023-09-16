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
            dataGridView1 = new DataGridView();
            modifyBtn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.Location = new Point(12, 380);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(233, 40);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add Book";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += booksBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(296, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(683, 475);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // modifyBtn
            // 
            modifyBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            modifyBtn.Location = new Point(12, 426);
            modifyBtn.Name = "modifyBtn";
            modifyBtn.Size = new Size(233, 39);
            modifyBtn.TabIndex = 3;
            modifyBtn.Text = "Modify Book";
            modifyBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(88, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 499);
            Controls.Add(button1);
            Controls.Add(modifyBtn);
            Controls.Add(dataGridView1);
            Controls.Add(addBtn);
            Controls.Add(usersBtn);
            Name = "Form1";
            Text = "Library App";
            Activated += Form1_Activated;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            Leave += Form1_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button usersBtn;
        private Button addBtn;
        private DataGridView dataGridView1;
        private Button modifyBtn;
        private Button button1;
    }
}