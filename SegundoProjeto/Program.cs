using System.Globalization;

namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INT, FLOAT, BOOL, STRING...
            //String usa as aspas duplas
            //Char usa as aspas simples

            int idade = 33;  //Nomes que fazem sentido
            string nomeCompleto = "Cassio Maciel Gomes"; //Camel Case
            var cidade = "Juquia";
            dynamic estado = "SP";

            double salario = 1000.258;

            const float PI = 3.145656f;

            Console.WriteLine("Meu nome é " + nomeCompleto);  //Concatenação
            Console.WriteLine($"Atualmente, tenho {idade} anos"); //Interpolação
            Console.WriteLine("Moro em {0}", cidade);
            //Console.WriteLine($"Seu salário é R$ {salario.ToString("F2")}");
            Console.WriteLine($"Seu salário é R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("O valor de PI é " + PI);
        }
    }
}
