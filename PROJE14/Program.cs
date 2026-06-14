using System;

namespace PROJE14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Metni Giriniz : ");
                string Metin = Console.ReadLine();

                string TersMetin = "";

                for (int i = Metin.Length - 1; i >= 0; i--)
                {
                    TersMetin += Metin[i].ToString();
                }

                Console.WriteLine("Girilen \"{0}\" metninin tersten yazılışı \"{1}\".", Metin, TersMetin);
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}