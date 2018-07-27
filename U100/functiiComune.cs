using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace U100
{
    public class functiiComune
    {
        public static void incarcaIntrebariDinBD(ref List<clasa_intrabari_rsp> intrebariBD, DataTable intrebari, DataTable raspunsuri)
        {
            int kIntreb = intrebari.Rows.Count;//in kintreb pun numarul de intrebari din baza de date
            for (int i = 0; i < kIntreb; i++)
            {
                clasa_intrabari_rsp intrebare = new clasa_intrabari_rsp();
                //creez obiectul "intrebare" de tip "clasa_intrebari_rsp" si adaug in el intrebarea "i" din baza de date
                intrebare.txtIntreb = intrebari.Rows[i]["Text Intrebare"].ToString();
                intrebare.nrInt = i;
                intrebare.nrRspCor = Convert.ToInt32(intrebari.Rows[i]["Nr Raspunsuri Corecte"].ToString());
                int idIntDB = Convert.ToInt32(intrebari.Rows[i]["ID"].ToString());
                for (int j = 0, k = 1; j < 4 * kIntreb && k <= 4; j++)
                {

                    if (Convert.ToInt32(raspunsuri.Rows[j]["idIntrebare"].ToString()) == idIntDB)
                    {
                        intrebare.rsp[k].txtRaspunsuri = raspunsuri.Rows[j]["Raspuns"].ToString();
                        intrebare.rsp[k].isCorect = Convert.ToBoolean(raspunsuri.Rows[j]["Corect"].ToString());
                        intrebare.rsp[k++].nrIntreb = i;
                    }
                }
                intrebariBD.Add(intrebare);//adaug noua intrebare in lista de intrebari
            }
        }

    }
}
