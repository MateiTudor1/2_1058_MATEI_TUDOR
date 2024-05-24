namespace _2_1058_MATEI_TUDOR
{
    partial class MainForm
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
            this.filmebutton = new System.Windows.Forms.Button();
            this.clientiButton = new System.Windows.Forms.Button();
            this.InchirieriButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filmebutton
            // 
            this.filmebutton.BackColor = System.Drawing.Color.Lavender;
            this.filmebutton.Location = new System.Drawing.Point(311, 173);
            this.filmebutton.Name = "filmebutton";
            this.filmebutton.Size = new System.Drawing.Size(131, 77);
            this.filmebutton.TabIndex = 0;
            this.filmebutton.Text = "Filme";
            this.filmebutton.UseVisualStyleBackColor = false;
            this.filmebutton.Click += new System.EventHandler(this.filmebutton_Click);
            // 
            // clientiButton
            // 
            this.clientiButton.BackColor = System.Drawing.Color.Lavender;
            this.clientiButton.Location = new System.Drawing.Point(311, 61);
            this.clientiButton.Name = "clientiButton";
            this.clientiButton.Size = new System.Drawing.Size(131, 77);
            this.clientiButton.TabIndex = 1;
            this.clientiButton.Text = "Clienti";
            this.clientiButton.UseVisualStyleBackColor = false;
            this.clientiButton.Click += new System.EventHandler(this.clientiButton_Click);
            // 
            // InchirieriButton
            // 
            this.InchirieriButton.BackColor = System.Drawing.Color.Lavender;
            this.InchirieriButton.Location = new System.Drawing.Point(311, 290);
            this.InchirieriButton.Name = "InchirieriButton";
            this.InchirieriButton.Size = new System.Drawing.Size(131, 77);
            this.InchirieriButton.TabIndex = 2;
            this.InchirieriButton.Text = "Inchirieri";
            this.InchirieriButton.UseVisualStyleBackColor = false;
            this.InchirieriButton.Click += new System.EventHandler(this.InchirieriButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InchirieriButton);
            this.Controls.Add(this.clientiButton);
            this.Controls.Add(this.filmebutton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button filmebutton;
        private System.Windows.Forms.Button clientiButton;
        private System.Windows.Forms.Button InchirieriButton;
    }
}

