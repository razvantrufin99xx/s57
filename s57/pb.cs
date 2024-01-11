using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s57
{
    public class pb
    {

        public string denumire = "programbloc";

        public pinslist thepinslist = new pinslist();
        public List<gate> thegateslist = new List<gate>();
        public List<wire> thewires = new List<wire>();
        public List<outload> theoutloads = new List<outload>();
        public List<kontact> thekontantors = new List<kontact>();


        public pb() { }
        public pb(string pdenumire)
        {
            this.denumire = pdenumire;
        }

        
      

    }
}
