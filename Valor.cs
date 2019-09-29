using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    class Valor
    {
        public void CapturarValores()
        {
            //Intanciar Operaciones
            Operacion x = new Operacion();
            //Ingresar valores
            Console.WriteLine("Ingrese Lado A");
            double ValorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese Lado B");
            double ValorB = Convert.ToDouble(Console.ReadLine());


            int Val = 5;
            //Asignar Valores
            double ResA = x.CalcularArea(ValorA);
            double ResB = x.CalcularArea(ValorA, ValorB);
            double ResC = x.CalcularArea(ValorA, ValorB, Val);


            Console.WriteLine("El area de un cuadrado es:" + ResulA);
            Console.WriteLine("El area de un rectangulo es:" + ResulB);
            Console.WriteLine("El area de un triangulo es:" + ResulC);
            Console.ReadKey();
        }
    }
}
