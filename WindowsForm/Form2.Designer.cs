namespace WindowsForm
{
    partial class Form2
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
            FirstNameTxt = new TextBox();
            LastNameTxt = new TextBox();
            CellPhoneTxt = new TextBox();
            AddressTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SaveBtn = new Button();
            SuspendLayout();
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Location = new Point(144, 9);
            FirstNameTxt.Margin = new Padding(3, 2, 3, 2);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(165, 23);
            FirstNameTxt.TabIndex = 0;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Location = new Point(144, 44);
            LastNameTxt.Margin = new Padding(3, 2, 3, 2);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(165, 23);
            LastNameTxt.TabIndex = 0;
            // 
            // CellPhoneTxt
            // 
            CellPhoneTxt.Location = new Point(144, 77);
            CellPhoneTxt.Margin = new Padding(3, 2, 3, 2);
            CellPhoneTxt.Name = "CellPhoneTxt";
            CellPhoneTxt.Size = new Size(165, 23);
            CellPhoneTxt.TabIndex = 0;
            // 
            // AddressTxt
            // 
            AddressTxt.Location = new Point(144, 112);
            AddressTxt.Margin = new Padding(3, 2, 3, 2);
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(165, 23);
            AddressTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 11);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 46);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 80);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 1;
            label3.Text = "CellPhone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 114);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 1;
            label4.Text = "Address";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(39, 153);
            SaveBtn.Margin = new Padding(3, 2, 3, 2);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(270, 45);
            SaveBtn.TabIndex = 2;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 232);
            Controls.Add(SaveBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddressTxt);
            Controls.Add(CellPhoneTxt);
            Controls.Add(LastNameTxt);
            Controls.Add(FirstNameTxt);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Add Person";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstNameTxt;
        private TextBox LastNameTxt;
        private TextBox CellPhoneTxt;
        private TextBox AddressTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SaveBtn;
    }
}