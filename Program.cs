namespace Ser2Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());
            Suma(n);
            Console.WriteLine();
            long produs = Produs(n);
            Console.WriteLine($"Produsul numerelor de la 1 la {n} este {produs}");
        }

        static void Suma(int n)
        {
            int suma = ((1 + n) * n) / 2;
            Console.WriteLine($"Suma numerelor de la 1 la {n} este {suma}");
        }

        static long Produs(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * (Produs(n - 1));

            } 
        }
    }
}
