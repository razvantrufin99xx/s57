using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s57
{
    public class aps
    {

        public string denumire = "SiemensAutomatPrograms57";
        public functionsS57 fs57 = new functionsS57();

        public aps() { }
        public aps(string pdenumire) 
        { 
         this.denumire = pdenumire;
        }
        public List<pb>pbs = new List<pb>();

    }

}
