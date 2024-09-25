namespace Acropolis_Quest
{
    partial class loginScreen
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
            this.username = new System.Windows.Forms.TextBox();
            this.loginTitle = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.LinkLabel();
            this.seePswd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.Control;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.username.ForeColor = System.Drawing.Color.Gray;
            this.username.Location = new System.Drawing.Point(58, 217);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(237, 34);
            this.username.TabIndex = 0;
            this.username.Text = "username";
            this.username.Click += new System.EventHandler(this.username_Click);
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // loginTitle
            // 
            this.loginTitle.AutoSize = true;
            this.loginTitle.BackColor = System.Drawing.Color.Transparent;
            this.loginTitle.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.loginTitle.Location = new System.Drawing.Point(95, 90);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(149, 42);
            this.loginTitle.TabIndex = 2;
            this.loginTitle.Text = "Sign In";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginBtn.Location = new System.Drawing.Point(58, 409);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(237, 40);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "sign in";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(58, 309);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(237, 34);
            this.password.TabIndex = 4;
            this.password.Text = "password";
            this.password.Click += new System.EventHandler(this.password_Click);
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(54, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "You don\'t have an account?";
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.BackColor = System.Drawing.Color.Transparent;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.register.LinkColor = System.Drawing.Color.Blue;
            this.register.Location = new System.Drawing.Point(54, 503);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(115, 22);
            this.register.TabIndex = 6;
            this.register.TabStop = true;
            this.register.Text = "Create one!";
            this.register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_LinkClicked);
            // 
            // seePswd
            // 
            this.seePswd.BackgroundImage = global::Acropolis_Quest.Properties.Resources.openEye;
            this.seePswd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.seePswd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seePswd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seePswd.Location = new System.Drawing.Point(253, 309);
            this.seePswd.Name = "seePswd";
            this.seePswd.Size = new System.Drawing.Size(42, 34);
            this.seePswd.TabIndex = 7;
            this.seePswd.UseVisualStyleBackColor = true;
            this.seePswd.Click += new System.EventHandler(this.seePswd_Click);
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Acropolis_Quest.Properties.Resources.loginBack1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 559);
            this.Controls.Add(this.seePswd);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginTitle);
            this.Controls.Add(this.username);
            this.Name = "loginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel register;
        private System.Windows.Forms.Button seePswd;
    }
}