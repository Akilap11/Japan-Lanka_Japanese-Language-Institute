namespace Japan_Lanka_Japanese_Language_Institute
{
    partial class StartingForm
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Button_Staff = new Guna.UI2.WinForms.Guna2TileButton();
            this.Button_Admin = new Guna.UI2.WinForms.Guna2TileButton();
            this.label_Exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Japan_Lanka_Japanese_Language_Institute.Properties.Resources.Opening;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-29, -6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(763, 458);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Button_Staff
            // 
            this.Button_Staff.BackColor = System.Drawing.Color.Transparent;
            this.Button_Staff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Staff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Staff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Staff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Staff.FillColor = System.Drawing.Color.DeepPink;
            this.Button_Staff.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Staff.ForeColor = System.Drawing.Color.White;
            this.Button_Staff.Location = new System.Drawing.Point(287, 348);
            this.Button_Staff.Name = "Button_Staff";
            this.Button_Staff.Size = new System.Drawing.Size(150, 47);
            this.Button_Staff.TabIndex = 1;
            this.Button_Staff.Text = "Staff Login";
            this.Button_Staff.Click += new System.EventHandler(this.Button_Staff_Click);
            // 
            // Button_Admin
            // 
            this.Button_Admin.BackColor = System.Drawing.Color.Transparent;
            this.Button_Admin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Admin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Admin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Admin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Admin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Button_Admin.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Admin.ForeColor = System.Drawing.Color.White;
            this.Button_Admin.Location = new System.Drawing.Point(475, 348);
            this.Button_Admin.Name = "Button_Admin";
            this.Button_Admin.Size = new System.Drawing.Size(150, 47);
            this.Button_Admin.TabIndex = 2;
            this.Button_Admin.Text = "Admin Login";
            this.Button_Admin.Click += new System.EventHandler(this.Button_Admin_Click);
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.BackColor = System.Drawing.Color.Transparent;
            this.label_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.Location = new System.Drawing.Point(682, 9);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(21, 20);
            this.label_Exit.TabIndex = 3;
            this.label_Exit.Text = "X";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            this.label_Exit.MouseEnter += new System.EventHandler(this.label_Exit_MouseEnter);
            this.label_Exit.MouseLeave += new System.EventHandler(this.label_Exit_MouseLeave);
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.Button_Admin);
            this.Controls.Add(this.Button_Staff);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartingForm";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TileButton Button_Staff;
        private Guna.UI2.WinForms.Guna2TileButton Button_Admin;
        private System.Windows.Forms.Label label_Exit;
    }
}