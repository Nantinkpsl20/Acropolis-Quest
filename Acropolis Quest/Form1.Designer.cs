namespace Acropolis_Quest
{
    partial class splashScreen
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
            this.components = new System.ComponentModel.Container();
            this.title = new System.Windows.Forms.Label();
            this.loadingAppBar = new System.Windows.Forms.ProgressBar();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.rate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.title.ForeColor = System.Drawing.Color.GreenYellow;
            this.title.Location = new System.Drawing.Point(-5, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(351, 42);
            this.title.TabIndex = 0;
            this.title.Text = "Acropolis Quest";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingAppBar
            // 
            this.loadingAppBar.BackColor = System.Drawing.Color.Gray;
            this.loadingAppBar.Enabled = false;
            this.loadingAppBar.ForeColor = System.Drawing.Color.GreenYellow;
            this.loadingAppBar.Location = new System.Drawing.Point(12, 427);
            this.loadingAppBar.Name = "loadingAppBar";
            this.loadingAppBar.Size = new System.Drawing.Size(319, 35);
            this.loadingAppBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loadingAppBar.TabIndex = 1;
            // 
            // SplashTimer
            // 
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.BackColor = System.Drawing.Color.Transparent;
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rate.Location = new System.Drawing.Point(203, 474);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(0, 25);
            this.rate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(97, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "loading...";
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = global::Acropolis_Quest.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(343, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.loadingAppBar);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "splashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ProgressBar loadingAppBar;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Label label1;
    }
}

