using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    class Program
    {
        static void Main(string[] args)
        {

            //Realizar bienvenida
            Console.WriteLine("Bienvenido");
            //Instanciar clase
             Valor D = new Valor();
            D.CapturarValores();
            Console.ReadKey();
        }
    }
}
