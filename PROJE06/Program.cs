using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int Sonuc = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Sonuc += i;
                }
            }

            Console.WriteLine("1 ile 10 arasındaki hem 2'ye hem de 3'e bölünen sayıların toplamı {0}'dır.", Sonuc);
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