using System;
using System.Collections.Generic;
using System.Text;

namespace objects
{
    class Student:Teacher
    {
        public override void CanTeach()
        {
            Console.Write("can learn");

        }
    }
}
