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
        static void ConsultarCuenta(List<Cuenta> lista)
        {
            int indiceCuenta = -1;
            bool salir = false;

            do
            {
                indiceCuenta = Interfaz.ElementoListaCuentas(lista);

                if (indiceCuenta >= 0)
                {
                    Interfaz.MostrarDatosCuenta(lista[indiceCuenta]);
                }
                else salir = true;

            } while (!salir);

        }

    }
}
