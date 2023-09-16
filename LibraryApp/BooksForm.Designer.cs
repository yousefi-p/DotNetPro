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
            splitContainer1 = new SplitContainer();
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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(addBtn);
            splitContainer1.Panel1.Controls.Add(publisherTxt);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(yearTxt);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(authorTxt);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(titileTxt);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(isbnTxt);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(845, 450);
            splitContainer1.SplitterDistance = 281;
            splitContainer1.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.Location = new Point(12, 333);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(255, 50);
            addBtn.TabIndex = 11;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // publisherTxt
            // 
            publisherTxt.Location = new Point(102, 278);
            publisherTxt.Name = "publisherTxt";
            publisherTxt.Size = new Size(165, 23);
            publisherTxt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 277);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 9;
            label6.Text = "Publisher:";
            // 
            // yearTxt
            // 
            yearTxt.Location = new Point(102, 224);
            yearTxt.Name = "yearTxt";
            yearTxt.Size = new Size(165, 23);
            yearTxt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 223);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 7;
            label5.Text = "Year:";
            // 
            // authorTxt
            // 
            authorTxt.Location = new Point(102, 172);
            authorTxt.Name = "authorTxt";
            authorTxt.Size = new Size(165, 23);
            authorTxt.TabIndex = 6;
            authorTxt.TextChanged += authorTxt_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 5;
            label4.Text = "Author";
            // 
            // titileTxt
            // 
            titileTxt.Location = new Point(102, 121);
            titileTxt.Name = "titileTxt";
            titileTxt.Size = new Size(165, 23);
            titileTxt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 3;
            label3.Text = "Title:";
            // 
            // isbnTxt
            // 
            isbnTxt.Location = new Point(102, 72);
            isbnTxt.Name = "isbnTxt";
            isbnTxt.Size = new Size(165, 23);
            isbnTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 1;
            label2.Text = "ISBN:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 28);
            label1.TabIndex = 0;
            label1.Text = "Books";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(534, 393);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 450);
            Controls.Add(splitContainer1);
            Name = "BooksForm";
            Text = "BooksForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label3;
        private TextBox isbnTxt;
        private Label label2;
        private Label label1;
        private TextBox authorTxt;
        private Label label4;
        private TextBox titileTxt;
        private TextBox publisherTxt;
        private Label label6;
        private TextBox yearTxt;
        private Label label5;
        private Button addBtn;
        private DataGridView dataGridView1;
    }
}