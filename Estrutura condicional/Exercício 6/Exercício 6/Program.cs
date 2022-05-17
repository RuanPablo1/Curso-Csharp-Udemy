using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace nome_projeto {
    internal class Program {

        static void Main(string[] args) {

            double numero = 0;

            Console.WriteLine("Digite um número: ");
            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0 || numero > 100) {
                Console.WriteLine("\nFora do intervalo!");
            }else

            if (numero <= 25) {
                Console.WriteLine("\nIntervalo [0-25]");
            }else

            if (numero <= 50) {
                Console.WriteLine("\nIntervalo [25-50]");
            }else

            if(numero <= 75) {
                Console.WriteLine("\nIntervalo [50-75]");
            }
            else {
                Console.WriteLine("\nIntervalo [75-100]");
            }

        }
    }
}

/* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”. */