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
        /// Controlador Principal de la Aplicación Gestión de Cuentas
        /// </summary>
        public static void ControladorPrincipal()
        {
            // RECURSOS
            bool salir = false;
            //byte opcion = 0;
            OPrincipal opcion = OPrincipal.Cargar;

            List<Cuenta> listaCuentas = new List<Cuenta>();

            do
            {
                // Captar la Opción del Menú Principal
                opcion = Interfaz.OpcionMenuPrincipal();

                // Ejecutar la acción según opción
                switch (opcion)
                {
                    case OPrincipal.Salir:
                        // Preguntar confirmación para salir
                        salir = true;
                        break;
                    case OPrincipal.Cargar:
                        CargarCuentas(listaCuentas);
                        break;
                    case OPrincipal.Agregar:
                        AgregarCuenta(listaCuentas);
                        break;
                    case OPrincipal.Modificar:
                        ModificarCuenta(listaCuentas);
                        break;
                    case OPrincipal.Eliminar:
                        EliminarCuenta(listaCuentas);
                        break;
                    case OPrincipal.Consultar:
                        ConsultarCuenta(listaCuentas);
                        break;
                    case OPrincipal.Operar:
                        Operar(listaCuentas);
                        break;
                    case OPrincipal.Traspasar:
                        Traspasar(listaCuentas);
                        break;
                }

            } while (!salir);

        }

        /// <summary>
        /// Carga de Datos de Prueba
        /// </summary>
        /// <param name="lista">Colección de Cuentas a la que añadir los datos de prueba</param>
        static void CargarCuentas(List<Cuenta> lista)
        {
            // Cuentas Joven
            lista.Add(new CuentaJoven("Joven1", 100, 20));
            lista.Add(new CuentaJoven("Joven2", 200, 25));
            lista.Add(new CuentaJoven("Joven3", 300, 18));
            lista.Add(new CuentaJoven("Joven4", 400, 26));
            lista.Add(new CuentaJoven("Joven5", 500, 23));

            // Cuentas Oro
            lista.Add(new CuentaOro("Oro 1", 100, 30));
            lista.Add(new CuentaOro("Oro 2", 200, 35));
            lista.Add(new CuentaOro("Oro 3", 300, 40));
            lista.Add(new CuentaOro("Oro 4", 400, 45));
            lista.Add(new CuentaOro("Oro 5", 500, 50));

            // Cuentas Platino
            lista.Add(new CuentaPlatino("Platino1", 100000, 30));
            lista.Add(new CuentaPlatino("Platino2", 100000, 30));
            lista.Add(new CuentaPlatino("Platino3", 100000, 30));
            lista.Add(new CuentaPlatino("Platino4", 100000, 30));
            lista.Add(new CuentaPlatino("Platino5", 100000, 30));

        }

    }
}
