using GestionBancaria;
using BGCuentas; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GestionBancaria
{
    public static partial class Interfaz
    {
        public static int ElementoListaTransferencia1(List<Cuenta> listaCuentas)
        {
            int opcion = 0;
             
            bool opCorrecta;

            do
            {

                opCorrecta = false;
                MostrarListaCuentas(listaCuentas);
                

                try
                {
                    
                    opcion = LeerOpcion((byte)OTipoCuenta.Salir, (byte)listaCuentas.Count);
                    opCorrecta = true; 
                }
                catch (Exception ex)
                {
                    InformarError(ex.Message);
                }


            }while(!opCorrecta);

            return opcion - 1 ;

        }

        public static int ElementoListaTransferencia2(List<Cuenta> listaCuentas)
        {
            int opcion = 0;

            bool opCorrecta;

            do
            {

                opCorrecta = false;
                MostrarListaCuentas(listaCuentas);


                try
                {
                    MostrarAQueCuenta();
                    opcion = LeerOpcion((byte)OTipoCuenta.Salir, (byte)listaCuentas.Count);
                    opCorrecta = true;
                }
                catch (Exception ex)
                {
                    InformarError(ex.Message);
                }


            } while (!opCorrecta);

            return opcion - 1;

        }

        public static void MostrarAQueCuenta()
        {
            Console.WriteLine($"A que cuenta deseas ingresar este dinero");
            Console.WriteLine("Pulsa ENTER para continuar, y selecciona la opcion");
            Console.ReadLine();
        }
        


        public static double QuitarDinero(Cuenta cuenta2)
        {

            double dinero2 = 0;

            try
            {

                Console.WriteLine($"Introduce la cantidad que quieres retirar de la cuenta {cuenta2.Titular}");
                dinero2 = Convert.ToDouble(Console.ReadLine());
                cuenta2.Retirar(dinero2);

            }
            catch (Exception ex)
            {
                InformarError(ex.Message);
            }

            return dinero2;

        }


        public static double añadirDinero(Cuenta cuenta3, double dineritoo)
        {

            

            try
            {

                cuenta3.Ingresar(dineritoo);
                Console.WriteLine($"Se añadio {dineritoo}e a la cuenta {cuenta3.Titular}");
            }
            catch (Exception ex)
            {
                InformarError(ex.Message);
            }

            return dineritoo;

        }

        public static void TraspasoExitoso()
        {
            Console.WriteLine($"Se realizo la transferencia satisfactoriamente a la cuenta");
            Console.ReadLine();

        }

    }

    


    


}




