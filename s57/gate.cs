using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s57
{
    public class gate
    {
        public List<pin> InputPins = new List<pin>();
        public List<pin> OutputPins = new List<pin>();
        public string denumire = "gate";
        public string type = "AND";
        public int x = 10;
        public int y = 10;
        public int w = 10;
        public int h = 10;
        public Color c = Color.Black;
        public gate() { }
        public gate(string denumire, string ptype,int px, int py, int pw, int ph)
        {
            this.denumire = denumire;
            this.type = ptype;
            this.x = px;
            this.y = py;
            this.w = pw;
            this.h = ph;
        }
    }
}
