using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10_02_06
{
    internal class Program
    {
        static void Main(string[] args)
        {   //criação da variavel;
            double num1 = 0;    
            
            //Imprime na tela.
            Console.WriteLine("Digite um número :");

            //Váriavel num1 recebe o valor digitado  convertido para double.
            num1= Convert.ToDouble(Console.ReadLine());
            // Imprimi na tela um texto eo valor digitado.
            Console.WriteLine("O Numero Digitado foi "+num1+"  então : ");
            //Imprimi na tela o dobro do valor digitado;
            Console.WriteLine("O dobro de " + num1 + " é " + num1 * 2);
            //Imprimi na tela a metade do valor digitado.
            Console.WriteLine("A metado de " + num1 + " é " + num1 / 2);

        }
    }
}
