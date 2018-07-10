using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componente
{
    /********************************
     *  Aplicaciones Distribuidas   *
     *  Francisco Gualli            *
     *  Gr1                         *
     *  Practica 05                 *
     *  Componente                  *
     /*******************************/
    public class ComponenteA : MarshalByRefObject
    {
        public ComponenteA()
        {
            Log.Imprimir("Se creo una instancia del Objeto Remoto ComponenteA");
        }

        public string Llamada()
        {
            Log.Imprimir("Se invoco a Llamada()");
            return "ComponenteA.Llamada()";
        }
    }
    public class ComponenteB : MarshalByRefObject
    {
        public ComponenteB()
        {
            Log.Imprimir("Se creo una instancia del Objeto Remoto ComponenteB");
        }
        public string Llamada()
        {
            Log.Imprimir("Se invoco a Llamada()");
            return "ComponenteB.Llamada()";
        }

    }
}
