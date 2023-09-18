namespace LibraryApp.Forms
{
    partial class UserForm
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
            bookDataGrid = new DataGridView();
            searchTxt = new TextBox();
            searchBtn = new Button();
            takeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).BeginInit();
            SuspendLayout();
            // 
            // bookDataGrid
            // 
            bookDataGrid.AllowUserToAddRows = false;
            bookDataGrid.AllowUserToDeleteRows = false;
            bookDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDataGrid.Location = new Point(26, 25);
            bookDataGrid.Name = "bookDataGrid";
            bookDataGrid.ReadOnly = true;
            bookDataGrid.RowTemplate.Height = 25;
            bookDataGrid.Size = new Size(744, 361);
            bookDataGrid.TabIndex = 0;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(516, 411);
            searchTxt.Name = "searchTxt";
            searchTxt.PlaceholderText = "Title of the Book";
            searchTxt.Size = new Size(237, 23);
            searchTxt.TabIndex = 1;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(516, 440);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(237, 44);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // takeBtn
            // 
            takeBtn.Location = new Point(65, 411);
            takeBtn.Name = "takeBtn";
            takeBtn.Size = new Size(221, 73);
            takeBtn.TabIndex = 3;
            takeBtn.Text = "Take the Book";
            takeBtn.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 554);
            Controls.Add(takeBtn);
            Controls.Add(searchBtn);
            Controls.Add(searchTxt);
            Controls.Add(bookDataGrid);
            Name = "UserForm";
            Text = "Library App";
            FormClosed += UserForm_FormClosed;
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)bookDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView bookDataGrid;
        private TextBox searchTxt;
        private Button searchBtn;
        private Button takeBtn;
    }
}