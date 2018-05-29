namespace U100
{
    partial class player_teste
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
            this.text_nume = new System.Windows.Forms.TextBox();
            this.label_max_scor = new System.Windows.Forms.Label();
            this.label_ultimul_scor = new System.Windows.Forms.Label();
            this.button_reset_scor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_nr_intrebari = new System.Windows.Forms.Label();
            this.text_nr_intrebari = new System.Windows.Forms.TextBox();
            this.button_incepe = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_nume
            // 
            this.text_nume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_nume.Location = new System.Drawing.Point(93, 42);
            this.text_nume.MaxLength = 10;
            this.text_nume.Name = "text_nume";
            this.text_nume.Size = new System.Drawing.Size(118, 20);
            this.text_nume.TabIndex = 0;
            this.text_nume.Text = "Numele";
            this.text_nume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_max_scor
            // 
            this.label_max_scor.AutoSize = true;
            this.label_max_scor.Location = new System.Drawing.Point(35, 75);
            this.label_max_scor.Name = "label_max_scor";
            this.label_max_scor.Size = new System.Drawing.Size(104, 13);
            this.label_max_scor.TabIndex = 1;
            this.label_max_scor.Text = "Scorul maxim este: 0";
            this.label_max_scor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_max_scor.Click += new System.EventHandler(this.label_max_scor_Click);
            // 
            // label_ultimul_scor
            // 
            this.label_ultimul_scor.AutoSize = true;
            this.label_ultimul_scor.Location = new System.Drawing.Point(35, 103);
            this.label_ultimul_scor.Name = "label_ultimul_scor";
            this.label_ultimul_scor.Size = new System.Drawing.Size(96, 13);
            this.label_ultimul_scor.TabIndex = 2;
            this.label_ultimul_scor.Text = "Ultimul scor este: 0";
            this.label_ultimul_scor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_reset_scor
            // 
            this.button_reset_scor.Location = new System.Drawing.Point(38, 129);
            this.button_reset_scor.Name = "button_reset_scor";
            this.button_reset_scor.Size = new System.Drawing.Size(84, 26);
            this.button_reset_scor.TabIndex = 3;
            this.button_reset_scor.Text = "Reset scor";
            this.button_reset_scor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(-14, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 10);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label_nr_intrebari
            // 
            this.label_nr_intrebari.AutoSize = true;
            this.label_nr_intrebari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nr_intrebari.Location = new System.Drawing.Point(25, 193);
            this.label_nr_intrebari.Name = "label_nr_intrebari";
            this.label_nr_intrebari.Size = new System.Drawing.Size(102, 16);
            this.label_nr_intrebari.TabIndex = 5;
            this.label_nr_intrebari.Text = "Numar întrebări:";
            // 
            // text_nr_intrebari
            // 
            this.text_nr_intrebari.BackColor = System.Drawing.SystemColors.Window;
            this.text_nr_intrebari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_nr_intrebari.Location = new System.Drawing.Point(133, 192);
            this.text_nr_intrebari.MaxLength = 2;
            this.text_nr_intrebari.Name = "text_nr_intrebari";
            this.text_nr_intrebari.Size = new System.Drawing.Size(33, 22);
            this.text_nr_intrebari.TabIndex = 6;
            this.text_nr_intrebari.Text = "5";
            // 
            // button_incepe
            // 
            this.button_incepe.Location = new System.Drawing.Point(38, 231);
            this.button_incepe.Name = "button_incepe";
            this.button_incepe.Size = new System.Drawing.Size(84, 26);
            this.button_incepe.TabIndex = 7;
            this.button_incepe.Text = "Începe";
            this.button_incepe.UseVisualStyleBackColor = true;
            this.button_incepe.Click += new System.EventHandler(this.button_incepe_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(267, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(38, 24);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // player_teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 317);
            this.ControlBox = false;
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_incepe);
            this.Controls.Add(this.text_nr_intrebari);
            this.Controls.Add(this.label_nr_intrebari);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_reset_scor);
            this.Controls.Add(this.label_ultimul_scor);
            this.Controls.Add(this.label_max_scor);
            this.Controls.Add(this.text_nume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "player_teste";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nume;
        private System.Windows.Forms.Label label_max_scor;
        private System.Windows.Forms.Label label_ultimul_scor;
        private System.Windows.Forms.Button button_reset_scor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_nr_intrebari;
        private System.Windows.Forms.TextBox text_nr_intrebari;
        private System.Windows.Forms.Button button_incepe;
        private System.Windows.Forms.Button button_exit;
    }
}