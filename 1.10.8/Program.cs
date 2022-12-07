namespace CoalescenciaNula
{
    public class CoalescenciaNula
    {
        static void Main(string[] args)
        {
            string curso = null;
            string texto = curso ?? "Curso não informado";

            Console.WriteLine(texto);
            Console.ReadKey();

            List<string> cursos = null;
            (cursos ??= new List<string>()).Add("C#");
            Console.WriteLine(string.Join(" ", cursos));

            Console.ReadKey();
        }
    }
}