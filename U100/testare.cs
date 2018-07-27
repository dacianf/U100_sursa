using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;

namespace U100
{
    public partial class testare : Form 
    {
        DataTable intrebari, raspunsuri;
        List<clasa_intrabari_rsp> listaIntrebariAlese = new List<clasa_intrabari_rsp>();
        List<clasa_intrabari_rsp> listaIntrebariBD = new List<clasa_intrabari_rsp>();
        List<clasa_intrabari_rsp> listaIntrebariGresite = new List<clasa_intrabari_rsp>();
        public static int nr_intrebariBD, nrIntrebariDorite;
        public int puncte = 0;
        public int indiceIntrebare = 0;
        public int nrIntrebGres = 0, kIntbGres = 0;
        public testare()
        {
            InitializeComponent();

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Form mf = new main();
            mf.Show();
            this.Close();
        }

        private void testare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intrebari_DataSet.Raspunsuri' table. You can move, or remove it, as needed.
            this.raspunsuriTableAdapter.Connection.ConnectionString = this.raspunsuriTableAdapter.Connection.ConnectionString + ";Jet OLEDB:Database Password=test;";
            this.raspunsuriTableAdapter.Fill(this.intrebari_DataSet.Raspunsuri);
            // TODO: This line of code loads data into the 'intrebari_DataSet.Intrebari' table. You can move, or remove it, as needed.
            this.intrebariTableAdapter.Connection.ConnectionString = this.intrebariTableAdapter.Connection.ConnectionString + ";Jet OLEDB:Database Password=test;";
            this.intrebariTableAdapter.Fill(this.intrebari_DataSet.Intrebari);
            Point pct = new Point();
            pct.X = this.Width/2 - panel_startIntreb.Width / 2;
            pct.Y = this.Height/2 - panel_startIntreb.Height / 2;
            panel_startIntreb.Location = pct;
            
        }

        void incepeTest(int k)
        {
            intrebari = this.intrebari_DataSet.Intrebari;
            raspunsuri = this.intrebari_DataSet.Raspunsuri;

            nr_intrebariBD = new int();
            nrIntrebariDorite = new int();

            nrIntrebariDorite = k;
            nr_intrebariBD = intrebari.Rows.Count;

            if (nrIntrebariDorite > nr_intrebariBD)
            {
                nrIntrebariDorite = nr_intrebariBD;
                MessageBox.Show("Ați introdus un număr mai mare decât numărul \nde întrebări posibile, iar în acest caz se"
                    + " vor afișa\n" + nr_intrebariBD+" intrebari, acesta fiind numărul total de întrebări existent.");
            }
            
            functiiComune.incarcaIntrebariDinBD(ref listaIntrebariBD,intrebari,raspunsuri);
            alegeIntrebari(nrIntrebariDorite, ref listaIntrebariAlese);
            afiseazaIntrebare(0, listaIntrebariAlese);
            label_nrIntrebari.Text = label_nrIntrebari.Text + nrIntrebariDorite.ToString();
        }

        
        void afiseazaIntrebare(int x, List<clasa_intrabari_rsp> intrebareAfis)
        {
            text_intrebare.Text = intrebareAfis.ElementAt(x).txtIntreb.ToString();
            checkBox1.Text = intrebareAfis.ElementAt(x).rsp[1].txtRaspunsuri.ToString();
            checkBox2.Text = intrebareAfis.ElementAt(x).rsp[2].txtRaspunsuri.ToString();
            checkBox3.Text = intrebareAfis.ElementAt(x).rsp[3].txtRaspunsuri.ToString();
            checkBox4.Text = intrebareAfis.ElementAt(x).rsp[4].txtRaspunsuri.ToString();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            if(button_next.Visible==true)amestecareRaspunsuri();
        }

        void afiseazaIntrebareGresita(int x, List<clasa_intrabari_rsp> intrebareAfis)
        {

            afiseazaIntrebare(kIntbGres, listaIntrebariGresite);
            checkBox1.Checked = listaIntrebariGresite.ElementAt(kIntbGres).rsp[1].isCorect;
            checkBox2.Checked = listaIntrebariGresite.ElementAt(kIntbGres).rsp[2].isCorect;
            checkBox3.Checked = listaIntrebariGresite.ElementAt(kIntbGres).rsp[3].isCorect;
            checkBox4.Checked = listaIntrebariGresite.ElementAt(kIntbGres).rsp[4].isCorect;
        }

        private void button_next_Click(object sender, EventArgs e)
        {//funcția ce definește ce face butonul următoarea întrebare
            //Daca s-a raspuns corect adunam 10 puncte
            if (checkBox1.Checked == listaIntrebariAlese.ElementAt(indiceIntrebare).rsp[1].isCorect &&
                checkBox2.Checked == listaIntrebariAlese.ElementAt(indiceIntrebare).rsp[2].isCorect &&
                checkBox3.Checked == listaIntrebariAlese.ElementAt(indiceIntrebare).rsp[3].isCorect &&
                checkBox4.Checked == listaIntrebariAlese.ElementAt(indiceIntrebare).rsp[4].isCorect) puncte += 10;
            //Daca s-a raspuns grestit adaugam intrebarea corespunzatoare in lista cu intrebari gresite
            else listaIntrebariGresite.Add(listaIntrebariAlese.ElementAt(indiceIntrebare));
            if (indiceIntrebare + 1 < nrIntrebariDorite) afiseazaIntrebare(++indiceIntrebare, listaIntrebariAlese);
            else //daca s-a ajuns la ultima întrebare afișăm scorul
            {
                button_next.Visible = false;
                if (puncte > 0 && puncte != nrIntrebariDorite * 10)
                {
                    label_final_intrebari.Text = label_final_intrebari.Text + puncte + " puncte. Felicitări!!!";
                    button_intrebGres.Visible = true;
                }
                else if (puncte == nrIntrebariDorite * 10)
                {
                    label_final_intrebari.Text = "Felicitări!!! Ai răspuns corect la toate întrbările și ai obținut " + puncte + ".";
                    button_retry.Visible = true;
                }
                else { label_final_intrebari.Text = "Ai obținut " + puncte + " puncte. Mai citește puțin!"; button_intrebGres.Visible = true; }
                label_final_intrebari.Visible = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
            
        }

        private void button_exit_MouseEnter(object sender, EventArgs e)
        {
            button_exit.BackgroundImage = U100.Properties.Resources._2_buton_iesire;
        }

        private void button_exit_MouseLeave(object sender, EventArgs e)
        {
            button_exit.BackgroundImage = U100.Properties.Resources._3_buton_iesire;
        }

        void alegeIntrebari(int nIntrebari,ref List<clasa_intrabari_rsp> listaIntrebari)
        {
            int[] vectNumRdn = new int[nIntrebari + 1];
            vectNumRdn = gasireNumereAleatorii(nr_intrebariBD);
            //Daca numarul dat de intrebari dorite este mai mare decâ numarul total de întrebări
            //atunci punem in nIntrebari numărul total de întrebări
            if (nIntrebari > listaIntrebariBD.Count()) nIntrebari = listaIntrebariBD.Count();
            int k = 0;
            while(k<nIntrebari)
            {
                listaIntrebari.Add(listaIntrebariBD.ElementAt(vectNumRdn[k]));
                k++;
            }
        }
        
        int[] gasireNumereAleatorii(int kNumere)
        {
            int[] vectorNumereAleatorii = new int[kNumere+1],
            frcv = new int[nr_intrebariBD+1];
            frcv.Initialize();
            int nr = 0, k = 0;
            RNGCryptoServiceProvider nrRdn = new RNGCryptoServiceProvider();
            byte[] rndNo = new byte[5];
            while (k < kNumere)
            {
                nrRdn.GetBytes(rndNo);//generez un sir aleatoriu de byts
                nr = Math.Abs(BitConverter.ToInt32(rndNo, 0) % kNumere);
                //convertesc in int numarul generat aleator iar, 
                //modulul său, modulo numărul de întrebări îl memorez în "nr"
                if (frcv[nr] == 0) {frcv[nr] = k + 1;vectorNumereAleatorii[k] = nr; k++; }
                //folosesc un vector de frecvență pentru a verifica dacă un numar 
                //ales aleatoriu a mai fost sau nu ales pană acum
            }
            return vectorNumereAleatorii;
        }

        private void button_intrebGres_Click(object sender, EventArgs e)
        {
            label_final_intrebari.Visible = false;
            button_nxtWgQ.Visible = true;
            button_retry.Visible = true;
            button_intrebGres.Visible = false;
            button_next.Visible = false;

            nrIntrebGres = listaIntrebariGresite.Count;

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            if (nrIntrebGres > 0)
            {
                afiseazaIntrebareGresita(kIntbGres, listaIntrebariGresite);
                label_nrIntrebari.Text = "Numar întrebari: " + listaIntrebariGresite.Count.ToString();
                label_titlu_intrebGres.Visible = true;
            }
        }

        private void button_retry_Click(object sender, EventArgs e)
        {
            Form xF = new testare();
            xF.Show();
            this.Close();
        }

        private void button_nxtWgQ_Click(object sender, EventArgs e)
        {
            if (kIntbGres < nrIntrebGres-1) kIntbGres++;
            else kIntbGres = 0;
            afiseazaIntrebareGresita(kIntbGres, listaIntrebariGresite);
        }

        private void button_incepeTest_MouseEnter(object sender, EventArgs e)
        {
            button_incepeTest.BackgroundImage = U100.Properties.Resources._1_incepe;
        }

        private void button_incepeTest_MouseLeave(object sender, EventArgs e)
        {
            button_incepeTest.BackgroundImage = U100.Properties.Resources._2_incepe;
        }

        private void textBox_numarIntreb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if(!textBox_numarIntreb.Text.All(char.IsDigit))
            {
                MessageBox.Show("Introduce-ți un număr de cel mult 3 cifre.");
                textBox_numarIntreb.Text = string.Empty;
            }
        }

        private void panel_testare_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_modifyDB_Click(object sender, EventArgs e)
        {
            Form mod = new ModificareIntrebari();
            mod.Activate();
            mod.Show();
            this.Hide();
        }

        private void textBox_numarIntreb_TextChanged(object sender, EventArgs e)
        {
            if (!textBox_numarIntreb.Text.All(char.IsDigit))
            {
                MessageBox.Show("Introduce-ți un număr de cel mult 3 cifre.");
                textBox_numarIntreb.Text = string.Empty;
            }
        }

        private void button_incepeTest_Click(object sender, EventArgs e)
        {
            if (textBox_numarIntreb.Text.Length != 0 && textBox_numarIntreb.Text.All(char.IsDigit))
            {
                int nrIntrebDor = Convert.ToInt32(textBox_numarIntreb.Text);
                incepeTest(nrIntrebDor);
                panel_testare.Visible = true;
                panel_startIntreb.Visible = false;
            }
        }
        
        void amestecareRaspunsuri()
        {
            Point[] pozCheckBox = new Point[4];//creez un vector de puncte în care pun locația fiecărui checkbox
            pozCheckBox[0] = checkBox1.Location;
            pozCheckBox[1] = checkBox2.Location;
            pozCheckBox[2] = checkBox3.Location;
            pozCheckBox[3] = checkBox4.Location;
            int[] num = new int[4];
            num = gasireNumereAleatorii(4);//creez un vector cu indici aleatorii
            checkBox1.Location = pozCheckBox[num[0]];//schimb locația fiecărui checkbox cu o poziție nouă
            checkBox2.Location = pozCheckBox[num[1]];
            checkBox3.Location = pozCheckBox[num[2]];
            checkBox4.Location = pozCheckBox[num[3]];
        }
    }
}
