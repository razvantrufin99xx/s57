using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace s57
{
    public class pin
    {
        public string denumire="pin";
        public string info="";
        public string comment = "";
        public int x=10;
        public int y=10;
        public Color c = Color.Black;
        public pin() { }
        public pin(string denumire, int px, int py)
        {
            this.denumire = denumire;
            this.x = px;
            this.y = py;
        }



    }
}
