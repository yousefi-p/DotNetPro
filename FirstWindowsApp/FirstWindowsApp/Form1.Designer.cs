namespace FirstWindowsApp
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
            CellPhoneTxtBox = new TextBox();
            saveBtn = new Button();
            Cell = new Label();
            OutputTxtBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Cell Phone";
            // 
            // CellPhoneTxtBox
            // 
            CellPhoneTxtBox.Location = new Point(105, 12);
            CellPhoneTxtBox.Name = "CellPhoneTxtBox";
            CellPhoneTxtBox.Size = new Size(212, 23);
            CellPhoneTxtBox.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(25, 41);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(292, 42);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // Cell
            // 
            Cell.AutoSize = true;
            Cell.Location = new Point(25, 103);
            Cell.Name = "Cell";
            Cell.Size = new Size(68, 15);
            Cell.TabIndex = 0;
            Cell.Text = "Cell Output";
            // 
            // OutputTxtBox
            // 
            OutputTxtBox.Location = new Point(105, 100);
            OutputTxtBox.Name = "OutputTxtBox";
            OutputTxtBox.Size = new Size(212, 23);
            OutputTxtBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 155);
            Controls.Add(saveBtn);
            Controls.Add(OutputTxtBox);
            Controls.Add(CellPhoneTxtBox);
            Controls.Add(Cell);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox CellPhoneTxtBox;
        private Button saveBtn;
        private Label Cell;
        private TextBox OutputTxtBox;
    }
}