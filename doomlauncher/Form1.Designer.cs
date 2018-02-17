namespace doomlauncher
{
    partial class main_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_window));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Addons_textbox = new System.Windows.Forms.TextBox();
            this.About_button = new System.Windows.Forms.Button();
            this.Launch_button = new System.Windows.Forms.Button();
            this.ExePath_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExePath_button = new System.Windows.Forms.Button();
            this.Addons_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ExtraArgs_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::doomlauncher.Properties.Resources.doomlauncher;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Addons_textbox
            // 
            this.Addons_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Addons_textbox.Location = new System.Drawing.Point(78, 254);
            this.Addons_textbox.Name = "Addons_textbox";
            this.Addons_textbox.Size = new System.Drawing.Size(334, 20);
            this.Addons_textbox.TabIndex = 4;
            // 
            // About_button
            // 
            this.About_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.About_button.Location = new System.Drawing.Point(12, 335);
            this.About_button.Name = "About_button";
            this.About_button.Size = new System.Drawing.Size(92, 29);
            this.About_button.TabIndex = 6;
            this.About_button.Text = "About";
            this.About_button.UseVisualStyleBackColor = true;
            this.About_button.Click += new System.EventHandler(this.About_button_Click);
            // 
            // Launch_button
            // 
            this.Launch_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Launch_button.Location = new System.Drawing.Point(371, 335);
            this.Launch_button.Name = "Launch_button";
            this.Launch_button.Size = new System.Drawing.Size(92, 29);
            this.Launch_button.TabIndex = 1;
            this.Launch_button.Text = "Launch";
            this.Launch_button.UseVisualStyleBackColor = true;
            this.Launch_button.Click += new System.EventHandler(this.Launch_button_Click);
            // 
            // ExePath_textbox
            // 
            this.ExePath_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExePath_textbox.Location = new System.Drawing.Point(78, 212);
            this.ExePath_textbox.Name = "ExePath_textbox";
            this.ExePath_textbox.Size = new System.Drawing.Size(334, 20);
            this.ExePath_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOOM exe:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Addons:";
            // 
            // ExePath_button
            // 
            this.ExePath_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExePath_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExePath_button.Location = new System.Drawing.Point(418, 207);
            this.ExePath_button.Name = "ExePath_button";
            this.ExePath_button.Size = new System.Drawing.Size(45, 29);
            this.ExePath_button.TabIndex = 2;
            this.ExePath_button.Text = "...";
            this.ExePath_button.UseVisualStyleBackColor = true;
            this.ExePath_button.Click += new System.EventHandler(this.ExePath_button_Click);
            // 
            // Addons_button
            // 
            this.Addons_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Addons_button.Location = new System.Drawing.Point(418, 249);
            this.Addons_button.Name = "Addons_button";
            this.Addons_button.Size = new System.Drawing.Size(45, 29);
            this.Addons_button.TabIndex = 0;
            this.Addons_button.Text = "...";
            this.Addons_button.UseVisualStyleBackColor = true;
            this.Addons_button.Click += new System.EventHandler(this.Addons_button_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Extra args:";
            // 
            // ExtraArgs_textbox
            // 
            this.ExtraArgs_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtraArgs_textbox.Location = new System.Drawing.Point(78, 293);
            this.ExtraArgs_textbox.Name = "ExtraArgs_textbox";
            this.ExtraArgs_textbox.Size = new System.Drawing.Size(334, 20);
            this.ExtraArgs_textbox.TabIndex = 5;
            // 
            // main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExtraArgs_textbox);
            this.Controls.Add(this.Addons_button);
            this.Controls.Add(this.ExePath_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExePath_textbox);
            this.Controls.Add(this.Launch_button);
            this.Controls.Add(this.About_button);
            this.Controls.Add(this.Addons_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOOM Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Addons_textbox;
        private System.Windows.Forms.Button About_button;
        private System.Windows.Forms.Button Launch_button;
        private System.Windows.Forms.TextBox ExePath_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExePath_button;
        private System.Windows.Forms.Button Addons_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExtraArgs_textbox;
    }
}

