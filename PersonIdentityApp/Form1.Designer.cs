namespace PersonIdentityApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            nameTxtBox = new TextBox();
            familyTxtBox = new TextBox();
            idTxtBox = new TextBox();
            cellPhoneTxtBox = new TextBox();
            genderComboBox = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // nameTxtBox
            // 
            resources.ApplyResources(nameTxtBox, "nameTxtBox");
            nameTxtBox.Name = "nameTxtBox";
            // 
            // familyTxtBox
            // 
            resources.ApplyResources(familyTxtBox, "familyTxtBox");
            familyTxtBox.Name = "familyTxtBox";
            // 
            // idTxtBox
            // 
            resources.ApplyResources(idTxtBox, "idTxtBox");
            idTxtBox.Name = "idTxtBox";
            // 
            // cellPhoneTxtBox
            // 
            resources.ApplyResources(cellPhoneTxtBox, "cellPhoneTxtBox");
            cellPhoneTxtBox.Name = "cellPhoneTxtBox";
            // 
            // genderComboBox
            // 
            resources.ApplyResources(genderComboBox, "genderComboBox");
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Name = "genderComboBox";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(label1);
            Controls.Add(genderComboBox);
            Controls.Add(cellPhoneTxtBox);
            Controls.Add(idTxtBox);
            Controls.Add(familyTxtBox);
            Controls.Add(nameTxtBox);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nameTxtBox;
        private TextBox familyTxtBox;
        private TextBox idTxtBox;
        private TextBox cellPhoneTxtBox;
        private ComboBox genderComboBox;
        private Label label1;
    }
}