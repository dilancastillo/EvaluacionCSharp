using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string valor;
            int ingreso = 0;

            ClaseBilletera billetera = new ClaseBilletera();
            Console.WriteLine("Ingrese el monto inicial");
            valor = Console.ReadLine();
            ingreso = Convert.ToInt32(valor);

            Console.WriteLine("Digite: 1-Gastar, 2-Depositar, 3-Imprimir dinero, 4-Notificar transaccion 5-Total ahorrado");

            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            

            if (opcion == 1)
            {
                ClaseGastar gastar = new ClaseGastar();
                Console.WriteLine("Ingrese el monto de dinero");
                valor = Console.ReadLine();
                ingreso = Convert.ToInt32(valor);
                gastar.calcular(ingreso);
                gastar.mostrar();
            }              
            if (opcion == 2)
            {
                ClaseDepositar depositar = new ClaseDepositar();
                depositar.calcular();
                depositar.mostrar();
            }
            if (opcion == 3)
            {
                ClaseImprimirDinero imprimir = new ClaseImprimirDinero();
                imprimir.calcular();
                imprimir.mostrar();
            }
            if (opcion == 4)
            {
                ClaseNotificarTransaccion notificar = new ClaseNotificarTransaccion();
                notificar.calcular();
                notificar.mostrar();
            }
            if (opcion == 5)
            {

            }






            

            
        }
    }
}
