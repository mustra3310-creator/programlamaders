using System;
using System.Threading;

namespace PROJE22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int DelayTime = 100;

                for (int i = 1; i <= 100; i++)
                {
                    Console.Clear();
                    Console.WriteLine("-");
                    Thread.Sleep(DelayTime);

                    Console.Clear();
                    Console.WriteLine("\\");
                    Thread.Sleep(DelayTime);

                    Console.Clear();
                    Console.WriteLine("|");
                    Thread.Sleep(DelayTime);

                    Console.Clear();
                    Console.WriteLine("/");
                    Thread.Sleep(DelayTime);
                }
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