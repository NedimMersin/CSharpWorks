using System;

namespace console_programming 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsim: ");
            string a = Console.ReadLine();
            Console.WriteLine("Soyisim: ");
            string b = Console.ReadLine();
            Console.WriteLine("Selam "+a+" "+b);

        }
    }
}