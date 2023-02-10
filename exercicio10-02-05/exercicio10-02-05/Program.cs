using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10_02_05
{
    internal class Program
    {
        static void Main(string[] args)
        {   //criação das variaveis em double
            double num1 = 0;
            double num2 = 0;

            //Imprimi Digite o primeiro numero
            Console.WriteLine("Digite o Primeiro número: ");
            //Variavel num1 recebe o valor convertido para double
            num1= Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Digite o Segundo número : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            //se num1 for maior que num2
            if (num1 > num2)
            {
                Console.WriteLine("O primeiro valor é maior que o segundo ");
            //SE num1 for maior que num2 Imprimi a mensagem 
            }
            // senao se num1 for menor que num2 
            else if (num1 < num2)
            {
                //Imprimi a mensagem 
                Console.WriteLine("O segundo valor é maior que o Primeiro ");
            }   //senao se num1 igual a num2 
             else   
            {   //imprimi a mensagem 
                Console.WriteLine("Os valores são iguais");
            }
           
           
            
            
            

        }
    }
}
