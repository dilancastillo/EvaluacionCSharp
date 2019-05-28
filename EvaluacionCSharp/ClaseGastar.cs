using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class ClaseGastar : ClaseBilletera
    {
        private int resultado = 0;
        private int porcentaje = 10;
        

        public void calcular(int dinero)
        {
            porcentaje = dinero * 10 / 100;
            resultado = dinero - porcentaje;
        }

        public void mostrar()
        {
            Console.WriteLine("El dinero gastado es {0}", resultado);
        }
    }
}
