namespace U100
{
    partial class testare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testare));
            this.text_intrebare = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button_next = new System.Windows.Forms.Button();
            this.label_nrIntrebari = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.intrebari_DataSet = new U100.intrebari_DataSet();
            this.intrebariDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intrebariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intrebariTableAdapter = new U100.intrebari_DataSetTableAdapters.IntrebariTableAdapter();
            this.raspunsuriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raspunsuriTableAdapter = new U100.intrebari_DataSetTableAdapters.RaspunsuriTableAdapter();
            this.label_final_intrebari = new System.Windows.Forms.Label();
            this.button_intrebGres = new System.Windows.Forms.Button();
            this.button_nxtWgQ = new System.Windows.Forms.Button();
            this.button_retry = new System.Windows.Forms.Button();
            this.panel_startIntreb = new System.Windows.Forms.Panel();
            this.textBox_numarIntreb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_incepeTest = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel_testare = new System.Windows.Forms.Panel();
            this.label_titlu_intrebGres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.intrebari_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrebariDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrebariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspunsuriBindingSource)).BeginInit();
            this.panel_startIntreb.SuspendLayout();
            this.panel_testare.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_intrebare
            // 
            this.text_intrebare.AutoSize = true;
            this.text_intrebare.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_intrebare.Location = new System.Drawing.Point(91, 78);
            this.text_intrebare.Name = "text_intrebare";
            this.text_intrebare.Size = new System.Drawing.Size(124, 23);
            this.text_intrebare.TabIndex = 0;
            this.text_intrebare.Text = "Text intrebare";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(93, 161);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 27);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox2.Location = new System.Drawing.Point(93, 206);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(122, 27);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox3.Location = new System.Drawing.Point(93, 252);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(122, 27);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox4.Location = new System.Drawing.Point(93, 300);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(122, 27);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_next.Location = new System.Drawing.Point(323, 370);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(147, 48);
            this.button_next.TabIndex = 7;
            this.button_next.Text = "Următoarea întrebare";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label_nrIntrebari
            // 
            this.label_nrIntrebari.AutoSize = true;
            this.label_nrIntrebari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nrIntrebari.Location = new System.Drawing.Point(12, 9);
            this.label_nrIntrebari.Name = "label_nrIntrebari";
            this.label_nrIntrebari.Size = new System.Drawing.Size(116, 15);
            this.label_nrIntrebari.TabIndex = 8;
            this.label_nrIntrebari.Text = "Numar întrebari: ";
            // 
            // intrebari_DataSet
            // 
            this.intrebari_DataSet.DataSetName = "intrebari_DataSet";
            this.intrebari_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // intrebariDataSetBindingSource
            // 
            this.intrebariDataSetBindingSource.DataSource = this.intrebari_DataSet;
            this.intrebariDataSetBindingSource.Position = 0;
            // 
            // intrebariBindingSource
            // 
            this.intrebariBindingSource.DataMember = "Intrebari";
            this.intrebariBindingSource.DataSource = this.intrebariDataSetBindingSource;
            // 
            // intrebariTableAdapter
            // 
            this.intrebariTableAdapter.ClearBeforeFill = true;
            // 
            // raspunsuriBindingSource
            // 
            this.raspunsuriBindingSource.DataMember = "Raspunsuri";
            this.raspunsuriBindingSource.DataSource = this.intrebariDataSetBindingSource;
            // 
            // raspunsuriTableAdapter
            // 
            this.raspunsuriTableAdapter.ClearBeforeFill = true;
            // 
            // label_final_intrebari
            // 
            this.label_final_intrebari.AutoSize = true;
            this.label_final_intrebari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_final_intrebari.Location = new System.Drawing.Point(44, 393);
            this.label_final_intrebari.Name = "label_final_intrebari";
            this.label_final_intrebari.Size = new System.Drawing.Size(466, 25);
            this.label_final_intrebari.TabIndex = 9;
            this.label_final_intrebari.Text = "Ați ajuns la finalul întrebărilor si ați obținut ";
            this.label_final_intrebari.Visible = false;
            // 
            // button_intrebGres
            // 
            this.button_intrebGres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_intrebGres.Location = new System.Drawing.Point(288, 439);
            this.button_intrebGres.Name = "button_intrebGres";
            this.button_intrebGres.Size = new System.Drawing.Size(227, 77);
            this.button_intrebGres.TabIndex = 10;
            this.button_intrebGres.Text = "Afișează întrebările la care ai răspuns greșit";
            this.button_intrebGres.UseVisualStyleBackColor = true;
            this.button_intrebGres.Visible = false;
            this.button_intrebGres.Click += new System.EventHandler(this.button_intrebGres_Click);
            // 
            // button_nxtWgQ
            // 
            this.button_nxtWgQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_nxtWgQ.Location = new System.Drawing.Point(323, 369);
            this.button_nxtWgQ.Name = "button_nxtWgQ";
            this.button_nxtWgQ.Size = new System.Drawing.Size(147, 47);
            this.button_nxtWgQ.TabIndex = 11;
            this.button_nxtWgQ.Text = "Următoarea întrebare";
            this.button_nxtWgQ.UseVisualStyleBackColor = true;
            this.button_nxtWgQ.Visible = false;
            this.button_nxtWgQ.Click += new System.EventHandler(this.button_nxtWgQ_Click);
            // 
            // button_retry
            // 
            this.button_retry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_retry.Location = new System.Drawing.Point(288, 439);
            this.button_retry.Name = "button_retry";
            this.button_retry.Size = new System.Drawing.Size(227, 77);
            this.button_retry.TabIndex = 12;
            this.button_retry.Text = "Încearca din nou";
            this.button_retry.UseVisualStyleBackColor = true;
            this.button_retry.Visible = false;
            this.button_retry.Click += new System.EventHandler(this.button_retry_Click);
            // 
            // panel_startIntreb
            // 
            this.panel_startIntreb.Controls.Add(this.textBox_numarIntreb);
            this.panel_startIntreb.Controls.Add(this.textBox1);
            this.panel_startIntreb.Controls.Add(this.label1);
            this.panel_startIntreb.Controls.Add(this.button_incepeTest);
            this.panel_startIntreb.Location = new System.Drawing.Point(208, 522);
            this.panel_startIntreb.Name = "panel_startIntreb";
            this.panel_startIntreb.Size = new System.Drawing.Size(332, 251);
            this.panel_startIntreb.TabIndex = 13;
            // 
            // textBox_numarIntreb
            // 
            this.textBox_numarIntreb.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_numarIntreb.Location = new System.Drawing.Point(143, 100);
            this.textBox_numarIntreb.MaxLength = 3;
            this.textBox_numarIntreb.Name = "textBox_numarIntreb";
            this.textBox_numarIntreb.Size = new System.Drawing.Size(44, 34);
            this.textBox_numarIntreb.TabIndex = 3;
            this.textBox_numarIntreb.Text = "5";
            this.textBox_numarIntreb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_numarIntreb.TextChanged += new System.EventHandler(this.textBox_numarIntreb_TextChanged);
            this.textBox_numarIntreb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numarIntreb_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(80, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(167, 58);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Scrie-ți numărul de întrebări dorite:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doriți să vă testați cunoștințele?";
            // 
            // button_incepeTest
            // 
            this.button_incepeTest.BackgroundImage = global::U100.Properties.Resources._2_incepe;
            this.button_incepeTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_incepeTest.FlatAppearance.BorderSize = 0;
            this.button_incepeTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_incepeTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_incepeTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_incepeTest.Location = new System.Drawing.Point(92, 179);
            this.button_incepeTest.Name = "button_incepeTest";
            this.button_incepeTest.Size = new System.Drawing.Size(136, 56);
            this.button_incepeTest.TabIndex = 0;
            this.button_incepeTest.UseVisualStyleBackColor = true;
            this.button_incepeTest.Click += new System.EventHandler(this.button_incepeTest_Click);
            this.button_incepeTest.MouseEnter += new System.EventHandler(this.button_incepeTest_MouseEnter);
            this.button_incepeTest.MouseLeave += new System.EventHandler(this.button_incepeTest_MouseLeave);
            // 
            // button_exit
            // 
            this.button_exit.BackgroundImage = global::U100.Properties.Resources._3_buton_iesire;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Location = new System.Drawing.Point(776, 513);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(109, 36);
            this.button_exit.TabIndex = 5;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            this.button_exit.MouseEnter += new System.EventHandler(this.button_exit_MouseEnter);
            this.button_exit.MouseLeave += new System.EventHandler(this.button_exit_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel_testare
            // 
            this.panel_testare.Controls.Add(this.label_titlu_intrebGres);
            this.panel_testare.Controls.Add(this.label_nrIntrebari);
            this.panel_testare.Controls.Add(this.text_intrebare);
            this.panel_testare.Controls.Add(this.button_intrebGres);
            this.panel_testare.Controls.Add(this.button_retry);
            this.panel_testare.Controls.Add(this.checkBox1);
            this.panel_testare.Controls.Add(this.button_next);
            this.panel_testare.Controls.Add(this.button_nxtWgQ);
            this.panel_testare.Controls.Add(this.label_final_intrebari);
            this.panel_testare.Controls.Add(this.checkBox2);
            this.panel_testare.Controls.Add(this.checkBox3);
            this.panel_testare.Controls.Add(this.checkBox4);
            this.panel_testare.Location = new System.Drawing.Point(0, 0);
            this.panel_testare.Name = "panel_testare";
            this.panel_testare.Size = new System.Drawing.Size(896, 516);
            this.panel_testare.TabIndex = 15;
            this.panel_testare.Visible = false;
            // 
            // label_titlu_intrebGres
            // 
            this.label_titlu_intrebGres.AutoSize = true;
            this.label_titlu_intrebGres.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_titlu_intrebGres.Location = new System.Drawing.Point(272, 25);
            this.label_titlu_intrebGres.Name = "label_titlu_intrebGres";
            this.label_titlu_intrebGres.Size = new System.Drawing.Size(268, 36);
            this.label_titlu_intrebGres.TabIndex = 13;
            this.label_titlu_intrebGres.Text = "Întrebările greșite";
            this.label_titlu_intrebGres.Visible = false;
            // 
            // testare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(897, 561);
            this.ControlBox = false;
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.panel_testare);
            this.Controls.Add(this.panel_startIntreb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "testare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verifică-ți cunoștințele!";
            this.Load += new System.EventHandler(this.testare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intrebari_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrebariDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrebariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raspunsuriBindingSource)).EndInit();
            this.panel_startIntreb.ResumeLayout(false);
            this.panel_startIntreb.PerformLayout();
            this.panel_testare.ResumeLayout(false);
            this.panel_testare.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label text_intrebare;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label_nrIntrebari;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource intrebariDataSetBindingSource;
        private intrebari_DataSet intrebari_DataSet;
        private System.Windows.Forms.BindingSource intrebariBindingSource;
        private intrebari_DataSetTableAdapters.IntrebariTableAdapter intrebariTableAdapter;
        private System.Windows.Forms.BindingSource raspunsuriBindingSource;
        private intrebari_DataSetTableAdapters.RaspunsuriTableAdapter raspunsuriTableAdapter;
        private System.Windows.Forms.Label label_final_intrebari;
        private System.Windows.Forms.Button button_intrebGres;
        private System.Windows.Forms.Button button_nxtWgQ;
        private System.Windows.Forms.Button button_retry;
        private System.Windows.Forms.Panel panel_startIntreb;
        private System.Windows.Forms.Button button_incepeTest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_numarIntreb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel_testare;
        private System.Windows.Forms.Label label_titlu_intrebGres;
    }
}