using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2020, TiposEscuela.Secundaria,
            pais: "Ecuador", ciudad: "Quito");

            Escuela.Cursos = new List<Curso>(){
                        new Curso(){ Nombre = "101", Jornada = TiposJornada.Manana.ToString() },
                        new Curso() {Nombre = "201", Jornada = TiposJornada.Manana.ToString()},
                        new Curso{Nombre = "301", Jornada = TiposJornada.Manana.ToString()},
                        new Curso() {Nombre = "401", Jornada=TiposJornada.Tarde.ToString()},
                        new Curso() {Nombre = "501", Jornada=TiposJornada.Tarde.ToString()}

            };
        }
    }
}
