using System;

namespace console_programming 
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //try {
           //Console.WriteLine("Bir sayı giriniz");
           //int sayi = Convert.ToInt32(Console.ReadLine());
           //Console.WriteLine(sayi);
           //}catch(Exception ex) {
           //            Console.WriteLine("Hata: "+ex.Message.ToString());
           //}//finally {
            //Console.WriteLine("Completed");
            //}
            try {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-2435413513534");
            }
            catch(ArgumentException ex){
                Console.WriteLine("Boş değer girildi");
                Console.WriteLine(ex);
            }
            catch(FormatException ex){
                Console.WriteLine("Veri tipi geçersiz");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                Console.WriteLine("Sayı limitler içinde değil.");
                Console.WriteLine(ex);
            }
            finally {
                Console.WriteLine("Finished");
            }


        }
    }
}