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
        /// Muestra el listado de todas las cuentas en forma de menú
        /// </summary>
        /// <param name="lista"></param>
        public static void MostrarListaCuentas(List<Cuenta> lista)
        {

            int indice = 1;

            Console.Clear();
            Console.WriteLine("*** GESTIÓN DE CUENTAS BANCARIAS ***");
            Console.WriteLine("-------- LISTADO DE CUENTAS --------\n");
            Console.WriteLine("\t0.-\tSalir");

            foreach (Cuenta cuenta in lista)
            {
                Console.WriteLine($"\t{indice}.-\t{cuenta.Titular}");
                indice++;
            }
        }
        
        /// <summary>
        ///
        /// </summary>
        /// <param name="cuenta"></param>
        public static void MostrarDatosCuenta(Cuenta cuenta)
        {
            string tipo = "";
            int edad = 0;

            if (cuenta is CuentaJoven)
            {
                tipo = "Cuenta Joven";
                edad = ((CuentaJoven)cuenta).Edad;
            }
            if (cuenta is CuentaOro)
            {
                tipo = "Cuenta Oro";
                edad = ((CuentaOro)cuenta).Edad;
            }
            if (cuenta is CuentaPlatino)
            {
                tipo = "Cuenta Platino";
                edad = ((CuentaPlatino)cuenta).Edad;
            }

            Console.Clear();
            Console.WriteLine("*** GESTIÓN DE CUENTAS BANCARIAS ***");
            Console.WriteLine("-------- DATOS DE LA CUENTA --------\n");
            Console.WriteLine($"Tipo de Cuenta: {tipo}");
            Console.WriteLine($"Titular: {cuenta.Titular}");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Saldo: {cuenta.Saldo}");

            Console.WriteLine("\nPulse Enter para continuar");
            Console.ReadLine();

        }

        /// <summary>
        /// Selección de la Cuenta del listado
        /// </summary>
        /// <returns>Tipo de Operación</returns>
        public static int ElementoListaCuentas(List<Cuenta> lista)
        {
            // RECURSOS
            int opcion = 0;
            bool opcionCorrecta;

            do
            {
                opcionCorrecta = false;
                // Mostrar el listado de cuentas
                MostrarListaCuentas(lista);

                // Seleccionar Opción
                try
                {
                    opcion = LeerOpcion((byte)OTipoCuenta.Salir, (byte)lista.Count);

                    opcionCorrecta = true;
                }
                catch (Exception error)
                {
                    InformarError(error.Message);
                }

            } while (!opcionCorrecta);

            return opcion - 1;
        }

        
    }
}
