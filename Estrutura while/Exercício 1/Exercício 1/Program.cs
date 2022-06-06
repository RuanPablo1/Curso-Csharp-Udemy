using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4 {
    internal class Program {
        static void Main(string[] args) {

            int senha = 2002;
            int entrada;

            Console.WriteLine("Digite sua senha: ");
            entrada = int.Parse(Console.ReadLine());

            ValidacaoSenha(entrada, senha); //Criado para acostumar um pouco com a utilização das funções.

            Console.WriteLine("\nAcesso permitido!");
        }

        static void ValidacaoSenha(int entrada, int senha) {

            while (entrada != senha) {
                Console.WriteLine("\nSenha inválida!");
                entrada = int.Parse(Console.ReadLine());

            }

        }

    }
}

/* Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002. */