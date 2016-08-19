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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.SelectedMovieGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackButton = new System.Windows.Forms.Button();
            this.StreamButton = new System.Windows.Forms.Button();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.OrderDvdCheckBox = new System.Windows.Forms.CheckBox();
            this.OrderDvdLabel = new System.Windows.Forms.Label();
            this.OrderDvdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedMovieGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.OrderGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TitleTextBox.Location = new System.Drawing.Point(35, 71);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(157, 22);
            this.TitleTextBox.TabIndex = 0;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CategoryTextBox.Location = new System.Drawing.Point(35, 124);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 22);
            this.CategoryTextBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(35, 48);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 17);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(35, 104);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(65, 17);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Category";
            // 
            // SelectedMovieGroupBox
            // 
            this.SelectedMovieGroupBox.Controls.Add(this.CategoryTextBox);
            this.SelectedMovieGroupBox.Controls.Add(this.MoviePictureBox);
            this.SelectedMovieGroupBox.Controls.Add(this.TitleTextBox);
            this.SelectedMovieGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectedMovieGroupBox.Controls.Add(this.TitleLabel);
            this.SelectedMovieGroupBox.Location = new System.Drawing.Point(22, 58);
            this.SelectedMovieGroupBox.Name = "SelectedMovieGroupBox";
            this.SelectedMovieGroupBox.Size = new System.Drawing.Size(307, 516);
            this.SelectedMovieGroupBox.TabIndex = 7;
            this.SelectedMovieGroupBox.TabStop = false;
            this.SelectedMovieGroupBox.Text = "Movie Selected";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoviePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoviePictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("MoviePictureBox.InitialImage")));
            this.MoviePictureBox.Location = new System.Drawing.Point(38, 162);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(227, 333);
            this.MoviePictureBox.TabIndex = 6;
            this.MoviePictureBox.TabStop = false;
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.OrderDvdTextBox);
            this.OrderGroupBox.Controls.Add(this.OrderDvdLabel);
            this.OrderGroupBox.Controls.Add(this.OrderDvdCheckBox);
            this.OrderGroupBox.Controls.Add(this.GrandTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.GrandTotalLabel);
            this.OrderGroupBox.Controls.Add(this.textBox1);
            this.OrderGroupBox.Controls.Add(this.label1);
            this.OrderGroupBox.Controls.Add(this.SubTotalTextBox);
            this.OrderGroupBox.Controls.Add(this.SubTotalLabel);
            this.OrderGroupBox.Controls.Add(this.CostTextBox);
            this.OrderGroupBox.Controls.Add(this.CostLabel);
            this.OrderGroupBox.Location = new System.Drawing.Point(385, 58);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(362, 390);
            this.OrderGroupBox.TabIndex = 8;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Your Order";
            // 
            // CostTextBox
            // 
            this.CostTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CostTextBox.Location = new System.Drawing.Point(146, 48);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(66, 22);
            this.CostTextBox.TabIndex = 1;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(52, 48);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(36, 17);
            this.CostLabel.TabIndex = 0;
            this.CostLabel.Text = "Cost";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(166, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(131, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(450, 495);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(136, 36);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Cancel";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StreamButton
            // 
            this.StreamButton.Location = new System.Drawing.Point(614, 495);
            this.StreamButton.Name = "StreamButton";
            this.StreamButton.Size = new System.Drawing.Size(133, 36);
            this.StreamButton.TabIndex = 12;
            this.StreamButton.Text = "Stream";
            this.StreamButton.UseVisualStyleBackColor = true;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(52, 104);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(69, 17);
            this.SubTotalLabel.TabIndex = 2;
            this.SubTotalLabel.Text = "Sub Total";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubTotalTextBox.Location = new System.Drawing.Point(146, 105);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(66, 22);
            this.SubTotalTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tax(13%)";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(146, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(66, 22);
            this.textBox1.TabIndex = 5;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Location = new System.Drawing.Point(52, 172);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(84, 17);
            this.GrandTotalLabel.TabIndex = 6;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GrandTotalTextBox.Location = new System.Drawing.Point(146, 167);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.ReadOnly = true;
            this.GrandTotalTextBox.Size = new System.Drawing.Size(66, 22);
            this.GrandTotalTextBox.TabIndex = 7;
            // 
            // OrderDvdCheckBox
            // 
            this.OrderDvdCheckBox.AutoSize = true;
            this.OrderDvdCheckBox.Location = new System.Drawing.Point(55, 211);
            this.OrderDvdCheckBox.Name = "OrderDvdCheckBox";
            this.OrderDvdCheckBox.Size = new System.Drawing.Size(283, 21);
            this.OrderDvdCheckBox.TabIndex = 8;
            this.OrderDvdCheckBox.Text = "Order the DVD (adds 10$ to your order)";
            this.OrderDvdCheckBox.UseVisualStyleBackColor = true;
            // 
            // OrderDvdLabel
            // 
            this.OrderDvdLabel.AutoSize = true;
            this.OrderDvdLabel.Enabled = false;
            this.OrderDvdLabel.Location = new System.Drawing.Point(51, 75);
            this.OrderDvdLabel.Name = "OrderDvdLabel";
            this.OrderDvdLabel.Size = new System.Drawing.Size(37, 17);
            this.OrderDvdLabel.TabIndex = 9;
            this.OrderDvdLabel.Text = "DVD";
            // 
            // OrderDvdTextBox
            // 
            this.OrderDvdTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OrderDvdTextBox.Enabled = false;
            this.OrderDvdTextBox.Location = new System.Drawing.Point(146, 76);
            this.OrderDvdTextBox.Name = "OrderDvdTextBox";
            this.OrderDvdTextBox.ReadOnly = true;
            this.OrderDvdTextBox.Size = new System.Drawing.Size(66, 22);
            this.OrderDvdTextBox.TabIndex = 10;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 611);
            this.ControlBox = false;
            this.Controls.Add(this.StreamButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.SelectedMovieGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.SelectedMovieGroupBox.ResumeLayout(false);
            this.SelectedMovieGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.GroupBox SelectedMovieGroupBox;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button StreamButton;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.CheckBox OrderDvdCheckBox;
        private System.Windows.Forms.Label OrderDvdLabel;
        private System.Windows.Forms.TextBox OrderDvdTextBox;
    }
}