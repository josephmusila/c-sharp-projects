using System.Reflection.Metadata;
using System;

namespace CS3
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday","Green Day",200);
             Song kashmir=new Song("Kashmir","Led Zeppellin", 150);
             kashmir.Duration=654;
             System.Console.WriteLine(kashmir.Duration);
           System.Console.WriteLine(kashmir.getSongCount());
            Console.ReadLine();
        }
    }
}
