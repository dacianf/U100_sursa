using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace U100
{
    public partial class ModificareIntrebari : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + @"\intrebari_test.accdb; Jet OLEDB:Database Password=test;");
        DataTable intrebari, raspunsuri;
        List<clasa_intrabari_rsp> listaIntrebariBD = new List<clasa_intrabari_rsp>();
        List<string> texteIntrebari = new List<string>();

        int numarInrebari;
        public ModificareIntrebari()
        {

            InitializeComponent();
        
        }

        private void ModificareIntrebari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intrebari_DataSet.Raspunsuri' table. You can move, or remove it, as needed.
            this.raspunsuriTableAdapter.Connection.ConnectionString = this.raspunsuriTableAdapter.Connection.ConnectionString + "; Jet OLEDB:Database Password=test;";
            this.raspunsuriTableAdapter.Fill(this.intrebari_DataSet.Raspunsuri);
            // TODO: This line of code loads data into the 'intrebari_DataSet.Intrebari' table. You can move, or remove it, as needed.
            this.intrebariTableAdapter.Connection.ConnectionString = this.intrebariTableAdapter.Connection.ConnectionString + ";Jet OLEDB:Database Password=test;";
            this.intrebariTableAdapter.Fill(this.intrebari_DataSet.Intrebari);
            intrebari = this.intrebari_DataSet.Intrebari;
            raspunsuri = this.intrebari_DataSet.Raspunsuri;
            functiiComune.incarcaIntrebariDinBD(ref listaIntrebariBD, intrebari, raspunsuri);
            
            numarInrebari = listaIntrebariBD.Count;
            for (int i = 0; i < numarInrebari; i++)
                texteIntrebari.Add(listaIntrebariBD[i].txtIntreb);
            listBox_intreabari.DataSource = texteIntrebari;
        }

        private void listBox_intreabari_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int crtIndex = listBox_intreabari.SelectedIndex;
            if (crtIndex > -1)
            {
                textBox_nr_rsp_cor.Text = listaIntrebariBD[crtIndex].nrRspCor.ToString();
                textBox_intrebare.Text = listaIntrebariBD[crtIndex].txtIntreb;
                textBox_raspuns1.Text = listaIntrebariBD[crtIndex].rsp[1].txtRaspunsuri;
                checkBox1.Checked = listaIntrebariBD[crtIndex].rsp[1].isCorect;
                textBox_raspuns2.Text = listaIntrebariBD[crtIndex].rsp[2].txtRaspunsuri;
                checkBox2.Checked = listaIntrebariBD[crtIndex].rsp[2].isCorect;
                textBox_raspuns3.Text = listaIntrebariBD[crtIndex].rsp[3].txtRaspunsuri;
                checkBox3.Checked = listaIntrebariBD[crtIndex].rsp[3].isCorect;
                textBox_raspuns4.Text = listaIntrebariBD[crtIndex].rsp[4].txtRaspunsuri;
                checkBox4.Checked = listaIntrebariBD[crtIndex].rsp[4].isCorect;
            }
        }

        private void button_adaugare_Click(object sender, EventArgs e)
        {
            string txtIntreb = textBox_intrebare.Text;
            if (esteDuplicat(txtIntreb) == false && campuriGoale() == false)
            {
                
                this.intrebariTableAdapter.Insert(textBox_intrebare.Text, Convert.ToInt32(textBox_nr_rsp_cor.Text));
                this.intrebariTableAdapter.Fill(this.intrebari_DataSet.Intrebari);

                int indexIntrebInBD = 0;
                if (numarInrebari > 0)
                {
                    indexIntrebInBD = Convert.ToInt32(intrebari.Rows[numarInrebari - 1][0].ToString());
                    indexIntrebInBD++;//indexare de la 0
                }
                else indexIntrebInBD = Convert.ToInt32(intrebari.Rows[numarInrebari][0].ToString());
                

                this.raspunsuriTableAdapter.Insert(indexIntrebInBD, textBox_raspuns1.Text, checkBox1.Checked);
                this.raspunsuriTableAdapter.Insert(indexIntrebInBD, textBox_raspuns2.Text, checkBox2.Checked);
                this.raspunsuriTableAdapter.Insert(indexIntrebInBD, textBox_raspuns3.Text, checkBox3.Checked);
                this.raspunsuriTableAdapter.Insert(indexIntrebInBD, textBox_raspuns4.Text, checkBox4.Checked);
                this.raspunsuriTableAdapter.Fill(this.intrebari_DataSet.Raspunsuri);

                adaugaInLista(ref listaIntrebariBD, numarInrebari);
                //reîmprostpătare listă întrebări
                listBox_intreabari.DataSource = null;
                listBox_intreabari.DataSource = texteIntrebari;
                
                //numarInrebari++;
            }
            else if (esteDuplicat(txtIntreb) == true) MessageBox.Show("Această întrebare există deja în baza de date");
            else MessageBox.Show("Nu ați completat toate câmpurile");
        }

        private void button_modificare_Click(object sender, EventArgs e)
        {
            if (campuriGoale() == false)
            {
                //modificare intrebare in lista interna
                int crtIndex = listBox_intreabari.SelectedIndex;
                adaugaInLista(ref listaIntrebariBD, crtIndex);

                //modificare intrebare in baza de date
                intrebari.Rows[crtIndex][1] = textBox_intrebare.Text;
                intrebari.Rows[crtIndex][2] = Convert.ToInt32(textBox_nr_rsp_cor.Text);
                int indexRsp = 4 * crtIndex;
                raspunsuri.Rows[indexRsp][2] = textBox_raspuns1.Text;
                raspunsuri.Rows[indexRsp][3] = checkBox1.Checked;
                raspunsuri.Rows[indexRsp+1][2] = textBox_raspuns2.Text;
                raspunsuri.Rows[indexRsp+1][3] = checkBox2.Checked;
                raspunsuri.Rows[indexRsp+2][2] = textBox_raspuns3.Text;
                raspunsuri.Rows[indexRsp+2][3] = checkBox3.Checked;
                raspunsuri.Rows[indexRsp+3][2] = textBox_raspuns4.Text;
                raspunsuri.Rows[indexRsp+3][3] = checkBox4.Checked;

                this.intrebariTableAdapter.Update(this.intrebari_DataSet.Intrebari);
                this.raspunsuriTableAdapter.Update(this.intrebari_DataSet.Raspunsuri);
                
                //modificare intrebare in lista de intrebari afisate
                texteIntrebari[crtIndex] = textBox_intrebare.Text;
                
                //reîmprostpătare listă întrebări
                listBox_intreabari.DataSource = null;
                listBox_intreabari.DataSource = texteIntrebari;

            }
            else MessageBox.Show("Vă rugăm să completați toate câmpurile.");
        }

        private void button_sterge_Click(object sender, EventArgs e)
        {
            if (!campuriGoale())
            {
                int indexIntrebBD = Convert.ToInt32(intrebari.Rows[listBox_intreabari.SelectedIndex][0].ToString());
                int indexIntrebLista = listBox_intreabari.SelectedIndex;
                intrebari.Rows[indexIntrebLista].Delete();
                raspunsuri.Rows[4 * indexIntrebLista].Delete();
                raspunsuri.Rows[4 * indexIntrebLista + 1].Delete();
                raspunsuri.Rows[4 * indexIntrebLista + 2].Delete();
                raspunsuri.Rows[4 * indexIntrebLista + 3].Delete();

                this.raspunsuriTableAdapter.Update(this.intrebari_DataSet.Raspunsuri);
                this.intrebariTableAdapter.Update(this.intrebari_DataSet.Intrebari);

                texteIntrebari.RemoveAt(indexIntrebLista);
                listaIntrebariBD.RemoveAt(indexIntrebLista);

                listBox_intreabari.DataSource = null;
                listBox_intreabari.DataSource = texteIntrebari;
                button_curataCampuri.PerformClick();
                numarInrebari--;
            }
            else MessageBox.Show("Toate câmpurile trebuie completate corespunzător.");
        }

        private void butt_exit_Click(object sender, EventArgs e)
        {
            Form test = new testare();
            test.Show();
            this.Close();
        }

        private void butt_exit_MouseEnter(object sender, EventArgs e)
        {
            butt_exit.BackgroundImage = U100.Properties.Resources._2_buton_iesire;
        }

        private void butt_exit_MouseLeave(object sender, EventArgs e)
        {
            butt_exit.BackgroundImage = U100.Properties.Resources._3_buton_iesire;
        }

        bool esteDuplicat(string intrebareCautata)
        {
            for (int i = 0; i < numarInrebari; i++)
                if (string.Equals(intrebareCautata, listaIntrebariBD[i].txtIntreb, StringComparison.OrdinalIgnoreCase) == true) return true;
            return false;
        }

        private void textBox_nr_rsp_cor_TextChanged(object sender, EventArgs e)
        {
            if (textBox_nr_rsp_cor.TextLength!=0 && !(textBox_nr_rsp_cor.Text[0]>='0' && textBox_nr_rsp_cor.Text[0]<'5'))
            {
                textBox_nr_rsp_cor.Clear();
                MessageBox.Show("În acest câmp se introduce un număr între 0 si 4");
            }
        }

        private void button_curataCampuri_Click(object sender, EventArgs e)
        {
            textBox_intrebare.Clear();
            textBox_raspuns1.Clear();
            textBox_raspuns2.Clear();
            textBox_raspuns3.Clear();
            textBox_raspuns4.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            textBox_nr_rsp_cor.Text = "1";
        }

        bool campuriGoale()
        {
            int k = 0;
            if (checkBox1.Checked) k++;
            if (checkBox2.Checked) k++;
            if (checkBox3.Checked) k++;
            if (checkBox4.Checked) k++;
            if (textBox_intrebare.TextLength == 0 ||
                textBox_raspuns1.TextLength == 0 ||
                textBox_raspuns2.TextLength == 0 ||
                textBox_raspuns3.TextLength == 0 ||
                textBox_raspuns4.TextLength == 0 || 
                k.ToString() != textBox_nr_rsp_cor.Text) return true;
            return false;
        }

        private void ModificareIntrebari_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        void adaugaInLista(ref List<clasa_intrabari_rsp> intrebariBD, int crtIndex)
        {
            if (crtIndex >= numarInrebari)
            {
                listaIntrebariBD.Add(new clasa_intrabari_rsp());
                texteIntrebari.Add(textBox_intrebare.Text);
                numarInrebari++;
            }
            listaIntrebariBD[crtIndex].nrRspCor = Convert.ToInt32(textBox_nr_rsp_cor.Text);
            listaIntrebariBD[crtIndex].txtIntreb = textBox_intrebare.Text;
            listaIntrebariBD[crtIndex].rsp[1].txtRaspunsuri = textBox_raspuns1.Text;
            listaIntrebariBD[crtIndex].rsp[1].isCorect = checkBox1.Checked;
            listaIntrebariBD[crtIndex].rsp[2].txtRaspunsuri = textBox_raspuns2.Text;
            listaIntrebariBD[crtIndex].rsp[2].isCorect = checkBox2.Checked;
            listaIntrebariBD[crtIndex].rsp[3].txtRaspunsuri = textBox_raspuns3.Text;
            listaIntrebariBD[crtIndex].rsp[3].isCorect = checkBox3.Checked;
            listaIntrebariBD[crtIndex].rsp[4].txtRaspunsuri = textBox_raspuns4.Text;
            listaIntrebariBD[crtIndex].rsp[4].isCorect = checkBox4.Checked;
        }
    }
}
