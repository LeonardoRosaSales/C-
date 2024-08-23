using System.Globalization;

namespace TerceiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nome - STRING
            //Console.WriteLine("Escreva seu nome");
            //string nome = Console.ReadLine();
            //Idade - INT
            //Console.WriteLine("Digite a sua idade");
            //int idade = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Seu nome é {nome}");
            //Console.WriteLine($"Sua idade é {idade}");

            //Salário - FLOAT
            //Console.WriteLine($"Qual o seu salário:");
            //float salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine($"Seu nome é {nome}");
            //Console.WriteLine($"Sua idade é {idade}");
            //Console.WriteLine($"Seu salário é {salario}");


            //int numero = 15;
            //float numero2 = 10f;

            //Console.WriteLine(numero / numero2);

            //float numero = 10 / 3f;
            //Console.WriteLine(numero);

            int numero = 15;
            numero += 10; //numero = numero + 10
            Console.WriteLine(numero);
            //numero++
            //numero--

            string nome = "Cassio ";
            nome += "Maciel Gomes";
            Console.WriteLine(nome);

        }
    }
}
