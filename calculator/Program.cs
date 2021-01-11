using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine( GetUserNumber());
        }
        static double GetUserNumber()
        {
            System.Console.WriteLine("enter num1 : ");
            double num1=Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("enter num2 : ");
             double num2=Convert.ToDouble(Console.ReadLine());

            if (num1<num2)
            {
                double result=num1 + num2;
                return result;
            }
            else
            {
              double result=num1 -num2;
              return result;
                
            }
            
        }
    }
}
