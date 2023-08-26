using System;

namespace Program // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           byte d = 5; //1 byte
           sbyte sb = 5; //1 byte

           short sh = 5; //2 byte
           ushort us = 5; //2 byte

           Int16 a = 2; //2 byte
           int b = 5; //4 byte
           Int32 c = 5; //4 byte
           Int64 d = 2; //8 byte

           uint e = 2; //4 byte
           long f = 4; //8 byte

           ulong g = 5; //8 byte

           //reel
           float fl = 5; //4 byte
           double dbb = 5; //8 byte
           decimal dec = 5; //16 byte

           char chh ='2'; //2 byte
           string strr = "g"; // belleksiz

           DateTime dt = DateTime.Now;
           Console.WriteLine(dt+" "+strr);

            object o1 = "x";
            object o2 = "y";
            object o3 = 2;
            object o4 = 4.1;

            //string ifadeler
            string str1 = string.Empty;  // or null
            str1 = "fa";
            string name = "Ferid";
            string soyad = "Akşahin";
            string full_name = name+" "+soyad;

            //integer
            int vx=5;
            int bf=3;
            int multiple=vx*bf;

            //boolean

            bool b1 = 10<2; //return false

            //degisken dönüsümleri

            string str20 = "20";
            int int20 = 20;
            string new_value = str20 + int20.ToString();
            Console.WriteLine(new_value); //output 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(new_value); //output 40

            int int22 = int20 + int.Parse(str20); //output 40 

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string datetime3 = DateTime.Now.ToString("HH:mm"); //saat:dakika
            Console.WriteLine(datetime3);





        }
    }
}