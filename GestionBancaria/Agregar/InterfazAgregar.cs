using BGCuentas;
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
        /// Presentación Menú - Agregar Cuenta
        /// </summary>
        public static void MenuAgregarCuenta()
        {
            Console.Clear();
            Console.WriteLine("*** GESTIÓN DE CUENTAS BANCARIAS ***");
            Console.WriteLine("---------- AGREGAR CUENTA ----------\n");
            Console.WriteLine("\t0.- Salir");
            Console.WriteLine("\t1.- Cuenta Joven");
            Console.WriteLine("\t2.- Cuenta Oro");
            Console.WriteLine("\t3.- Cuenta Platino");

        }

        /// <summary>
        /// Selección del tipo de cuenta a agregar
        /// </summary>
        /// <returns>Tipo de Cuenta a Agregar</returns>
        public static OTipoCuenta OpcionMenuAgregar()
        {
            // RECURSOS
            OTipoCuenta opcion = OTipoCuenta.Joven;
            bool opcionCorrecta;

            do
            {
                opcionCorrecta = false;
                // Mostrar el menú para la adición de cuentas
                MenuAgregarCuenta();

                // Seleccionar Opción
                try
                {
                    opcion = (OTipoCuenta)LeerOpcion((byte)OTipoCuenta.Salir, (byte)OTipoCuenta.Platino);

                    opcionCorrecta = true;
                }
                catch (Exception error)
                {
                    InformarError(error.Message);
                }

            } while (!opcionCorrecta);

            return opcion;
        }


    }
}
