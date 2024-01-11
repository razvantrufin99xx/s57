using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s57
{
    public class outload
    {
        public string denumire = "output";
        public float rezistance = 5.0f;
        public outload(string pdenumire, float pr)
        {
            this.denumire = pdenumire;
            this.rezistance = pr;

        }
        public outload() { }
    }
}
