using System;
using System.Collections.Generic;
using System.Text;

namespace objects
{
    class Members
    {
        public string name;
        public string department;
        private int salary;

        public Members(string aName, string aDepartment, int aSalary)
        {
            name = aName;
            department = aDepartment;
            Salary = aSalary;



        }
                 
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value == 70000 || value == 90000)
                {
                    salary = value;

                }
                else
                {
                    salary = 0000;
                }
            }
        }
    }
}
