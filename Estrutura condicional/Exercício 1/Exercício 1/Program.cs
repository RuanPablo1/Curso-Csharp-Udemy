using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace nome_projeto {
    internal class Program {

        static void Main(string[] args) {

            Console.WriteLine("Digite um número: ");
            float num = float.Parse(Console.ReadLine());

            if (num >= 0) {
                Console.WriteLine("\nO número {0} não é negativo!", num);
            }
            else {
                Console.WriteLine("\nO número {0} é negativo!", num);
            }

        }
    }
}

//Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
