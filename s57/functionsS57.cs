using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s57
{
    public class functionsS57
    {
        public functionsS57() { }

        public int AND(int a, int b)
        {
            if (a == b)
            {
                if (a == 0 && b == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }

        public int OR(int a, int b)
        {
            if (a == 1 || b == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            
        }

        public int NOT(int a)
        {
            if (a == 0 )
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public int  BUFFER(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public int NAND(int a, int b)
        {
            if (a == b)
            {
                if (a == 0 && b == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 1;
            }
        }

        public int XOR(int a, int b)
        {
            if (a == 1 || b == 1)
            {
                if (a != b)
                {
                    return 1;
                }
                else {
                    return 0; 
                }
            }
            else
            {
                return 0;
            }

        }
        public int XNOR(int a, int b)
        {
            if (a == 1 || b == 1)
            {
                if (a != b)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 1;
            }

        }
        //timer
        //comparator
        //other
    }
}
