using System;
using CoreEscuela.Entidades;
using System.Collections.Generic;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2020, TiposEscuela.Secundaria, pais: "Ecuador", ciudad: "Quito");
            var sanpancho = new Universidad("USFQ", 1992, TiposUniversidad.Publica, "Ecuador", "Cumbaya");


            escuela.Cursos = new List<Curso>(){
                        new Curso(){ Nombre = "101", Jornada = TiposJornada.Manana.ToString() },
                        new Curso() {Nombre = "201", Jornada = TiposJornada.Manana.ToString()},
                        new Curso{Nombre = "301", Jornada = TiposJornada.Manana.ToString()}
            };

            // Agregando mas cursos con Add(), AddRange()

            escuela.Cursos.Add(new Curso{Nombre="102",Jornada=TiposJornada.Tarde.ToString()});
            escuela.Cursos.Add(new Curso{Nombre="202",Jornada=TiposJornada.Tarde.ToString()});

            var otraColeccion = new List<Curso>(){
                new Curso() {Nombre = "401", Jornada=TiposJornada.Manana.ToString()},
                new Curso() {Nombre = "501", Jornada=TiposJornada.Manana.ToString()},
                new Curso() {Nombre = "502", Jornada=TiposJornada.Tarde.ToString()}
            };

            // Quitando los datos a la coleccion
            // Quita todos los elementos de la app
            //otraColeccion.Clear();

            // Agregando los datos a la coleccion
            escuela.Cursos.AddRange(otraColeccion);

            // Remover normalmente
            escuela.Cursos.Remove();


          

            ImprimirCursosEscuela(escuela);

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
                contador++;
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
