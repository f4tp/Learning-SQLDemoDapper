namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.btnInsertPerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailAddInsText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNumInsText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 25;
            this.peopleFoundListbox.Location = new System.Drawing.Point(34, 191);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(310, 229);
            this.peopleFoundListbox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(150, 86);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(194, 31);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(29, 86);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(34, 133);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(310, 37);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search...";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // btnInsertPerson
            // 
            this.btnInsertPerson.Location = new System.Drawing.Point(486, 294);
            this.btnInsertPerson.Name = "btnInsertPerson";
            this.btnInsertPerson.Size = new System.Drawing.Size(310, 37);
            this.btnInsertPerson.TabIndex = 6;
            this.btnInsertPerson.Text = "Search...";
            this.btnInsertPerson.UseVisualStyleBackColor = true;
            this.btnInsertPerson.Click += new System.EventHandler(this.btnInsertPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last Name";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(602, 137);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(194, 31);
            this.lastNameInsText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(602, 83);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(194, 31);
            this.firstNameInsText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email Address";
            // 
            // emailAddInsText
            // 
            this.emailAddInsText.Location = new System.Drawing.Point(602, 186);
            this.emailAddInsText.Name = "emailAddInsText";
            this.emailAddInsText.Size = new System.Drawing.Size(194, 31);
            this.emailAddInsText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone Number";
            // 
            // phoneNumInsText
            // 
            this.phoneNumInsText.Location = new System.Drawing.Point(602, 234);
            this.phoneNumInsText.Name = "phoneNumInsText";
            this.phoneNumInsText.Size = new System.Drawing.Size(194, 31);
            this.phoneNumInsText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Add a person to the DB";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 504);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNumInsText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailAddInsText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.btnInsertPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button btnInsertPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailAddInsText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneNumInsText;
        private System.Windows.Forms.Label label5;
    }
}

