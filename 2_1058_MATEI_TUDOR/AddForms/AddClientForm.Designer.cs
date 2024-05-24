namespace _2_1058_MATEI_TUDOR.AddForms
{
    partial class AddClientForm
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
            this.numeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeLabel
            // 
            this.numeLabel.AutoSize = true;
            this.numeLabel.BackColor = System.Drawing.Color.Lavender;
            this.numeLabel.Location = new System.Drawing.Point(12, 39);
            this.numeLabel.Name = "numeLabel";
            this.numeLabel.Size = new System.Drawing.Size(35, 13);
            this.numeLabel.TabIndex = 2;
            this.numeLabel.Text = "Nume";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Lavender;
            this.emailLabel.Location = new System.Drawing.Point(12, 78);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.BackColor = System.Drawing.Color.Lavender;
            this.telefonLabel.Location = new System.Drawing.Point(12, 113);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(43, 13);
            this.telefonLabel.TabIndex = 4;
            this.telefonLabel.Text = "Telefon";
            // 
            // numeTextBox
            // 
            this.numeTextBox.BackColor = System.Drawing.Color.Lavender;
            this.numeTextBox.Location = new System.Drawing.Point(65, 36);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(228, 20);
            this.numeTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.Lavender;
            this.emailTextBox.Location = new System.Drawing.Point(65, 75);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(228, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.BackColor = System.Drawing.Color.Lavender;
            this.telefonTextBox.Location = new System.Drawing.Point(65, 110);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(228, 20);
            this.telefonTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lavender;
            this.saveButton.Location = new System.Drawing.Point(218, 152);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(305, 197);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.numeTextBox);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.numeLabel);
            this.Name = "AddClientForm";
            this.Text = "AddClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label numeLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}