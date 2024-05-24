namespace _2_1058_MATEI_TUDOR.AddForms
{
    partial class AddFilmForm
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
            this.titluLabel = new System.Windows.Forms.Label();
            this.genLabel = new System.Windows.Forms.Label();
            this.anLansareLabel = new System.Windows.Forms.Label();
            this.titluTextBox = new System.Windows.Forms.TextBox();
            this.genTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.anLansareNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.anLansareNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titluLabel
            // 
            this.titluLabel.AutoSize = true;
            this.titluLabel.BackColor = System.Drawing.Color.Lavender;
            this.titluLabel.Location = new System.Drawing.Point(12, 43);
            this.titluLabel.Name = "titluLabel";
            this.titluLabel.Size = new System.Drawing.Size(27, 13);
            this.titluLabel.TabIndex = 1;
            this.titluLabel.Text = "Titlu";
            // 
            // genLabel
            // 
            this.genLabel.AutoSize = true;
            this.genLabel.BackColor = System.Drawing.Color.Lavender;
            this.genLabel.Location = new System.Drawing.Point(12, 82);
            this.genLabel.Name = "genLabel";
            this.genLabel.Size = new System.Drawing.Size(27, 13);
            this.genLabel.TabIndex = 2;
            this.genLabel.Text = "Gen";
            // 
            // anLansareLabel
            // 
            this.anLansareLabel.AutoSize = true;
            this.anLansareLabel.BackColor = System.Drawing.Color.Lavender;
            this.anLansareLabel.Location = new System.Drawing.Point(12, 123);
            this.anLansareLabel.Name = "anLansareLabel";
            this.anLansareLabel.Size = new System.Drawing.Size(61, 13);
            this.anLansareLabel.TabIndex = 3;
            this.anLansareLabel.Text = "An Lansare";
            // 
            // titluTextBox
            // 
            this.titluTextBox.BackColor = System.Drawing.Color.Lavender;
            this.titluTextBox.Location = new System.Drawing.Point(79, 43);
            this.titluTextBox.Name = "titluTextBox";
            this.titluTextBox.Size = new System.Drawing.Size(241, 20);
            this.titluTextBox.TabIndex = 5;
            // 
            // genTextBox
            // 
            this.genTextBox.BackColor = System.Drawing.Color.Lavender;
            this.genTextBox.Location = new System.Drawing.Point(79, 79);
            this.genTextBox.Name = "genTextBox";
            this.genTextBox.Size = new System.Drawing.Size(241, 20);
            this.genTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lavender;
            this.saveButton.Location = new System.Drawing.Point(245, 166);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // anLansareNumericUpDown
            // 
            this.anLansareNumericUpDown.BackColor = System.Drawing.Color.Lavender;
            this.anLansareNumericUpDown.Location = new System.Drawing.Point(79, 116);
            this.anLansareNumericUpDown.Name = "anLansareNumericUpDown";
            this.anLansareNumericUpDown.Size = new System.Drawing.Size(241, 20);
            this.anLansareNumericUpDown.TabIndex = 9;
            // 
            // AddFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(332, 215);
            this.Controls.Add(this.anLansareNumericUpDown);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.genTextBox);
            this.Controls.Add(this.titluTextBox);
            this.Controls.Add(this.anLansareLabel);
            this.Controls.Add(this.genLabel);
            this.Controls.Add(this.titluLabel);
            this.Name = "AddFilmForm";
            this.Text = "AddFilmForm";
            ((System.ComponentModel.ISupportInitialize)(this.anLansareNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titluLabel;
        private System.Windows.Forms.Label genLabel;
        private System.Windows.Forms.Label anLansareLabel;
        private System.Windows.Forms.TextBox titluTextBox;
        private System.Windows.Forms.TextBox genTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown anLansareNumericUpDown;
    }
}