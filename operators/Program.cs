using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //atama & işlemli atama
            int x = 3;
            int y= 4;
            y = y+2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);
            
            //mantıksal operatörler
            bool isSuccess=true;
            bool isCompleted=false;

            if(isSuccess && isCompleted) {
                Console.WriteLine("Good");
            }
            if(isSuccess || isCompleted) {
                Console.WriteLin("e");
            }
            if(isSuccess && !isCompleted) { //true && false
                Console.WriteLine("fine");
            }

            //ilişkisel operatörler
            Console.WriteLine("*** ***");

            int a =4;
            int b=3;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            //aritmetik
            Console.WriteLine("*** ***");
            int sayi1=10;
            int say2=5;
            int result = sayi1/say2;
            Console.WriteLine(result);
            result = sayi1*say2;
            Console.WriteLine(result);
            result = sayi1+say2;
            Console.WriteLine(result);
            result = sayi1-say2;
            Console.WriteLine(result);
            result = sayi1++;
            Console.WriteLine(result);

            //mod
            int result2=20%3;
            Console.WriteLine(result2);
        }
    }
}