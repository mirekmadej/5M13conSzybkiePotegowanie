namespace _5M13conSzybkiePotegowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine(szybkaPotega(4,6));
        }
        private static int szybkaPotega(int liczba, int wyk)
        {
            if (wyk == 1) return liczba;
            if (wyk % 2 == 0)
            {
                wyk = wyk / 2;
                int w = szybkaPotega(liczba, wyk);
                return w * w;
            }
            else
                return liczba * szybkaPotega(liczba, wyk - 1);
        }
    }
}
