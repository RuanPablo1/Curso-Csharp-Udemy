using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace nome_projeto {
    internal class Program {

        static void Main(string[] args) {

            Console.WriteLine("Digite um número para saber se ele é par ou ímpar: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("\nO número é par!");
            }
            else {
                Console.WriteLine("\nO número é impar!");
            }

        }
    }
}

//Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.