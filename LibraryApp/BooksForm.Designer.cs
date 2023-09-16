namespace LibraryApp
{
    partial class BooksForm
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
            addBtn = new Button();
            publisherTxt = new TextBox();
            label6 = new Label();
            yearTxt = new TextBox();
            label5 = new Label();
            authorTxt = new TextBox();
            label4 = new Label();
            titileTxt = new TextBox();
            label3 = new Label();
            isbnTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.Location = new Point(36, 350);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(255, 50);
            addBtn.TabIndex = 6;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click_1;
            // 
            // publisherTxt
            // 
            publisherTxt.Location = new Point(126, 295);
            publisherTxt.Name = "publisherTxt";
            publisherTxt.PlaceholderText = "Packt Publishing";
            publisherTxt.Size = new Size(165, 23);
            publisherTxt.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(27, 294);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 21;
            label6.Text = "Publisher:";
            // 
            // yearTxt
            // 
            yearTxt.Location = new Point(126, 241);
            yearTxt.MaxLength = 4;
            yearTxt.Name = "yearTxt";
            yearTxt.PlaceholderText = "2023";
            yearTxt.Size = new Size(165, 23);
            yearTxt.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(36, 240);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 19;
            label5.Text = "Year:";
            // 
            // authorTxt
            // 
            authorTxt.Location = new Point(126, 189);
            authorTxt.Name = "authorTxt";
            authorTxt.PlaceholderText = "Andrew Stellman";
            authorTxt.Size = new Size(165, 23);
            authorTxt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 188);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 17;
            label4.Text = "Author";
            // 
            // titileTxt
            // 
            titileTxt.Location = new Point(126, 138);
            titileTxt.Name = "titileTxt";
            titileTxt.PlaceholderText = "Java Programming";
            titileTxt.Size = new Size(165, 23);
            titileTxt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 137);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 15;
            label3.Text = "Title:";
            // 
            // isbnTxt
            // 
            isbnTxt.Location = new Point(126, 89);
            isbnTxt.MaxLength = 10;
            isbnTxt.Name = "isbnTxt";
            isbnTxt.PlaceholderText = "135689756";
            isbnTxt.Size = new Size(165, 23);
            isbnTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 88);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 13;
            label2.Text = "ISBN:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(115, 26);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 12;
            label1.Text = "Books";
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 466);
            Controls.Add(addBtn);
            Controls.Add(publisherTxt);
            Controls.Add(label6);
            Controls.Add(yearTxt);
            Controls.Add(label5);
            Controls.Add(authorTxt);
            Controls.Add(label4);
            Controls.Add(titileTxt);
            Controls.Add(label3);
            Controls.Add(isbnTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BooksForm";
            Text = "BooksForm";
            FormClosed += BooksForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addBtn;
        private TextBox publisherTxt;
        private Label label6;
        private TextBox yearTxt;
        private Label label5;
        private TextBox authorTxt;
        private Label label4;
        private TextBox titileTxt;
        private Label label3;
        private TextBox isbnTxt;
        private Label label2;
        private Label label1;
    }
}