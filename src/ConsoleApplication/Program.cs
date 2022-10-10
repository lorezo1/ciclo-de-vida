//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            for (int i=0; i<100; i++)
            {
                new Train("");
            }
            Console.WriteLine(Train.getCount());

             for (int i=0; i<100000000; i++)
            {
                new Train("");
            }
            Console.WriteLine(Train.getCount());

            //el contador no llega a 10.000.000 porque es mucha cantidad y no se está haciendo nada con esos datos
            //por lo tanto los va borrando y da otro número
        }
    }
}