using System;

namespace Program   
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //impicit Conversion  aşağıdan yukarı otomatik yapılır
                byte a =5;
                sbyte b=4;
                short c =30;
                int d = a+b+c;
                Console.WriteLine(d);

                long h=d;
                Console.WriteLine(h);
                float i=h;
                Console.WriteLine(i);
                string e="feag";
                char f = 'k';
                object g=e+f+d;
                Console.WriteLine(g);

                //Explicit conversion yukardan aşağı 
                Console.WriteLine("** explicit");
                int x=4;
                byte y = (byte)x; //x byte dönüstürüldü
                Console.WriteLine(y);

                int z=510;
                byte t=(byte)z;
                Console.WriteLine(t);

                float w=3.2f;
                byte v = (byte)w;
                Console.WriteLine(v);

                Console.WriteLine("ToString metodu **");

                int xx=5;
                string yy=xx.ToString();
                Console.WriteLine(yy);

                string zz =12.5f.ToString();
                Console.WriteLine(zz);

                Console.WriteLine("System.Convert**");

                string s1 = "11" , s2 = "20";
                int sayi1, sayi2;
                int sum;
                sayi1=Convert.ToInt32(s1);
                sayi2=Convert.ToInt32(s2);
                sum=sayi1+sayi2;
                Console.WriteLine(sum);


                Console.WriteLine("parse **");

                ParseMethod();
        }
        public static void ParseMethod(){ //parse string ifadeleri dönüstürmek için kullanılır ve hep string alır
            string label1="10";
            string label2="10.25";
            int rakam1;
            double db1;

            rakam1=Int32.Parse(label1); 
            db1=Double.Parse(label2);
            Console.WriteLine(rakam1);
            Console.WriteLine(db1);
        }
    }
}