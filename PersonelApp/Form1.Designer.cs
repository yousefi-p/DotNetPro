namespace PersonelApp
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
            label1 = new Label();
            FirstNameTxt = new TextBox();
            label2 = new Label();
            LastNameTxt = new TextBox();
            label3 = new Label();
            CellPhoneTxt = new TextBox();
            label4 = new Label();
            NationalIdTxt = new TextBox();
            label5 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            SaveBtn = new Button();
            ShowBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            label1.Click += label1_Click;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Location = new Point(128, 27);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.PlaceholderText = "Ex: Parham";
            FirstNameTxt.Size = new Size(197, 27);
            FirstNameTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 81);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Last Name:";
            label2.Click += label1_Click;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Location = new Point(128, 78);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.PlaceholderText = "Ex: Darvishi";
            LastNameTxt.Size = new Size(197, 27);
            LastNameTxt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 132);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 0;
            label3.Text = "Cell Phone:";
            label3.Click += label1_Click;
            // 
            // CellPhoneTxt
            // 
            CellPhoneTxt.Location = new Point(128, 129);
            CellPhoneTxt.Name = "CellPhoneTxt";
            CellPhoneTxt.PlaceholderText = "Ex: 09121234567";
            CellPhoneTxt.Size = new Size(197, 27);
            CellPhoneTxt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 182);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 0;
            label4.Text = "National ID:";
            label4.Click += label1_Click;
            // 
            // NationalIdTxt
            // 
            NationalIdTxt.Location = new Point(128, 179);
            NationalIdTxt.Name = "NationalIdTxt";
            NationalIdTxt.PlaceholderText = "Ex: 001234567";
            NationalIdTxt.Size = new Size(197, 27);
            NationalIdTxt.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 236);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 0;
            label5.Text = "Gender:";
            label5.Click += label1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(262, 234);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(128, 234);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(25, 278);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(300, 55);
            SaveBtn.TabIndex = 5;
            SaveBtn.Text = "Save!";
            SaveBtn.UseVisualStyleBackColor = true;
            // 
            // ShowBtn
            // 
            ShowBtn.Location = new Point(25, 355);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(300, 55);
            ShowBtn.TabIndex = 5;
            ShowBtn.Text = "Show";
            ShowBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 463);
            Controls.Add(ShowBtn);
            Controls.Add(SaveBtn);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(label5);
            Controls.Add(NationalIdTxt);
            Controls.Add(label4);
            Controls.Add(CellPhoneTxt);
            Controls.Add(label3);
            Controls.Add(LastNameTxt);
            Controls.Add(label2);
            Controls.Add(FirstNameTxt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FirstNameTxt;
        private Label label2;
        private TextBox LastNameTxt;
        private Label label3;
        private TextBox CellPhoneTxt;
        private Label label4;
        private TextBox NationalIdTxt;
        private Label label5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button SaveBtn;
        private Button ShowBtn;
    }
}