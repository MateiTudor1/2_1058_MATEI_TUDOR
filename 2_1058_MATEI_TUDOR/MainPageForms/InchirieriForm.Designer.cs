namespace _2_1058_MATEI_TUDOR.MainPageForms
{
    partial class InchirieriForm
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
            this.inchirieriDataGridView = new System.Windows.Forms.DataGridView();
            this.addInchiriereButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inchirieriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inchirieriDataGridView
            // 
            this.inchirieriDataGridView.AllowUserToAddRows = false;
            this.inchirieriDataGridView.AllowUserToDeleteRows = false;
            this.inchirieriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inchirieriDataGridView.Location = new System.Drawing.Point(12, 87);
            this.inchirieriDataGridView.Name = "inchirieriDataGridView";
            this.inchirieriDataGridView.ReadOnly = true;
            this.inchirieriDataGridView.Size = new System.Drawing.Size(944, 441);
            this.inchirieriDataGridView.TabIndex = 0;
            this.inchirieriDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inchirieriDataGridView_CellContentClick);
            // 
            // addInchiriereButton
            // 
            this.addInchiriereButton.Location = new System.Drawing.Point(12, 12);
            this.addInchiriereButton.Name = "addInchiriereButton";
            this.addInchiriereButton.Size = new System.Drawing.Size(112, 69);
            this.addInchiriereButton.TabIndex = 1;
            this.addInchiriereButton.Text = "Add Inchiriere";
            this.addInchiriereButton.UseVisualStyleBackColor = true;
            this.addInchiriereButton.Click += new System.EventHandler(this.addInchiriereButton_Click);
            // 
            // InchirieriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 540);
            this.Controls.Add(this.addInchiriereButton);
            this.Controls.Add(this.inchirieriDataGridView);
            this.Name = "InchirieriForm";
            this.Text = "InchirieriForm";
            ((System.ComponentModel.ISupportInitialize)(this.inchirieriDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView inchirieriDataGridView;
        private System.Windows.Forms.Button addInchiriereButton;
    }
}