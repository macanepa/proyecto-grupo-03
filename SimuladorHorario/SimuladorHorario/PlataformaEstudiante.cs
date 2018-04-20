﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorHorario
{
    static class PlataformaEstudiante
    {
        public static void MenuPlataformaEstudiante()
        {
            Console.WriteLine($"--Bienvenido Estudiante--");
            Console.WriteLine("Que desea hacer:\n" +
                "1. Inscribir Curso\n");
            int opcion = Program.ChequearOpcion(1, 3);
            if (opcion == 1) InscribirCurso();

            Console.ReadKey();
        }
        public static bool Guardar() { return false; }
        static bool ChequearCompatibilidad(Curso curso, Estudiante estudiante) { return false; }
        static void InscribirCurso() {

            Console.WriteLine("--Seleccione un curso para inscribir--");
            foreach(CursoCurricular curso_ in Aplicacion.GetCursoCurricular())
            {
                Console.WriteLine($"NRC:{curso_.nrc} Nombre: {curso_.nombre}\n" +
                    $"Profesor: {curso_.profesor}\n");
            }

            List<string> listadoNRC = Aplicacion.GetCursoCurricular().Select(x => x.nrc).ToList();

            string option="";
            while (!listadoNRC.Contains(option))
            {
                Console.Write("NRC: ");
                option = Console.ReadLine();
            }

            CursoCurricular curso = Aplicacion.GetCursoCurricular().Find(x => x.nrc == option);

            Console.WriteLine("Hasta aqui llegamos");
            Console.ReadKey();
            return;
        }
        static void EliminarCursoInscrito(Curso curso) { return; }
        static int ContarCreditos(List<Curso> listaCursosInscritos) { return 1; }
        
    }
}
