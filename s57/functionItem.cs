using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s57
{
    public class functionItem
    {

        
        public string denumire = "function000001";
        public string type = "AND";
        public List<int> InputPins = new List<int>();
        public List<int> OutputPins = new List<int>();

        public functionItem() { }
        public functionItem(string denumire, string ptype)
        {
            this.denumire = denumire;
            this.type = ptype;
           
        }




    }
}
