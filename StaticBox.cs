using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2_2
{
    class StaticBox
    {
        public static void PrintList(List<Box> Elements)
        {
            foreach (Box box in Elements)
                box.Print();              
        }
    }
}
