using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;
using static System.Console;
using CoreEscuela.Util;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("WELCOME TO THE SCHOOL");
            Printer.Beep(1000,cantidad:10);
            ImprimirCursosEscuela(engine.Escuela);

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {

            Printer.WriteTitle("CURSOS DE LA ESCUELA");


            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, Id {curso.UniqueId}");
                }
            }
        }
    }
}
 