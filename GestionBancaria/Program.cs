using BGCuentas;

namespace GestionBancaria
{
    /// <summary>
    /// Opciones del Menú Principal
    /// </summary>
    public enum OPrincipal : byte { Salir, Cargar, Agregar, Modificar, Eliminar, Consultar, Operar, Traspasar }

    /// <summary>
    /// Tipos de Cuenta y Opciones del Menú de Adición de Cuentas
    /// </summary>
    public enum OTipoCuenta : byte { Salir, Joven, Oro, Platino }
    /// <summary>
    /// Tipos de Operaciones y Opciones del Menú de Operaciones con Cuentas
    /// </summary>    
    public enum OTipoOperacion : byte { Salir, Ingresar, Retirar , Traspasar}
    internal class Program
    {
        /// <summary>
        /// Arranque de la Aplicación
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Llamada al Controlador Principal de la Aplicación
            Controlador.ControladorPrincipal();
        }

    }
}