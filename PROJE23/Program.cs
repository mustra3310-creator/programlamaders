using System;
using System.IO;

namespace PROJE21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                // Dosya yolunun doğruluğundan emin olun (Örn: D:\Sample.txt)
                StreamReader sr = new StreamReader("D:\\Sample.txt");

                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}