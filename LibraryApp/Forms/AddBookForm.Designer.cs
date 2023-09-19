namespace LibraryApp.Forms
{
    partial class AddBookForm
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
            isbnTxt = new TextBox();
            titleTxt = new TextBox();
            authorTxt = new TextBox();
            yearTxt = new TextBox();
            publisherTxt = new TextBox();
            availableCheckBox = new CheckBox();
            AddBtn = new Button();
            isbnError = new Label();
            titleError = new Label();
            authorError = new Label();
            yearError = new Label();
            publisherError = new Label();
            errorMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 28);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 70);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 0;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 117);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 0;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 166);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 0;
            label4.Text = "Year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 211);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 0;
            label5.Text = "Publisher:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 263);
            label6.Name = "label6";
            label6.Size = new Size(96, 25);
            label6.TabIndex = 0;
            label6.Text = "Available:";
            // 
            // isbnTxt
            // 
            isbnTxt.Location = new Point(129, 29);
            isbnTxt.Name = "isbnTxt";
            isbnTxt.Size = new Size(184, 23);
            isbnTxt.TabIndex = 1;
            isbnTxt.Leave += isbnTxt_Leave;
            // 
            // titleTxt
            // 
            titleTxt.Location = new Point(129, 71);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(184, 23);
            titleTxt.TabIndex = 2;
            titleTxt.Leave += titleTxt_Leave;
            // 
            // authorTxt
            // 
            authorTxt.Location = new Point(129, 118);
            authorTxt.Name = "authorTxt";
            authorTxt.Size = new Size(184, 23);
            authorTxt.TabIndex = 3;
            authorTxt.Leave += authorTxt_Leave;
            // 
            // yearTxt
            // 
            yearTxt.Location = new Point(129, 167);
            yearTxt.Name = "yearTxt";
            yearTxt.Size = new Size(184, 23);
            yearTxt.TabIndex = 4;
            yearTxt.Leave += yearTxt_Leave;
            // 
            // publisherTxt
            // 
            publisherTxt.Location = new Point(129, 212);
            publisherTxt.Name = "publisherTxt";
            publisherTxt.Size = new Size(184, 23);
            publisherTxt.TabIndex = 5;
            publisherTxt.Leave += publisherTxt_Leave;
            // 
            // availableCheckBox
            // 
            availableCheckBox.AutoSize = true;
            availableCheckBox.Location = new Point(129, 272);
            availableCheckBox.Name = "availableCheckBox";
            availableCheckBox.Size = new Size(15, 14);
            availableCheckBox.TabIndex = 6;
            availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(69, 326);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(205, 67);
            AddBtn.TabIndex = 7;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click_1;
            // 
            // isbnError
            // 
            isbnError.AutoSize = true;
            isbnError.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            isbnError.ForeColor = Color.Red;
            isbnError.Location = new Point(102, 29);
            isbnError.Name = "isbnError";
            isbnError.Size = new Size(21, 25);
            isbnError.TabIndex = 8;
            isbnError.Text = "*";
            // 
            // titleError
            // 
            titleError.AutoSize = true;
            titleError.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleError.ForeColor = Color.Red;
            titleError.Location = new Point(102, 71);
            titleError.Name = "titleError";
            titleError.Size = new Size(21, 25);
            titleError.TabIndex = 8;
            titleError.Text = "*";
            // 
            // authorError
            // 
            authorError.AutoSize = true;
            authorError.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            authorError.ForeColor = Color.Red;
            authorError.Location = new Point(102, 118);
            authorError.Name = "authorError";
            authorError.Size = new Size(21, 25);
            authorError.TabIndex = 8;
            authorError.Text = "*";
            // 
            // yearError
            // 
            yearError.AutoSize = true;
            yearError.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            yearError.ForeColor = Color.Red;
            yearError.Location = new Point(102, 165);
            yearError.Name = "yearError";
            yearError.Size = new Size(21, 25);
            yearError.TabIndex = 8;
            yearError.Text = "*";
            // 
            // publisherError
            // 
            publisherError.AutoSize = true;
            publisherError.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            publisherError.ForeColor = Color.Red;
            publisherError.Location = new Point(102, 212);
            publisherError.Name = "publisherError";
            publisherError.Size = new Size(21, 25);
            publisherError.TabIndex = 8;
            publisherError.Text = "*";
            // 
            // errorMessage
            // 
            errorMessage.Anchor = AnchorStyles.Left;
            errorMessage.ForeColor = Color.Red;
            errorMessage.Location = new Point(69, 308);
            errorMessage.Name = "errorMessage";
            errorMessage.Size = new Size(205, 15);
            errorMessage.TabIndex = 9;
            errorMessage.TextAlign = ContentAlignment.MiddleCenter;
            errorMessage.Visible = false;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 418);
            Controls.Add(errorMessage);
            Controls.Add(publisherError);
            Controls.Add(yearError);
            Controls.Add(authorError);
            Controls.Add(titleError);
            Controls.Add(isbnError);
            Controls.Add(AddBtn);
            Controls.Add(availableCheckBox);
            Controls.Add(publisherTxt);
            Controls.Add(yearTxt);
            Controls.Add(authorTxt);
            Controls.Add(titleTxt);
            Controls.Add(isbnTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBookForm";
            Text = "AddBookForm";
            Load += AddBookForm_Load;
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
        private TextBox isbnTxt;
        private TextBox titleTxt;
        private TextBox authorTxt;
        private TextBox yearTxt;
        private TextBox publisherTxt;
        private CheckBox availableCheckBox;
        private Button AddBtn;
        private Label isbnError;
        private Label titleError;
        private Label authorError;
        private Label yearError;
        private Label publisherError;
        private Label errorMessage;
    }
}