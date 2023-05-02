using BGCuentas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBancaria
{
    public static partial class Controlador
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lista"></param>
        static void EliminarCuenta(List<Cuenta> lista)
        {
            int indiceCuenta = -1;
            bool salir = false;

            do
            {
                indiceCuenta = Interfaz.ElementoListaCuentas(lista);

                if (indiceCuenta >= 0)
                {
                    if (Interfaz.ConfirmarOperacion("Eliminar", lista[indiceCuenta]))
                        lista.Remove(lista[indiceCuenta]);
                }
                else salir = true;

            } while (!salir);
        }

    }
}
