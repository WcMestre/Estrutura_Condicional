using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int PriNumero, SegNumero, Resultado, op;

            Console.Write("Digite o Primeiro número: ");
            PriNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo número: ");
            SegNumero = int.Parse(Console.ReadLine());

            Console.Write("\nEscolha a operação desejada");
            Console.Write("\n 1- Soma");
            Console.Write("\n2 - Subtração\n");
            op = int.Parse(Console.ReadLine());


            if (op == 1)
            {
                Resultado = PriNumero + SegNumero;
                Console.WriteLine("\nO resultado é: " + Resultado);
            }

                else if (op == 2)
                {
                    Resultado = PriNumero - SegNumero;
                    Console.WriteLine("\nO resultado é: " + Resultado);
                }

                    else 
                    {
                        Console.WriteLine("\nOperação inválida");
                    }

            Console.Write("\nPressione qualquer tecla para continuar . . . ");
            Console.ReadKey(true);

        }
    }
}
