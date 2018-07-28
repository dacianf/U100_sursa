namespace U100
{
    partial class ModificareIntrebari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificareIntrebari));
            this.textBox_intrebare = new System.Windows.Forms.TextBox();
            this.textBox_raspuns1 = new System.Windows.Forms.TextBox();
            this.listBox_intreabari = new System.Windows.Forms.ListBox();
            this.intrebariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intrebari_DataSet = new U100.intrebari_DataSet();
            this.intrebariRaspunsuriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intrebariTableAdapter = new U100.intrebari_DataSetTableAdapters.IntrebariTableAdapter();
            this.raspunsuriTableAdapter = new U100.intrebari_DataSetTableAdapters.RaspunsuriTableAdapter();
            this.label_txt_intreb = new System.Windows.Forms.Label();
            this.label_nr_rsp_cor = new System.Windows.Forms.Label();
            this.textBox_nr_rsp_cor = new System.Windows.Forms.TextBox();
            this.label_esteCorect = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.butt_exit = new System.Windows.Forms.Button();
            this.button_adaugare = new System.Windows.Forms.Button();
            this.button_modificare = new System.Windows.Forms.Button();
            this.button_sterge = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox_raspuns2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox_raspuns3 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox_raspuns4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_curataCampuri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.intrebariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrebari_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrebariRaspunsuriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_intrebare
            // 
            this.textBox_intrebare.Location = new System.Drawing.Point(12, 56);
            this.textBox_intrebare.Multiline = true;
            this.textBox_intrebare.Name = "textBox_intrebare";
            this.textBox_intrebare.Size = new System.Drawing.Size(433, 80);
            this.textBox_intrebare.TabIndex = 0;
            // 
            // textBox_raspuns1
            // 
            this.textBox_raspuns1.Location = new System.Drawing.Point(12, 219);
            this.textBox_raspuns1.Multiline = true;
            this.textBox_raspuns1.Name = "textBox_raspuns1";
            this.textBox_raspuns1.Size = new System.Drawing.Size(393, 67);
            this.textBox_raspuns1.TabIndex = 1;
            // 
            // listBox_intreabari
            // 
            this.listBox_intreabari.AllowDrop = true;
            this.listBox_intreabari.ColumnWidth = 433;
            this.listBox_intreabari.FormattingEnabled = true;
            this.listBox_intreabari.HorizontalScrollbar = true;
            this.listBox_intreabari.Location = new System.Drawing.Point(501, 12);
            this.listBox_intreabari.Name = "listBox_intreabari";
            this.listBox_intreabari.Size = new System.Drawing.Size(375, 459);
            this.listBox_intreabari.TabIndex = 3;
            this.listBox_intreabari.SelectedIndexChanged += new System.EventHandler(this.listBox_intreabari_SelectedIndexChanged);
            // 
            // intrebariBindingSource
            // 
            this.intrebariBindingSource.DataMember = "Intrebari";
            this.intrebariBindingSource.DataSource = this.intrebari_DataSet;
            // 
            // intrebari_DataSet
            // 
            this.intrebari_DataSet.DataSetName = "intrebari_DataSet";
            this.intrebari_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // intrebariRaspunsuriBindingSource
            // 
            this.intrebariRaspunsuriBindingSource.DataMember = "IntrebariRaspunsuri";
            this.intrebariRaspunsuriBindingSource.DataSource = this.intrebariBindingSource;
            // 
            // intrebariTableAdapter
            // 
            this.intrebariTableAdapter.ClearBeforeFill = true;
            // 
            // raspunsuriTableAdapter
            // 
            this.raspunsuriTableAdapter.ClearBeforeFill = true;
            // 
            // label_txt_intreb
            // 
            this.label_txt_intreb.AutoSize = true;
            this.label_txt_intreb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_txt_intreb.Location = new System.Drawing.Point(28, 33);
            this.label_txt_intreb.Name = "label_txt_intreb";
            this.label_txt_intreb.Size = new System.Drawing.Size(111, 16);
            this.label_txt_intreb.TabIndex = 5;
            this.label_txt_intreb.Text = "Text întrebare";
            // 
            // label_nr_rsp_cor
            // 
            this.label_nr_rsp_cor.AutoSize = true;
            this.label_nr_rsp_cor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nr_rsp_cor.Location = new System.Drawing.Point(74, 149);
            this.label_nr_rsp_cor.Name = "label_nr_rsp_cor";
            this.label_nr_rsp_cor.Size = new System.Drawing.Size(178, 14);
            this.label_nr_rsp_cor.TabIndex = 6;
            this.label_nr_rsp_cor.Text = "Număr răspunsuri corecte: ";
            // 
            // textBox_nr_rsp_cor
            // 
            this.textBox_nr_rsp_cor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_nr_rsp_cor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_nr_rsp_cor.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nr_rsp_cor.Location = new System.Drawing.Point(245, 146);
            this.textBox_nr_rsp_cor.MaxLength = 1;
            this.textBox_nr_rsp_cor.Name = "textBox_nr_rsp_cor";
            this.textBox_nr_rsp_cor.Size = new System.Drawing.Size(19, 19);
            this.textBox_nr_rsp_cor.TabIndex = 7;
            this.textBox_nr_rsp_cor.Text = "1";
            this.textBox_nr_rsp_cor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_nr_rsp_cor.TextChanged += new System.EventHandler(this.textBox_nr_rsp_cor_TextChanged);
            // 
            // label_esteCorect
            // 
            this.label_esteCorect.AutoSize = true;
            this.label_esteCorect.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_esteCorect.Location = new System.Drawing.Point(12, 541);
            this.label_esteCorect.Name = "label_esteCorect";
            this.label_esteCorect.Size = new System.Drawing.Size(328, 13);
            this.label_esteCorect.TabIndex = 8;
            this.label_esteCorect.Text = "Dacă raspunsul este corect bifați casuța din dreptul său.";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(430, 498);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // butt_exit
            // 
            this.butt_exit.BackgroundImage = global::U100.Properties.Resources._3_buton_iesire;
            this.butt_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butt_exit.FlatAppearance.BorderSize = 0;
            this.butt_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butt_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt_exit.Location = new System.Drawing.Point(785, 512);
            this.butt_exit.Name = "butt_exit";
            this.butt_exit.Size = new System.Drawing.Size(100, 37);
            this.butt_exit.TabIndex = 10;
            this.butt_exit.UseVisualStyleBackColor = true;
            this.butt_exit.Click += new System.EventHandler(this.butt_exit_Click);
            this.butt_exit.MouseEnter += new System.EventHandler(this.butt_exit_MouseEnter);
            this.butt_exit.MouseLeave += new System.EventHandler(this.butt_exit_MouseLeave);
            // 
            // button_adaugare
            // 
            this.button_adaugare.Location = new System.Drawing.Point(514, 484);
            this.button_adaugare.Name = "button_adaugare";
            this.button_adaugare.Size = new System.Drawing.Size(75, 22);
            this.button_adaugare.TabIndex = 11;
            this.button_adaugare.Text = "Adaugă ";
            this.button_adaugare.UseVisualStyleBackColor = true;
            this.button_adaugare.Click += new System.EventHandler(this.button_adaugare_Click);
            // 
            // button_modificare
            // 
            this.button_modificare.Location = new System.Drawing.Point(651, 484);
            this.button_modificare.Name = "button_modificare";
            this.button_modificare.Size = new System.Drawing.Size(75, 22);
            this.button_modificare.TabIndex = 12;
            this.button_modificare.Text = "Modifică";
            this.button_modificare.UseVisualStyleBackColor = true;
            this.button_modificare.Click += new System.EventHandler(this.button_modificare_Click);
            // 
            // button_sterge
            // 
            this.button_sterge.Location = new System.Drawing.Point(785, 484);
            this.button_sterge.Name = "button_sterge";
            this.button_sterge.Size = new System.Drawing.Size(75, 22);
            this.button_sterge.TabIndex = 13;
            this.button_sterge.Text = "Șterge";
            this.button_sterge.UseVisualStyleBackColor = true;
            this.button_sterge.Click += new System.EventHandler(this.button_sterge_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(430, 246);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox_raspuns2
            // 
            this.textBox_raspuns2.Location = new System.Drawing.Point(12, 306);
            this.textBox_raspuns2.Multiline = true;
            this.textBox_raspuns2.Name = "textBox_raspuns2";
            this.textBox_raspuns2.Size = new System.Drawing.Size(393, 67);
            this.textBox_raspuns2.TabIndex = 14;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(430, 330);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox_raspuns3
            // 
            this.textBox_raspuns3.Location = new System.Drawing.Point(12, 389);
            this.textBox_raspuns3.Multiline = true;
            this.textBox_raspuns3.Name = "textBox_raspuns3";
            this.textBox_raspuns3.Size = new System.Drawing.Size(393, 67);
            this.textBox_raspuns3.TabIndex = 16;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(430, 412);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox_raspuns4
            // 
            this.textBox_raspuns4.Location = new System.Drawing.Point(12, 471);
            this.textBox_raspuns4.Multiline = true;
            this.textBox_raspuns4.Name = "textBox_raspuns4";
            this.textBox_raspuns4.Size = new System.Drawing.Size(393, 67);
            this.textBox_raspuns4.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "Text răspunsuri";
            // 
            // button_curataCampuri
            // 
            this.button_curataCampuri.Location = new System.Drawing.Point(370, 137);
            this.button_curataCampuri.Name = "button_curataCampuri";
            this.button_curataCampuri.Size = new System.Drawing.Size(75, 38);
            this.button_curataCampuri.TabIndex = 21;
            this.button_curataCampuri.Text = "Curăță Câmpurile";
            this.button_curataCampuri.UseVisualStyleBackColor = true;
            this.button_curataCampuri.Click += new System.EventHandler(this.button_curataCampuri_Click);
            // 
            // ModificareIntrebari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(897, 561);
            this.ControlBox = false;
            this.Controls.Add(this.button_curataCampuri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.textBox_raspuns4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox_raspuns3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_raspuns2);
            this.Controls.Add(this.button_sterge);
            this.Controls.Add(this.button_modificare);
            this.Controls.Add(this.button_adaugare);
            this.Controls.Add(this.butt_exit);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.label_esteCorect);
            this.Controls.Add(this.textBox_nr_rsp_cor);
            this.Controls.Add(this.label_nr_rsp_cor);
            this.Controls.Add(this.label_txt_intreb);
            this.Controls.Add(this.listBox_intreabari);
            this.Controls.Add(this.textBox_raspuns1);
            this.Controls.Add(this.textBox_intrebare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificareIntrebari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificareIntrebari";
            this.Load += new System.EventHandler(this.ModificareIntrebari_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModificareIntrebari_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.intrebariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrebari_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intrebariRaspunsuriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_intrebare;
        private System.Windows.Forms.TextBox textBox_raspuns1;
        private System.Windows.Forms.ListBox listBox_intreabari;
        private intrebari_DataSet intrebari_DataSet;
        private System.Windows.Forms.BindingSource intrebariBindingSource;
        private intrebari_DataSetTableAdapters.IntrebariTableAdapter intrebariTableAdapter;
        private System.Windows.Forms.BindingSource intrebariRaspunsuriBindingSource;
        private intrebari_DataSetTableAdapters.RaspunsuriTableAdapter raspunsuriTableAdapter;
        private System.Windows.Forms.Label label_txt_intreb;
        private System.Windows.Forms.Label label_nr_rsp_cor;
        private System.Windows.Forms.TextBox textBox_nr_rsp_cor;
        private System.Windows.Forms.Label label_esteCorect;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button butt_exit;
        private System.Windows.Forms.Button button_adaugare;
        private System.Windows.Forms.Button button_modificare;
        private System.Windows.Forms.Button button_sterge;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox_raspuns2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox_raspuns3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox_raspuns4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_curataCampuri;
    }
}