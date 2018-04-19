﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("super Usuario?\n(1) Si\n(2) No");
            string op = Console.ReadLine();
            if (op == "1")
            {
                Aplicacion.app();
            }



            Console.ForegroundColor = ConsoleColor.White;
            int ChequearOpcion(int inicio, int fin) //Chequea si la opcion es valida. Solo sirve para opciones de numeros enteros: Inicio: cota inferior ; Fin Cota superior
            {
                int opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion > fin || opcion < inicio)
                {
                    do
                    {
                        Console.Write("Ingrese una opcion valida:");
                        opcion = Convert.ToInt32(Console.ReadLine());
                    } while (opcion > 3 || opcion < 1);
                }
                return opcion;
            }
            void MenuPrincipal()
            {
                InicioMenuPrincipal:
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Bienvenido al Simulador de Horario");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Que desea hacer: ");
                Console.Write("1. Iniciar sesion\n" +
                              "2. Registrarse\n" +
                              "3. Salir del Programa\n");
                int opcion = ChequearOpcion(1, 3); //Ejemplo de uso de Chequear opcion

                if (opcion == 1)
                {
                    Aplicacion.IniciarSesion();
                    goto InicioMenuPrincipal;
                }


                if (opcion == 2) Aplicacion.Registrarse();

                if (opcion == 3) return;

                
                
            }
            MenuPrincipal();
        }
    }
}