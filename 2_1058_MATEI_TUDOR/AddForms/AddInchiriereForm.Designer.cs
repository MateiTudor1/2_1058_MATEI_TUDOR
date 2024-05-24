namespace _2_1058_MATEI_TUDOR.AddForms
{
    partial class AddInchiriereForm
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
            this.idClientLabel = new System.Windows.Forms.Label();
            this.idFilmLabel = new System.Windows.Forms.Label();
            this.pretLabel = new System.Windows.Forms.Label();
            this.dataInchiriereLabel = new System.Windows.Forms.Label();
            this.dataReturnareLabel = new System.Windows.Forms.Label();
            this.idClientTextBox = new System.Windows.Forms.TextBox();
            this.idFilmTextBox = new System.Windows.Forms.TextBox();
            this.pretTextBox = new System.Windows.Forms.TextBox();
            this.dataInchiriereDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataReturnareDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idClientLabel
            // 
            this.idClientLabel.AutoSize = true;
            this.idClientLabel.BackColor = System.Drawing.Color.Lavender;
            this.idClientLabel.Location = new System.Drawing.Point(12, 39);
            this.idClientLabel.Name = "idClientLabel";
            this.idClientLabel.Size = new System.Drawing.Size(45, 13);
            this.idClientLabel.TabIndex = 1;
            this.idClientLabel.Text = "Id Client";
            // 
            // idFilmLabel
            // 
            this.idFilmLabel.AutoSize = true;
            this.idFilmLabel.BackColor = System.Drawing.Color.Lavender;
            this.idFilmLabel.Location = new System.Drawing.Point(12, 71);
            this.idFilmLabel.Name = "idFilmLabel";
            this.idFilmLabel.Size = new System.Drawing.Size(37, 13);
            this.idFilmLabel.TabIndex = 2;
            this.idFilmLabel.Text = "Id Film";
            // 
            // pretLabel
            // 
            this.pretLabel.AutoSize = true;
            this.pretLabel.BackColor = System.Drawing.Color.Lavender;
            this.pretLabel.Location = new System.Drawing.Point(12, 101);
            this.pretLabel.Name = "pretLabel";
            this.pretLabel.Size = new System.Drawing.Size(26, 13);
            this.pretLabel.TabIndex = 3;
            this.pretLabel.Text = "Pret";
            // 
            // dataInchiriereLabel
            // 
            this.dataInchiriereLabel.AutoSize = true;
            this.dataInchiriereLabel.BackColor = System.Drawing.Color.Lavender;
            this.dataInchiriereLabel.Location = new System.Drawing.Point(12, 131);
            this.dataInchiriereLabel.Name = "dataInchiriereLabel";
            this.dataInchiriereLabel.Size = new System.Drawing.Size(76, 13);
            this.dataInchiriereLabel.TabIndex = 4;
            this.dataInchiriereLabel.Text = "Data Inchiriere";
            // 
            // dataReturnareLabel
            // 
            this.dataReturnareLabel.AutoSize = true;
            this.dataReturnareLabel.BackColor = System.Drawing.Color.Lavender;
            this.dataReturnareLabel.Location = new System.Drawing.Point(12, 160);
            this.dataReturnareLabel.Name = "dataReturnareLabel";
            this.dataReturnareLabel.Size = new System.Drawing.Size(80, 13);
            this.dataReturnareLabel.TabIndex = 5;
            this.dataReturnareLabel.Text = "Data Returnare";
            // 
            // idClientTextBox
            // 
            this.idClientTextBox.BackColor = System.Drawing.Color.Lavender;
            this.idClientTextBox.Location = new System.Drawing.Point(109, 36);
            this.idClientTextBox.Name = "idClientTextBox";
            this.idClientTextBox.Size = new System.Drawing.Size(290, 20);
            this.idClientTextBox.TabIndex = 7;
            // 
            // idFilmTextBox
            // 
            this.idFilmTextBox.BackColor = System.Drawing.Color.Lavender;
            this.idFilmTextBox.Location = new System.Drawing.Point(109, 68);
            this.idFilmTextBox.Name = "idFilmTextBox";
            this.idFilmTextBox.Size = new System.Drawing.Size(290, 20);
            this.idFilmTextBox.TabIndex = 8;
            // 
            // pretTextBox
            // 
            this.pretTextBox.BackColor = System.Drawing.Color.Lavender;
            this.pretTextBox.Location = new System.Drawing.Point(109, 98);
            this.pretTextBox.Name = "pretTextBox";
            this.pretTextBox.Size = new System.Drawing.Size(290, 20);
            this.pretTextBox.TabIndex = 9;
            // 
            // dataInchiriereDateTimePicker
            // 
            this.dataInchiriereDateTimePicker.Location = new System.Drawing.Point(109, 125);
            this.dataInchiriereDateTimePicker.Name = "dataInchiriereDateTimePicker";
            this.dataInchiriereDateTimePicker.Size = new System.Drawing.Size(290, 20);
            this.dataInchiriereDateTimePicker.TabIndex = 12;
            // 
            // dataReturnareDateTimePicker
            // 
            this.dataReturnareDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.dataReturnareDateTimePicker.Location = new System.Drawing.Point(109, 154);
            this.dataReturnareDateTimePicker.Name = "dataReturnareDateTimePicker";
            this.dataReturnareDateTimePicker.Size = new System.Drawing.Size(290, 20);
            this.dataReturnareDateTimePicker.TabIndex = 13;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lavender;
            this.saveButton.Location = new System.Drawing.Point(308, 203);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 34);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddInchiriereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(411, 249);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataReturnareDateTimePicker);
            this.Controls.Add(this.dataInchiriereDateTimePicker);
            this.Controls.Add(this.pretTextBox);
            this.Controls.Add(this.idFilmTextBox);
            this.Controls.Add(this.idClientTextBox);
            this.Controls.Add(this.dataReturnareLabel);
            this.Controls.Add(this.dataInchiriereLabel);
            this.Controls.Add(this.pretLabel);
            this.Controls.Add(this.idFilmLabel);
            this.Controls.Add(this.idClientLabel);
            this.Name = "AddInchiriereForm";
            this.Text = "AddInchiriereForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label idClientLabel;
        private System.Windows.Forms.Label idFilmLabel;
        private System.Windows.Forms.Label pretLabel;
        private System.Windows.Forms.Label dataInchiriereLabel;
        private System.Windows.Forms.Label dataReturnareLabel;
        private System.Windows.Forms.TextBox idClientTextBox;
        private System.Windows.Forms.TextBox idFilmTextBox;
        private System.Windows.Forms.TextBox pretTextBox;
        private System.Windows.Forms.DateTimePicker dataInchiriereDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataReturnareDateTimePicker;
        private System.Windows.Forms.Button saveButton;
    }
}