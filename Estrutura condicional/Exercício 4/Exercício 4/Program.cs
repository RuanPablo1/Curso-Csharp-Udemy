using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace nome_projeto {
    internal class Program {

        static void Main(string[] args) {

            int horaInicio, horaFim, duracao = 0;

            Console.WriteLine("Que horas começou o jogo?");
            horaInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQue horas acabou o jogo?");
            horaFim = int.Parse(Console.ReadLine());


            if (horaInicio < horaFim) {
                duracao = horaFim - horaInicio;
            }
            else {
                duracao = 24 - horaInicio + horaFim;
            }

            Console.WriteLine($"\nO jogo teve a duração de {duracao} hora(s)!");
        }
    }
}

/* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas. */