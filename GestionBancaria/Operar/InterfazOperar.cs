using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBancaria
{
    public static partial class Interfaz
    {

        /// <summary>
        /// Presentación Menú - Operar Cuenta
        /// </summary>
        public static void MenuOperarCuenta()
        {
            Console.Clear();
            Console.WriteLine("*** GESTIÓN DE CUENTAS BANCARIAS ***");
            Console.WriteLine("---------- OPERAR CUENTA -----------\n");
            Console.WriteLine("\t0.- Salir");
            Console.WriteLine("\t1.- Ingresar Cantidad");
            Console.WriteLine("\t2.- Retirar Cantidad");

        }

        /// <summary>
        /// Selecciona el tipo de operación a realizar
        /// </summary>
        /// <returns>Tipo de Operación</returns>
        public static OTipoOperacion OpcionMenuOperar()
        {
            // RECURSOS
            OTipoOperacion opcion = OTipoOperacion.Ingresar;
            bool opcionCorrecta;

            do
            {
                opcionCorrecta = false;
                // Mostrar el menú para la adición de cuentas
                MenuOperarCuenta();

                // Seleccionar Opción
                try
                {
                    opcion = (OTipoOperacion)LeerOpcion((byte)OTipoOperacion.Traspasar, (byte)OTipoOperacion.Retirar);

                    opcionCorrecta = true;
                }
                catch (Exception error)
                {
                    InformarError(error.Message);
                }

            } while (!opcionCorrecta);

            return opcion;
        }

        /// <summary>
        /// Obtiene una cantidad 
        /// </summary>
        /// <param name="operacion"></param>
        /// <returns></returns>
        public static double LeerCantidad(OTipoOperacion operacion)
        {
            double dinero = 0;
            bool cantidadCorrecta;

            do
            {
                cantidadCorrecta = false;

                Console.Write($"Introduzca Cantidad a {operacion}: ");
                try
                {
                    dinero = Convert.ToDouble(Console.ReadLine());
                    cantidadCorrecta = true;
                }
                catch (Exception error)
                {
                    InformarError(error.Message);
                }

            } while (!cantidadCorrecta);

            return dinero;
        }

    }
}
