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
            searchTxt = new TextBox();
            groupBox1 = new GroupBox();
            searchBtn = new Button();
            searchCombo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
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
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            modifyBtn.Click += modifyBtn_Click;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(6, 22);
            searchTxt.Name = "searchTxt";
            searchTxt.PlaceholderText = "ex. Java";
            searchTxt.Size = new Size(221, 23);
            searchTxt.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(searchBtn);
            groupBox1.Controls.Add(searchCombo);
            groupBox1.Controls.Add(searchTxt);
            groupBox1.Location = new Point(12, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(233, 168);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // searchBtn
            // 
            searchBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            searchBtn.Location = new Point(6, 109);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(221, 42);
            searchBtn.TabIndex = 6;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchCombo
            // 
            searchCombo.FormattingEnabled = true;
            searchCombo.Location = new Point(6, 66);
            searchCombo.Name = "searchCombo";
            searchCombo.Size = new Size(221, 23);
            searchCombo.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 499);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button usersBtn;
        private Button addBtn;
        private Button modifyBtn;
        private TextBox searchTxt;
        private GroupBox groupBox1;
        private Button searchBtn;
        private ComboBox searchCombo;
        public DataGridView dataGridView1;
    }
}