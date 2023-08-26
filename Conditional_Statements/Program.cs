using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time>=6 && time<11) 
                Console.WriteLine("İyi günler");
            else if(time<=18) 
                Console.WriteLine("İyi günler");
            else 
                Console.WriteLine("İyi geceler");
            string sonuc = time<=18 ? "İyi günler" : "İyi geceler";
            string sonuc = time>=6 && time<11 ? "Günaydın" : time<=18 ? "İyi günler" : "İyi geceler";
            
        }
    }
}