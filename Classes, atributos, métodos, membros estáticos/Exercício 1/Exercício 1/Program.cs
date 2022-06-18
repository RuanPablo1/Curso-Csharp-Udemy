using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_1 {
    internal class Program {

        static void Main(string[] args) {

            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            pessoa1.Nome = Console.ReadLine();
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados da segunda pessoa:");
            pessoa2.Nome = Console.ReadLine();
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade) {
                Console.WriteLine("\nPessoa mais velha: " + pessoa1.Nome);
            }else

            if(pessoa2.Idade > pessoa1.Idade) {
                Console.WriteLine("\nPessoa mais velha: " + pessoa2.Nome);
            }

            else {
                Console.WriteLine("\nAs duas tem a mesma idade!");
            }
        }
    }
}

/*Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
velha.*/