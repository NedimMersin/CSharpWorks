using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac<=sayi){
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            char c = 'a';
            while(c<'z'){
                Console.WriteLine(c);
                c++;
            }

            string [] arabalar {"Tofaş", "bmw", "audi", "nissan"};
            foreach(var item in arabalar){
                Console.WriteLine(arabalar);
            }
        }
    }
}