using System;
using System.Collections.Generic;
using System.Text;

namespace objects
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialSoup()
        {
            Console.Write("the chef makes chicken parm");
        }
        public void MakePasta()
        {
            Console.Write("makes pasta");
        }
    }
}
