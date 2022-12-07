namespace SobrecargaConstrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa(100, 1.88);
            p1.Nome = "Juan";
            p1.Idade = 46;
            Console.WriteLine(p1.Altura);
            Console.WriteLine(p1.Peso);
            Console.WriteLine(p1.Nome);


        }
    }
}
