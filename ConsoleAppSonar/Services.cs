using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSonar
{
    public class Services
    {
        public int Calculate(int a, int b)
        {
            if (a > b)
                return a - b;
            else
                return a + b;
        }

        public int Add(int a, int b)
        {
            a = 12;
            int c = 9;
            if(a<c)
                return a + b;
            return c;
        }

        public int AddTwo(int a, int b)
        {
            //int c = 9;
            int c = 9;
            if (a > b)
                return a - b;
            else
                return a + b;
        }
    }
}
