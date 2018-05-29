using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U100
{
    public class clasa_intrabari_rsp
    {
        public int nrInt, nrRspCor;
        public string txtIntreb;
        public raspunsuri[] rsp = new raspunsuri[]
            {
                new raspunsuri(),
                new raspunsuri(),
                new raspunsuri(),
                new raspunsuri(),
                new raspunsuri()
            };
            
    }
    
    public class raspunsuri
    {
        public int nrIntreb;
        public bool isCorect;
        public string txtRaspunsuri;
    }
}
