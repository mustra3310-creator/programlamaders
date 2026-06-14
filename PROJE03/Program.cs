using System;

namespace PROJE3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int Sonuc = 0;

                for (int i = 1; i <= 10; i++)
                {
                    Sonuc += i;
                }

                Console.WriteLine("1 ile 10 arasındaki sayıların toplamı {0}", Sonuc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("\nProgram bitti. Kapatmak için bir tuşa basın...");
                Console.ReadKey();
            }
        }
    }
}