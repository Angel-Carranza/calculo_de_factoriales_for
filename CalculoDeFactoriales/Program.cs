using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeFactoriales
{
    /// <summary>
    /// Guia: 08
    /// Ejercicio: 28
    /// Fecha: del lunes 11 al domingo 17 de mayo del 2020
    /// Autor: Carranza López, Angel Adan
    /// GL: 16
    /// Instructor: Ing. Ruben Asencio
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //identificacion del programa en pantalla
            Console.Title = "CALCULDOR DE FACTORIALES";
            Console.WriteLine("ESTE PROGRAMA SERVIRA PARA PODER CALCULAR LOS FACTORILES DE LOS NUMEROS DEL 1 AL 7");
            Console.WriteLine("AUTOR: CARRANZA LÓPEZ, ANGEL ADAN. \tCARNET: CL19037. \tGL:16. \tINSTRUCTOR: ING. RUBEN ASENCIO");
            
            //llamada al metodo For()
            For();

            Console.WriteLine("\nPress any key to finish . . . ");
             
            //comando para que no se cierre el programa rapidamente la consola y asi poder visualizar los resultados
            Console.ReadKey(true);
        }
        /// <summary>
        /// ESTE METODO SE ENCARGARA DE CALCULAR LOS FACTORIALES DE LOS NUMEROS DEL 1 AL 7
        /// </summary>
        public static void For()
        {
            int repit, acumulador = 1, factorial = 1, numero = 1; ;
            for (repit = 0; repit <= 7; repit++)
            {
                if (repit == 0)
                {
                    Console.WriteLine("\n{0}! --> 1", repit);
                }
                else if (repit != 0)
                {
                    factorial = numero * acumulador;
                    Console.WriteLine("\n{0}! --> {1}", repit, factorial);
                    numero++;
                }
                acumulador = factorial;
            }
            return;
        }
    }
}
