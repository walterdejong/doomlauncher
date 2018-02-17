namespace doomlauncher
{
    partial class About_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_window));
            this.OK_button = new System.Windows.Forms.Button();
            this.About_label = new System.Windows.Forms.Label();
            this.License_linklabel = new System.Windows.Forms.LinkLabel();
            this.About_image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.About_image)).BeginInit();
            this.SuspendLayout();
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(80, 214);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(92, 29);
            this.OK_button.TabIndex = 0;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // About_label
            // 
            this.About_label.AutoSize = true;
            this.About_label.Location = new System.Drawing.Point(94, 12);
            this.About_label.Name = "About_label";
            this.About_label.Size = new System.Drawing.Size(88, 13);
            this.About_label.TabIndex = 7;
            this.About_label.Text = "DOOM Launcher";
            // 
            // License_linklabel
            // 
            this.License_linklabel.AutoSize = true;
            this.License_linklabel.Location = new System.Drawing.Point(13, 183);
            this.License_linklabel.Name = "License_linklabel";
            this.License_linklabel.Size = new System.Drawing.Size(231, 13);
            this.License_linklabel.TabIndex = 1;
            this.License_linklabel.TabStop = true;
            this.License_linklabel.Text = "https://opensource.org/licenses/BSD-2-Clause";
            this.License_linklabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.License_linklabel_LinkClicked);
            // 
            // About_image
            // 
            this.About_image.Image = global::doomlauncher.Properties.Resources.skull_icon;
            this.About_image.InitialImage = null;
            this.About_image.Location = new System.Drawing.Point(12, 12);
            this.About_image.Name = "About_image";
            this.About_image.Size = new System.Drawing.Size(76, 71);
            this.About_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.About_image.TabIndex = 6;
            this.About_image.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "License:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Made for use with GZDoom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Copyright 2018";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Walter de Jong <walter@heiho.net>";
            // 
            // About_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 255);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.License_linklabel);
            this.Controls.Add(this.About_label);
            this.Controls.Add(this.About_image);
            this.Controls.Add(this.OK_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About_window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.About_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.PictureBox About_image;
        private System.Windows.Forms.Label About_label;
        private System.Windows.Forms.LinkLabel License_linklabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}