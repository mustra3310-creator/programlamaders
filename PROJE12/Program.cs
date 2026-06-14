using System;

namespace PROJE11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Sayıyı Giriniz : ");
                string Metin = Console.ReadLine();
                int Sayi = Convert.ToInt32(Metin);

                bool AsalMi = true;

                for (int i = 2; i < Sayi; i++)
                {
                    if (Sayi % i == 0)
                    {
                        AsalMi = false;
                        break; 
                    }
                }

                if (AsalMi == true)
                {
                    Console.WriteLine("{0} sayısı asaldır.", Sayi);
                }
                else
                {
                    Console.WriteLine("{0} sayısı asal değildir.", Sayi);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}