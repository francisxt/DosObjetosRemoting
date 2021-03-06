﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using Componente;


    /********************************
     *  Aplicaciones Distribuidas   *
     *  Francisco Gualli            *
     *  Gr1                         *
     *  Practica 05                 *
     *  Cliente                     *
     /*******************************/


namespace Cliente
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Cliente.exe.config");
            Utilidades.MostrarTodosLosDatos();
            string resultado;
            Componente.ComponenteA miComponenteA = new Componente.ComponenteA();
            Log.Imprimir("miComponenteA ha sido creado. Es Proxy? {0}",
           (RemotingServices.IsTransparentProxy(miComponenteA) ? "SI" : "NO"));
            resultado = miComponenteA.Llamada();
            Log.Imprimir("miComponenteA.Llamada() retorno: {0}", resultado);
            Componente.ComponenteB miComponenteB = new Componente.ComponenteB();
            Log.Imprimir("miComponenteB ha sido creado. Es Proxy? {0}",
           (RemotingServices.IsTransparentProxy(miComponenteB) ? "SI" : "NO"));
            resultado = miComponenteB.Llamada();
            Log.Imprimir("miComponenteB.Llamada() retorno: {0}", resultado);
            Log.EsperarParaTerminar("Presione ENTER para salir...");
        }

    }
}
