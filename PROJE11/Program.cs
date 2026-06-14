using System;

namespace PROJE10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Metni Giriniz : ");
                string Metin = Console.ReadLine();

                string[] kelimeDizisi = Metin.Split(' ');
                string Kisaltma = "";

                foreach (string kelime in kelimeDizisi)
                {
                    if (!string.IsNullOrWhiteSpace(kelime))
                    {
                        Kisaltma += kelime[0].ToString() + ".";
                    }
                }

                Console.WriteLine(Kisaltma.ToUpper());
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