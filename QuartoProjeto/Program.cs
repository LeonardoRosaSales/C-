using System.Globalization;

namespace QuartoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            //NEW = Instanciação
            x = new Triangulo();
            y = new Triangulo();

            //Lados do Triângulo X
            Console.WriteLine("Entre com as medidas do triângulo X:");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Lados do Triângulo Y
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Calcular área do Triâgulo X
            double areaX = x.Area();

            //Calcular área do Triâgulo Y
            double areaY = y.Area();

            //Exibir o Resultado
            Console.WriteLine("Área de X = " + areaX.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            };
        }
    }
}