using BGCuentas;
using GestionBancaria; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GestionBancaria
{
    public static partial class Controlador
    {
        public static void Traspasar(List<Cuenta> lista)
        {
            int i = -1;
            bool salir = false;
            double dineroRetirado; 

            do
            {
                i = Interfaz.ElementoListaTransferencia1(lista);
                

                if (i >= 0)
                {

                    dineroRetirado = Interfaz.QuitarDinero(lista[i]);
                    
                    int j = Interfaz.ElementoListaTransferencia2(lista);

                   if(j >= 0 && j!= i)
                   {
                        Interfaz.añadirDinero(lista[j], dineroRetirado);
                        
                        salir = true;
                   }

                    Interfaz.TraspasoExitoso();
                    

                }

                

            } while (!salir);

            

        }

        



       


    }
}
