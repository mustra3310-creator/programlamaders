using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PROJE19
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                Console.Write("Lütfen sorgulamak istediğiniz bilgisayar terimini giriniz: ");
                string terim = Console.ReadLine();

                string url = $"https://sozluk.gov.tr/gts?ara={terim}";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "ConsoleApp");
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string sonuc = await response.Content.ReadAsStringAsync();

                        if (string.IsNullOrEmpty(sonuc) || sonuc.Contains("error") || sonuc == "[]")
                        {
                            Console.WriteLine("\nAradığınız terim TDK kılavuzunda bulunamadı.");
                        }
                        else
                        {
                            Console.WriteLine("\n--- TDK Bilgisayar Terimleri Karşılığı ---");

                            if (sonuc.Contains("\"anlam\":\""))
                            {
                                string anahtar = "\"anlam\":\"";
                                int baslangic = sonuc.IndexOf(anahtar) + anahtar.Length;
                                int bitis = sonuc.IndexOf("\"", baslangic);
                                string asilAnlam = sonuc.Substring(baslangic, bitis - baslangic);

                                Console.WriteLine("ANLAM: " + asilAnlam);
                            }
                            else
                            {
                                Console.WriteLine(sonuc);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nHATA : {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("\nÇıkmak için bir tuşa basınız...");
                Console.ReadKey();
            }
        }
    }
}