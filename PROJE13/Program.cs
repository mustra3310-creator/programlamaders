using System;

namespace PROJE13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Başlangıç Değerini Giriniz : ");
                int baslangic = Convert.ToInt32(Console.ReadLine());

                Console.Write("Bitiş Değerini Giriniz : ");
                int bitis = Convert.ToInt32(Console.ReadLine());

                string asalSayilar = "";
                for (int i = baslangic; i <= bitis; i++)
                {
                    if (i < 2) continue;

                    bool asalMi = true; 

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            asalMi = false;
                            break;
                        }
                    }

                    if (asalMi == true)
                    {
                        asalSayilar += i.ToString() + " ";
                    }
                }

                Console.WriteLine("\n{0} ile {1} arasındaki asal sayılar:", baslangic, bitis);
                Console.WriteLine(asalSayilar.Trim());
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.Message); 
            }
            finally
            {
                Console.WriteLine("\nKapatmak için bir tuşa basın...");
                Console.ReadKey();
            }
        }
    }
}