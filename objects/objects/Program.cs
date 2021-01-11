using System;

namespace objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student musila = new Student();
            musila.CanTeach();
            Teacher Owira = new Teacher();
            Owira.CanTeach();
            Console.WriteLine();
        }
    }
}
