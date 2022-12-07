namespace OperadoresLogicos
{
    public class OperadoresLogicos
    {
        static void Main(string[] args)
        {
            int a = 30, b = 40, c = 50, d = 60;

            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.WriteLine($"d: {d}");
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("a < b || c == 50-- > " +(a < b || c == 50));
            Console.WriteLine("a < b || c == d-- > " +(a < b || c == d));
            Console.WriteLine("a > b || c == 50-- > " +(a > b || c == 50));
            Console.WriteLine("a > b || c == d-- > " +(a > b || c == d));
            Console.WriteLine(new string('-', 20));

            Console.WriteLine("a < b && c == 50-- > " +(a < b && c == 50));
            Console.WriteLine("a < b && c == d-- > " +(a < b && c == d));
            Console.WriteLine("a > b && c == 50-- > " +(a > b && c == 50));
            Console.WriteLine("a > b && c == d-- > " +(a > b && c == d));
            Console.WriteLine(new string('-', 20));

            Console.ReadKey();
        }
    }
}