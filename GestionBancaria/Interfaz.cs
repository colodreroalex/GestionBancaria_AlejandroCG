using BGCuentas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBancaria
{
    public static partial class Interfaz
    {

        /// <summary>
        /// Presentación Menú - Menú Principal de la Aplicación
        /// </summary>
        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("*** GESTIÓN DE CUENTAS BANCARIAS ***");
            Console.WriteLine("---------- MENÚ PRINCIPAL ----------\n");
            Console.WriteLine("\t0.- Salir");
            Console.WriteLine("\t1.- Cargar Datos");
            Console.WriteLine("\t2.- Agregar Cuenta");
            Console.WriteLine("\t3.- Modificar Cuenta");
            Console.WriteLine("\t4.- Eliminar Cuenta");
            Console.WriteLine("\t5.- Consultar");
            Console.WriteLine("\t6.- Operar");
            Console.WriteLine("\t7.- Traspasar");

        }


        /// <summary>
        /// Selección del tipo de operación a realizar
        /// </summary>
        /// <returns>Operación a realizar</returns>
        public static OPrincipal OpcionMenuPrincipal()
        {
            // RECURSOS
            OPrincipal opcion = OPrincipal.Cargar;
            bool opcionCorrecta;

            do
            {
                opcionCorrecta = false;
                // Mostrar el menú principal
                MenuPrincipal();
                // Seleccionar Opción
                try
                {
                    opcion = (OPrincipal)LeerOpcion((byte)OPrincipal.Traspasar, (byte)OPrincipal.Traspasar);

                    opcionCorrecta = true;
                }
                catch (Exception error)
                {
                    //Console.WriteLine(error.Message);
                    InformarError(error.Message);
                }

            } while (!opcionCorrecta);

            return opcion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cuenta"></param>
        public static void EstablecerTitularCuenta(Cuenta cuenta) {

            string nombre;
            
            // Solicitar Titular
            Console.WriteLine("Introduzca nuevo titular: ");
            nombre = Console.ReadLine();

            // Establecer Titular
            cuenta.Titular = nombre;

        }

    }
}
