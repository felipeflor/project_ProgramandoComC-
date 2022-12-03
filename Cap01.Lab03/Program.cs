namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o salário do funcionário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor gasto com transporte: ");
            double transporte = Convert.ToDouble(Console.ReadLine());

            //cálculo de 6% sobre o salário
            double vt = salario * 6 / 100;
            //verificação do valor real do vale-transporte
            double vt_real = (transporte > vt ? vt : transporte);

            double salarioLiquido = salario - vt;

            string resultado = $"\nFuncionário: {nome}\n" +
                                $"Salário: {salario:c}\n" +
                                $"Desconto VT: {vt_real:c}\n" +
                                $"Salário líquido: {salarioLiquido:c}";
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
