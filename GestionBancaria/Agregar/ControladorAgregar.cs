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
        /// Controlador Secundario: Adición de Cuentas Bancarias
        /// </summary>
        /// <param name="lista">Colección de Cuentas Bancarias</param>
        static void AgregarCuenta(List<Cuenta> lista)
        {
            bool salir = false;
            OTipoCuenta tipo = OTipoCuenta.Joven;
            Cuenta nuevaCuenta; // Nueva Cuenta a Agregar

            // Mostrar menú de tipo de cuentas
            do
            {
                nuevaCuenta = null;
                // Captar la Opción del Menú Principal
                tipo = Interfaz.OpcionMenuAgregar();

                // Ejecutar la acción según opción
                //switch (tipo)
                //{
                //    case OTipoCuenta.Salir:
                //        salir = true;
                //        break;
                //    case OTipoCuenta.Joven:
                //        //nuevaCuenta = CrearCuentaJoven();
                //        //nuevaCuenta = CrearCuenta(tipo);
                //        //break;
                //    case OTipoCuenta.Oro:
                //        //nuevaCuenta = CrearCuentaOro();
                //        //nuevaCuenta = CrearCuenta(tipo);
                //        //break;
                //    case OTipoCuenta.Platino:
                //        //nuevaCuenta = CrearCuentaPlatino();
                //        nuevaCuenta = CrearCuenta(tipo);
                //        break;
                //}


                // Llamada a un único Método
                if (tipo == OTipoCuenta.Salir) salir = true;
                else
                {
                    // Creación de la Cuenta
                    nuevaCuenta = CrearCuenta(tipo);
                    // Adición de la Nueva Cuenta
                    if (nuevaCuenta != null)
                    {
                        lista.Add(nuevaCuenta);
                        Interfaz.InformarAccion($"Agregar Cuenta {tipo}");
                    }
                    else
                        Interfaz.InformarError("La Cuenta no ha sido Creada");
                }

            } while (!salir);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoCuenta"></param>
        /// <returns></returns>
        public static Cuenta CrearCuenta(OTipoCuenta tipoCuenta)
        {
            Cuenta newCuenta = null;
            string titular;
            int edad;
            double cantidad;

            try
            {
                // Solicitar Titular
                titular = Interfaz.LeerTitular();
                // Solicitar Edad
                edad = Interfaz.LeerEdad();
                // Solicitar Cantidad Inicial
                cantidad = Interfaz.LeerCantidad(OTipoOperacion.Ingresar);
                // Construir Tipo de Cuenta Apropiado
                switch (tipoCuenta)
                {
                    case OTipoCuenta.Joven:
                        newCuenta = new CuentaJoven(titular, cantidad, edad);
                        break;
                    case OTipoCuenta.Oro:
                        newCuenta = new CuentaOro(titular, cantidad, edad);
                        break;
                    case OTipoCuenta.Platino:
                        newCuenta = new CuentaPlatino(titular, cantidad, edad);
                        break;
                }

            }
            catch (TitularException error)
            {
                Interfaz.InformarError(error.Message);
            }
            catch (EdadException error)
            {
                Interfaz.InformarError(error.Message);
            }
            catch (CantidadException error)
            {
                Interfaz.InformarError(error.Message);
            }
            catch (Exception error)
            {
                Interfaz.InformarError(error.Message);
            }

            return newCuenta;
        }

        //
        // EJEMPLOS DE MÉTODOS INDIVIDUALES DE CREACIÓN DE CUENTAS
        //
        public static CuentaJoven CrearCuentaJoven()
        {
            CuentaJoven cuenta = null;

            // Solicitar Titular

            // Solicitar Edad

            // Solicitar Cantidad Inicial

            // Construir CuentaJoven

            return cuenta;
        }

        public static CuentaOro CrearCuentaOro()
        {
            CuentaOro cuenta = null;

            // Solicitar Titular

            // Solicitar Edad

            // Solicitar Cantidad Inicial

            // Construir CuentaOro

            return cuenta;
        }

    }
}
