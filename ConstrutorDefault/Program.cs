namespace ConstrutorDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa1 = new Pessoa();

            pessoa.Nome = "Abigail";
            pessoa.Idade = 20;
            pessoa.Peso = 65;
            pessoa.Altura = 1.70;

            pessoa1.Nome = "Raul";

            Console.WriteLine(pessoa.GetPessoa());
            Console.WriteLine(pessoa1.GetPessoa());


        }
    }
}