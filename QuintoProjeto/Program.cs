namespace QuintoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa pessoa;
            //pessoa = new Pessoa();

            Pessoa pessoa = new Pessoa();

            pessoa.nome = "Cassio";
            pessoa.idade = 35;
            pessoa.mensagem();
        }
    }
}
