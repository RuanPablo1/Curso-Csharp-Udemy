using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace nome_projeto {
    internal class Program {

        static void Main(string[] args) {

            int numeros_digitados, fora = 0;
            int quantidade_numeros = 0;
            int dentro = 0;

            Console.WriteLine("Quantos números quer digitar?");
            quantidade_numeros = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade_numeros; i++) {
                numeros_digitados = int.Parse(Console.ReadLine());
                if (numeros_digitados >= 10 && numeros_digitados <= 20) {
                    dentro = dentro + 1;
                }

                else {
                    fora = fora + 1;
                }
            }
            Console.WriteLine("\nIn: " + dentro);
            Console.WriteLine("Out: " + fora);
        }
    }
}

/* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo). */