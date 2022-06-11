using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace nome_projeto {
    internal class Program {

        static void Main(string[] args) {

            int i, numero_digitado = 0;

            Console.WriteLine("Digite um número: ");
            numero_digitado = int.Parse(Console.ReadLine());

            Console.WriteLine("\nNúmero ímpares:");
            for (i = 0; i <= numero_digitado; i++) {
                if(i%2 != 0) {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

/* Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso. */