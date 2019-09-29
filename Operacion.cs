using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    class Operacion
    {
        //Metodos con sobrecarga
        public double CalcularArea(double LadoA)
        {

            var ResulA = LadoA * LadoA;
            return ResulA;
          
        }

        public double CalcularArea(double LadoA, double LadoB)
        {
            var ResulB = LadoA * LadoB;
            return ResulB;
        }

        public double CalcularArea(double LadoA, double LadoB, int Num)
        {
            Num = 2;
            var ResulC = LadoA * LadoB / Num;
            return ResulC;
        }
    }
}
