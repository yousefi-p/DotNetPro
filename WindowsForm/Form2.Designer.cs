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
            FirstNameTxt.Location = new Point(165, 12);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(188, 27);
            FirstNameTxt.TabIndex = 0;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Location = new Point(165, 59);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(188, 27);
            LastNameTxt.TabIndex = 0;
            // 
            // CellPhoneTxt
            // 
            CellPhoneTxt.Location = new Point(165, 103);
            CellPhoneTxt.Name = "CellPhoneTxt";
            CellPhoneTxt.Size = new Size(188, 27);
            CellPhoneTxt.TabIndex = 0;
            // 
            // AddressTxt
            // 
            AddressTxt.Location = new Point(165, 149);
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(188, 27);
            AddressTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 15);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 62);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 106);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 1;
            label3.Text = "CellPhone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 152);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 1;
            label4.Text = "Address";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(45, 204);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(308, 60);
            SaveBtn.TabIndex = 2;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 309);
            Controls.Add(SaveBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddressTxt);
            Controls.Add(CellPhoneTxt);
            Controls.Add(LastNameTxt);
            Controls.Add(FirstNameTxt);
            Name = "Form2";
            Text = "Add Person";
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