namespace PROJE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı Giriniz : ");
            string Metin1 = Console.ReadLine();

            Console.Write("2. Sayıyı Giriniz : ");
            string Metin2 = Console.ReadLine();

            int Sayi1 = Convert.ToInt32(Metin1);
            int Sayi2 = Convert.ToInt32(Metin2);

            int Sonuc = Sayi1 + Sayi2;

            Console.WriteLine(Sonuc.ToString());
        }
    }
}