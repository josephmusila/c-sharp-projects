using System;
using System.Collections.Generic;
using System.Text;

namespace objects
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.Write("the chef makes chicken");
        }
        public void MakeSoup()
        {
            Console.Write("the chef makes soup");
        }
        public virtual void MakeSpecialSoup()
        {
            Console.Write("the chef makes bbq ribs");
        }
    }
}
