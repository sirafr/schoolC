using System;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2020, TiposEscuela.Secundaria, pais: "Ecuador", ciudad: "Quito");
            var sanpancho = new Universidad("USFQ", 1992, TiposUniversidad.Publica, "Ecuador", "Cumbaya");

            escuela.Cursos = new Curso[]
            {
                new Curso(){Nombre = "101"},
                new Curso(){Nombre = "201"},
                new Curso(){Nombre = "301"}
            };

            ImprimirCursosEscuela(escuela);

            bool rta = 10 == 10;
            int cantidad = 10;
            if (rta==true)//true
            {
                WriteLine("Condicion 1");
            }
            else if (cantidad > 15)
            {
                WriteLine("Condicion 2");
            }
            else
            {
                WriteLine("No se cumplio la condicion");
            }

            if(cantidad > 5 && rta != false)
            {   
                WriteLine("Se cumplio la condicion #4");
            }

            cantidad = 10;

            if((cantidad>5 || rta) && (cantidad % 5 == 0))
            {
                WriteLine("Se cumplio condicion #5");
            }

        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("********************");
            WriteLine("Cursos de la escuela");
            WriteLine("*******************");


            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    Console.WriteLine($"Nombre: {curso.Nombre}, Id {curso.UniqueId}");
                }
            }

        }

        private static void ImprimirCursosWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length)
            {
                Console.WriteLine($"Nombra {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
                contador++; // contador = contador+1
            }
        }

        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do
            {
                Console.WriteLine($"Nombra {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
                //contador++; // contador = contador+1
            } while (++contador < arregloCursos.Length);

        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++)
            {
                Console.WriteLine($"Nombra {arregloCursos[i].Nombre}, Id {arregloCursos[i].UniqueId}");
                //contador++; // contador = contador+1
            }

        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine($"Nombra {curso.Nombre}, Id {curso.UniqueId}");
            }

        }
    }
}
