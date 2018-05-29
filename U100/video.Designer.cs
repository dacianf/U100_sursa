namespace U100
{
    partial class video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(video));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.butt_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-1, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(786, 519);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // butt_exit
            // 
            this.butt_exit.BackgroundImage = global::U100.Properties.Resources._3_buton_iesire;
            this.butt_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butt_exit.FlatAppearance.BorderSize = 0;
            this.butt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_exit.Location = new System.Drawing.Point(685, 525);
            this.butt_exit.Name = "butt_exit";
            this.butt_exit.Size = new System.Drawing.Size(100, 37);
            this.butt_exit.TabIndex = 1;
            this.butt_exit.UseVisualStyleBackColor = true;
            this.butt_exit.Click += new System.EventHandler(this.butt_exit_Click);
            this.butt_exit.MouseEnter += new System.EventHandler(this.butt_exit_MouseEnter);
            this.butt_exit.MouseLeave += new System.EventHandler(this.butt_exit_MouseLeave);
            // 
            // video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.butt_exit);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "video";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unirea - Video";
            this.Load += new System.EventHandler(this.video_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button butt_exit;
    }
}