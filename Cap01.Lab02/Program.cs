namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o salário do funcionário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O funcionário {nome} recebe R$ {salario}");

            //Calculo de 10% sobre o salário fornecido
            double desconto = salario * 10 / 100;
            double salarioLiquido = salario - desconto;
            string resposta = $"Funcionário: {nome}\n Salário bruto: {salario:c}\n" +
                $"Desconto: {desconto:c}\n Salário líquido: {salarioLiquido:c}";
            Console.WriteLine(resposta);

            Console.ReadKey();
        }
    }
}
