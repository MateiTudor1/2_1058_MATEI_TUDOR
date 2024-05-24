namespace _2_1058_MATEI_TUDOR.MainPageForms
{
    partial class FilmForm
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
            this.filmDataGridView = new System.Windows.Forms.DataGridView();
            this.addFilmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filmDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filmDataGridView
            // 
            this.filmDataGridView.AllowUserToAddRows = false;
            this.filmDataGridView.AllowUserToDeleteRows = false;
            this.filmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmDataGridView.Location = new System.Drawing.Point(12, 83);
            this.filmDataGridView.Name = "filmDataGridView";
            this.filmDataGridView.ReadOnly = true;
            this.filmDataGridView.Size = new System.Drawing.Size(776, 355);
            this.filmDataGridView.TabIndex = 0;
            this.filmDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmDataGridView_CellContentClick);
            // 
            // addFilmButton
            // 
            this.addFilmButton.Location = new System.Drawing.Point(12, 12);
            this.addFilmButton.Name = "addFilmButton";
            this.addFilmButton.Size = new System.Drawing.Size(111, 65);
            this.addFilmButton.TabIndex = 1;
            this.addFilmButton.Text = "Add Film";
            this.addFilmButton.UseVisualStyleBackColor = true;
            this.addFilmButton.Click += new System.EventHandler(this.addFilmButton_Click_1);
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addFilmButton);
            this.Controls.Add(this.filmDataGridView);
            this.Name = "FilmForm";
            this.Text = "FilmForm";
            ((System.ComponentModel.ISupportInitialize)(this.filmDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView filmDataGridView;
        private System.Windows.Forms.Button addFilmButton;
    }
}