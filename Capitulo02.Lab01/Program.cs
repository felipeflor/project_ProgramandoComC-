namespace Lab01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            double ingresso;
            if(idade <= 17)
            {
                ingresso = 30;
            }
            else if(idade > 17 && idade <= 59)
            {
                ingresso = 40;
            }
            else
            {
                ingresso = 20;
            }

            string resposta = $"O convidado {nome} tem {idade}" +
                $"anos, e pagará {ingresso:c}";
            Console.WriteLine(resposta);

            Console.ReadKey();
        }
    }
}