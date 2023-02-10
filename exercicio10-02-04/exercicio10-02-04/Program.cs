using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //variável que irá guardar o nome.
            string nome1 = "";

            //imprime na tela para a pessoa digitar seu nome.
            Console.WriteLine("Digite seu nome : ");
            //A variável nome recebe o que for digitado na tela.
            nome1=Console.ReadLine();
            //imprime na tela "O nome X é legal".
            Console.WriteLine("O nome  "+ nome1+"  é Legal");
        }
    }
}
