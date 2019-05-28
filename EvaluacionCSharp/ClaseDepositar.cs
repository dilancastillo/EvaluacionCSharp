using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class ClaseDepositar : ClaseBilletera
    {
        private int resultado = 0;
        private int resultado2 = 0;
        public void calcular()
        {
            resultado = dinero;
            resultado2 = resultado - dinero;

        }

        public void mostrar()
        {
            Console.WriteLine("El dinero depositado en el banco es: {0}", resultado);
            Console.WriteLine("El dinero que queda en la billetera es {0}", resultado2);
        }
    }
}
