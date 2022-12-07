namespace OperadorTernario
{
    public class OperadorTernario
    {
        static void Main(string[] args)
        {
            int numero;

            numero = 10;
            Console.WriteLine(numero + " é " + 
                (numero % 2 == 0 ? "par" : "impar"));
            Console.WriteLine(new string('-', 20));

            numero = 15;
            Console.WriteLine(numero + " é " +
                (numero % 2 == 0 ? "par" : "impar"));
            Console.WriteLine(new string('-', 20));

            Console.ReadKey();
        }
    }
}