using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("1. Sayıyı Giriniz : ");
            string Metin1 = Console.ReadLine();

            Console.Write("2. Sayıyı Giriniz : ");
            string Metin2 = Console.ReadLine();

            double Sayi1 = Convert.ToDouble(Metin1);
            double Sayi2 = Convert.ToDouble(Metin2);

            double Sonuc = (Sayi1 + Sayi2) / 2d;

            string Cikti = string.Format("{0} sayısı ile {1} sayısının aritmetik ortalaması {2}'dir.", Sayi1, Sayi2, Sonuc);
            Console.WriteLine(Cikti);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadKey();
        }
    }
}