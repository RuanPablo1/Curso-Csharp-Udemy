using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace nome_projeto {
    internal class Program {

        static void Main(string[] args) {

            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;

            Console.WriteLine("Com qual combustível quer abastecer?\n");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 4) {
                if (opcao == 1) {
                    Console.WriteLine("\nÁlcool: 1");
                    alcool = alcool + 1;
                }
                else

                if (opcao == 2) {
                    Console.WriteLine("\nGasolina: 2");
                    gasolina = gasolina + 1;
                }
                else

                if (opcao == 3) {
                    Console.WriteLine("\nDiesel");
                    diesel = diesel + 1;
                }
                opcao = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nMUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}

/*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
exemplo.*/