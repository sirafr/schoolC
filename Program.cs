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

            escuela.Cursos.Add(new Curso{Nombre="102",Jornada=TiposJornada.Tarde.ToString()});
            escuela.Cursos.Add(new Curso{Nombre="202",Jornada=TiposJornada.Tarde.ToString()});

            var otraColeccion = new List<Curso>(){
                new Curso() {Nombre = "401", Jornada=TiposJornada.Manana.ToString()},
                new Curso() {Nombre = "501", Jornada=TiposJornada.Manana.ToString()},
                new Curso() {Nombre = "502", Jornada=TiposJornada.Tarde.ToString()}
            };


            Curso tmp = new Curso{Nombre = "101-Vacacional", Jornada = TiposJornada.Noche.ToString()};
            escuela.Cursos.AddRange(otraColeccion);
            escuela.Cursos.Add(tmp);
            ImprimirCursosEscuela(escuela);
            // Con el hashcode
            //WriteLine("\n Curso.Hash"+tmp.GetHashCode());

            // Remover normalmente
            //escuela.Cursos.Remove(tmp);

            // Delegado: escpecifica que parametro de entrada y salida debe tener.
            Predicate<Curso> miAlgoritmo=Predicate; 
            escuela.Cursos.RemoveAll(miAlgoritmo);

            WriteLine("================");
            ImprimirCursosEscuela(escuela);
        }

        private static bool Predicate(Curso curobj)
        {
            return curobj.Nombre == "301";
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
