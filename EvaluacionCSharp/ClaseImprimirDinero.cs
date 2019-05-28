using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class ClaseImprimirDinero: ClaseBilletera
    {
        private int resultado = 0;
        public void calcular()
        {
            resultado = dinero;
        }

        public void mostrar()
        {
            Console.WriteLine("El dinero que tiene actualmente en la  billetera es {0}", resultado);
        }
    }
}
