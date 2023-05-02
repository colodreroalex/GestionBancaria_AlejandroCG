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
        /// 
        /// </summary>
        /// <param name="opMin"></param>
        /// <param name="opMax"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static byte LeerOpcion(byte opMin, byte opMax)
        {
            byte op;

            Console.Write("Introduzca su elección: ");
            op = Convert.ToByte(Console.ReadLine());

            //if (op < opMin) throw new Exception("Opción no Válida");
            if (op > opMax) throw new Exception("Opción no Válida");

            return op;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        public static void InformarError(string mensaje)
        {
            Console.WriteLine("\nSE HA PRODUCIDO UN ERROR");
            Console.WriteLine($"\nERROR: {mensaje}\n");
            Console.Write("Pulse Enter para continuar");
            Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        public static void InformarAccion(string mensaje)
        {
            Console.WriteLine("\nOPERACIÓN REALIZADA CON ÉXITO");
            Console.WriteLine($"\nOPERACIÓN: {mensaje}\n");
            Console.Write("Pulse Enter para continuar");
            Console.ReadLine();
        }
 
        /// <summary>
        ///  Confirmación de la Operación a realizar
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="cuenta"></param>
        /// <returns></returns>
        public static bool ConfirmarOperacion(string mensaje, Cuenta cuenta)
        {
            bool respuesta = false;
            byte opcion = 0;
            bool opcionCorrecta;

            do
            {
                opcionCorrecta = false;
                // Mostrar el mensaje de confirmación
                Console.WriteLine($"Confirme la Acción: ¿Desea {mensaje} la Cuenta?");
                Console.WriteLine($"Titular: {cuenta.Titular}  Saldo: {cuenta.Saldo}");
                Console.WriteLine("\t0.-\tNo");
                Console.WriteLine("\t1.-\tSí");
                // Seleccionar Opción
                try
                {
                    opcion = LeerOpcion(0, 1);

                    opcionCorrecta = true;
                }
                catch (Exception error)
                {
                    InformarError(error.Message);
                }

            } while (!opcionCorrecta);

            if (opcion == 1) respuesta = true;

            return respuesta;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string LeerTitular()
        {
            string titular = "";

            Console.Write("Introduzca el Titular de la Cuenta: ");
            titular = Console.ReadLine();

            return titular;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int LeerEdad()
        {
            int edad = 0;

            Console.Write("Introduzca la Edad de la Cuenta: ");
            edad = Convert.ToInt32(Console.ReadLine());

            return edad;
        }
    }
}
