namespace Acropolis_Quest
{
    partial class registrationForm
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
            this.name = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.conPassword = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Gold;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.name.ForeColor = System.Drawing.Color.Gray;
            this.name.Location = new System.Drawing.Point(52, 141);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(237, 34);
            this.name.TabIndex = 1;
            this.name.Text = "name";
            this.name.Click += new System.EventHandler(this.name_Click);
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Gold;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.username.ForeColor = System.Drawing.Color.Gray;
            this.username.Location = new System.Drawing.Point(52, 211);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(237, 34);
            this.username.TabIndex = 2;
            this.username.Text = "username";
            this.username.Click += new System.EventHandler(this.username_Click);
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Gold;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(52, 283);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(237, 34);
            this.password.TabIndex = 3;
            this.password.Text = "password";
            this.password.Click += new System.EventHandler(this.password_Click);
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // conPassword
            // 
            this.conPassword.BackColor = System.Drawing.Color.Gold;
            this.conPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.conPassword.ForeColor = System.Drawing.Color.Gray;
            this.conPassword.Location = new System.Drawing.Point(52, 352);
            this.conPassword.Name = "conPassword";
            this.conPassword.Size = new System.Drawing.Size(237, 34);
            this.conPassword.TabIndex = 4;
            this.conPassword.Text = "confirm password";
            this.conPassword.TextChanged += new System.EventHandler(this.conPassword_TextChanged);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.registerBtn.Location = new System.Drawing.Point(97, 469);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(157, 43);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "sign up";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sign up";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Acropolis_Quest.Properties.Resources.regImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.conPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.name);
            this.Name = "registrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox conPassword;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label2;
    }
}