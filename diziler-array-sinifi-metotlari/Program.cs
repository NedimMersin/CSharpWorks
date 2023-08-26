using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {23,12,4,2,14,53,23,4};
            foreach(var sayi in sayiDizisi){
                Console.WriteLine(sayi);
            }
            Array.Sort(sayiDizisi);
             foreach(var sayi in sayiDizisi){
                Console.WriteLine(sayi);
            }
            Array.Clear(sayiDizisi,2,2);
             foreach(var sayi in sayiDizisi){
                Console.WriteLine(sayi);
            }

            Array.Reverse(sayiDizisi);
             foreach(var sayi in sayiDizisi){
                Console.WriteLine(sayi);
            }
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach(var sayi in sayiDizisi){
                Console.WriteLine(sayi);
            }

        }
    }
}