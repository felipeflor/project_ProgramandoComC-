namespace ConstrutorPersonalizado
{
    public class Personalizado
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Juan", 46, 100, 1.80);
            Console.WriteLine(pessoa.GetPessoa());
        }
    }
}