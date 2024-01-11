using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s57
{
    public class kontact
    {
        public List<pin> pins = new List<pin>();
        public string type = "NO";
        public string denumire = "kontact";
        public kontact() { }
        public kontact(string pdenumire, string ptype) 
        { 
            this.denumire = pdenumire;
            this.type = ptype;
        }
    }
}
