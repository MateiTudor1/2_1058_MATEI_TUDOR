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
            this.filmebutton.Location = new System.Drawing.Point(322, 12);
            this.filmebutton.Name = "filmebutton";
            this.filmebutton.Size = new System.Drawing.Size(131, 77);
            this.filmebutton.TabIndex = 0;
            this.filmebutton.Text = "Filme";
            this.filmebutton.UseVisualStyleBackColor = true;
            this.filmebutton.Click += new System.EventHandler(this.filmebutton_Click);
            // 
            // clientiButton
            // 
            this.clientiButton.Location = new System.Drawing.Point(17, 12);
            this.clientiButton.Name = "clientiButton";
            this.clientiButton.Size = new System.Drawing.Size(131, 77);
            this.clientiButton.TabIndex = 1;
            this.clientiButton.Text = "Clienti";
            this.clientiButton.UseVisualStyleBackColor = true;
            this.clientiButton.Click += new System.EventHandler(this.clientiButton_Click);
            // 
            // InchirieriButton
            // 
            this.InchirieriButton.Location = new System.Drawing.Point(651, 12);
            this.InchirieriButton.Name = "InchirieriButton";
            this.InchirieriButton.Size = new System.Drawing.Size(137, 77);
            this.InchirieriButton.TabIndex = 2;
            this.InchirieriButton.Text = "Inchirieri";
            this.InchirieriButton.UseVisualStyleBackColor = true;
            this.InchirieriButton.Click += new System.EventHandler(this.InchirieriButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

