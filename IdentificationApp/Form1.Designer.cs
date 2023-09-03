namespace IdentificationApp
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            firstNameTxtBox = new TextBox();
            lastNameTxtBox = new TextBox();
            nationalIdTxtBox = new TextBox();
            cellPhoneTxtBox = new TextBox();
            genderCombo = new ComboBox();
            button1 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            notifyIcon1 = new NotifyIcon(components);
            label6 = new Label();
            count_label = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Yi Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 37);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Yi Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 76);
            label2.Name = "label2";
            label2.Size = new Size(96, 19);
            label2.TabIndex = 0;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Yi Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 115);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 0;
            label3.Text = "National ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Yi Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 153);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 0;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Yi Baiti", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(35, 190);
            label5.Name = "label5";
            label5.Size = new Size(99, 19);
            label5.TabIndex = 0;
            label5.Text = "Cell Phone:";
            // 
            // firstNameTxtBox
            // 
            firstNameTxtBox.Location = new Point(137, 38);
            firstNameTxtBox.Name = "firstNameTxtBox";
            firstNameTxtBox.Size = new Size(167, 23);
            firstNameTxtBox.TabIndex = 1;
            firstNameTxtBox.Leave += firstNameTxtBox_Leave;
            // 
            // lastNameTxtBox
            // 
            lastNameTxtBox.Location = new Point(137, 77);
            lastNameTxtBox.Name = "lastNameTxtBox";
            lastNameTxtBox.Size = new Size(167, 23);
            lastNameTxtBox.TabIndex = 2;
            lastNameTxtBox.Leave += lastNameTxtBox_Leave;
            // 
            // nationalIdTxtBox
            // 
            nationalIdTxtBox.Location = new Point(137, 116);
            nationalIdTxtBox.Name = "nationalIdTxtBox";
            nationalIdTxtBox.Size = new Size(167, 23);
            nationalIdTxtBox.TabIndex = 3;
            nationalIdTxtBox.Leave += nationalIdTxtBox_Leave;
            // 
            // cellPhoneTxtBox
            // 
            cellPhoneTxtBox.Location = new Point(137, 186);
            cellPhoneTxtBox.Name = "cellPhoneTxtBox";
            cellPhoneTxtBox.Size = new Size(167, 23);
            cellPhoneTxtBox.TabIndex = 5;
            // 
            // genderCombo
            // 
            genderCombo.FormattingEnabled = true;
            genderCombo.Items.AddRange(new object[] { "Male", "Female", "Prefer not to say" });
            genderCombo.Location = new Point(137, 154);
            genderCombo.Name = "genderCombo";
            genderCombo.Size = new Size(121, 23);
            genderCombo.TabIndex = 4;
            genderCombo.DragLeave += genderCombo_DragLeave;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(35, 224);
            button1.Name = "button1";
            button1.Size = new Size(269, 43);
            button1.TabIndex = 6;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(137, 289);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 7;
            label6.Text = "Person";
            // 
            // count_label
            // 
            count_label.AutoSize = true;
            count_label.Location = new Point(97, 289);
            count_label.Name = "count_label";
            count_label.Size = new Size(13, 15);
            count_label.TabIndex = 8;
            count_label.Text = "0";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(338, 324);
            Controls.Add(count_label);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(genderCombo);
            Controls.Add(cellPhoneTxtBox);
            Controls.Add(nationalIdTxtBox);
            Controls.Add(lastNameTxtBox);
            Controls.Add(firstNameTxtBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Main";
            Text = "Identify Yourself";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox firstNameTxtBox;
        private TextBox lastNameTxtBox;
        private TextBox nationalIdTxtBox;
        private TextBox cellPhoneTxtBox;
        private ComboBox genderCombo;
        private Button button1;
        private FileSystemWatcher fileSystemWatcher1;
        private NotifyIcon notifyIcon1;
        private Label count_label;
        private Label label6;
    }
}