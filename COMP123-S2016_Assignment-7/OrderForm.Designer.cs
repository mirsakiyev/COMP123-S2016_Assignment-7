namespace COMP123_S2016_Assignment_7
{
    partial class OrderForm
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
            this.SelectedMovieGroupBox = new System.Windows.Forms.GroupBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectedMovieGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedMovieGroupBox
            // 
            this.SelectedMovieGroupBox.Controls.Add(this.pictureBox1);
            this.SelectedMovieGroupBox.Controls.Add(this.CategoryTextBox);
            this.SelectedMovieGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectedMovieGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectedMovieGroupBox.Controls.Add(this.TitleLabel);
            this.SelectedMovieGroupBox.Location = new System.Drawing.Point(34, 52);
            this.SelectedMovieGroupBox.Name = "SelectedMovieGroupBox";
            this.SelectedMovieGroupBox.Size = new System.Drawing.Size(253, 385);
            this.SelectedMovieGroupBox.TabIndex = 0;
            this.SelectedMovieGroupBox.TabStop = false;
            this.SelectedMovieGroupBox.Text = "Selected Movie";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(18, 37);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 17);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(18, 95);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(65, 17);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(21, 58);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(194, 22);
            this.TitleTextBox.TabIndex = 2;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(21, 116);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 22);
            this.CategoryTextBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 157);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 508);
            this.Controls.Add(this.SelectedMovieGroupBox);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.SelectedMovieGroupBox.ResumeLayout(false);
            this.SelectedMovieGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectedMovieGroupBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}