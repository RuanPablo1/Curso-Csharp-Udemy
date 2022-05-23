using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace nome_projeto {
    internal class Program {

        static void Main(string[] args) {

            Console.WriteLine("Digite os valores de X e Y: ");
            string[] valores = Console.ReadLine().Split(' ');
            float X = float.Parse(valores[0], CultureInfo.InvariantCulture);
            float Y = float.Parse(valores[1], CultureInfo.InvariantCulture);

            if (X == 0 && Y == 0) {
                Console.WriteLine("\nO ponto está na origem!");
            }
            else

            if (X == 0) {
                Console.WriteLine("Eixo Y!");
            }
            else

            if (Y == 0) {
                Console.WriteLine("Eixo X!");
            }
            else

            if (X > 0 && Y > 0) {
                Console.WriteLine("\nO ponto está no quadrante 1!");
            }
            else

            if (X < 0 && Y > 0) {
                Console.WriteLine("\nO ponto está no quadrante 2!");
            }
            else

            if (X < 0 && Y < 0) {
                Console.WriteLine("\nO ponto está no quadrante 3!");
            }

            else {
                Console.WriteLine("\nO ponto está no quadrante 4!");
            }
        }
    }
}

/* Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

Se o ponto estiver na origem, escreva a mensagem “Origem”.

Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
situação. */