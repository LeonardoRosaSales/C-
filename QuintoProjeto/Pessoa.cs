using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoProjeto
{
    internal class Pessoa
    {
        public string nome;
        public int idade;

        public void mensagem() //Métodos
        {
            Console.WriteLine($"Olá {nome}, você tem {idade} anos.");
        }
    }
}
