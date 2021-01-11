using System;
using System.Collections.Generic;
using System.Text;

namespace objects
{
    class Teacher
    {
        public void CanRead()
        {
            Console.Write("he can read");
        }
        public void CanWrite()
        {
            Console.Write("can write");
        }
        public virtual void CanTeach()
        {
            Console.Write("can tech");
        }
    }
}
