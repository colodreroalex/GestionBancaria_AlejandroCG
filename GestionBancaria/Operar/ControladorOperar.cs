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
        /// Controlador Secundario: Operaciones con Cuentas Bancarias
        /// </summary>
        /// <param name="lista">Colección de Cuentas Bancarias</param>
        static void Operar(List<Cuenta> lista)
        {
            OTipoOperacion operacion = OTipoOperacion.Ingresar;

            int indiceCuenta = -1;
            bool salir = false;

            do
            {
                // Seleccionar la cuenta con la que operar
                indiceCuenta = Interfaz.ElementoListaCuentas(lista);

                if (indiceCuenta >= 0)
                {
                    // Captar la Operación a Realizar
                    operacion = Interfaz.OpcionMenuOperar();

                    // Ejecutar la acción según opción
                    switch (operacion)
                    {
                        case OTipoOperacion.Salir:
                            // Preguntar confirmación para salir
                            salir = true;
                            break;
                        case OTipoOperacion.Ingresar:
                            IngresarCuenta(lista[indiceCuenta]);
                            break;
                        case OTipoOperacion.Retirar:
                            RetirarCuenta(lista[indiceCuenta]);
                            break;
                    }
                }
                else salir = true;

            } while (!salir);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cuenta"></param>
        static void IngresarCuenta(Cuenta cuenta)
        {
            double cantidad;

            cantidad = Interfaz.LeerCantidad(OTipoOperacion.Ingresar);

            try
            {
                cuenta.Ingresar(cantidad);
            }
            catch (BGCuentas.CantidadException error)
            {
                Interfaz.InformarError(error.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cuenta"></param>
        static void RetirarCuenta(Cuenta cuenta)
        {
            double cantidad;

            cantidad = Interfaz.LeerCantidad(OTipoOperacion.Retirar);

            try
            {
                cuenta.Retirar(cantidad);
            }
            catch (BGCuentas.CantidadException error)
            {
                Interfaz.InformarError(error.Message);
            }

        }

    }
}
