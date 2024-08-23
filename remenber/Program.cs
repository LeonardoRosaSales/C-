namespace remember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConversorDeMoedas conversao;
            //conversao = new ConversorDeMoedas();

            ConversorDeMoedas conversao = new ConversorDeMoedas();

            Console.WriteLine("Qual é a cotação do dólar?");
            conversao.ValorDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você vai comprar?");
            conversao.ValorComprar = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago em reais é R$ {conversao.Resultado().ToString("F2")}");
        }
    }
}
