using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7 {
    internal class ConversorDeMoeda {

        public static double Iof = 0.06;

        public static double DolarParaReal(double quantia, double cotacao) {
            double resultado = quantia * cotacao;
            return resultado + resultado * Iof;
        }
    }
}
