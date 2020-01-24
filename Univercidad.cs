using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univercidad
{
    class Univercidad
    {

        string nombreunivercidad;
        List<Docente> docentes = new List<Docente>();
        List<Alumno> alumnos = new List<Alumno>();
        List<Carrera> carreras = new List<Carrera>();
        Dictionary<string, string> alumnosRegistrados = new Dictionary<string, string>();

        public Univercidad(string nombre)
        {
            this.nombreunivercidad = nombre;
        }
        public void ingreseDocente(Docente docentes)
        {
            this.docentes.Add(docentes);
        }
        public void ingreseAlumnos(Alumno alumno)
        {
            this.alumnos.Add(alumno);
        }
        public void ingreseCarrera(Carrera materia)
        {
            this.carreras.Add(materia);
        }      
      
        public void imprimirUniversitarios()
        {
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.getNombre());
            }
        }
        public void imprimirCarreras()
        {
            foreach (Carrera carrera in carreras)
            {
                Console.WriteLine(carrera.getNombre());
            }
        }
     


        //ELIMINA ALUMNOS

        public void eliminarUniversitario(string nombreUniversitario)
        {
            List<Alumno> alumnosAUX = new List<Alumno>();
            foreach (Alumno universitario in alumnos)
            {
                alumnosAUX.Add(universitario);
            }

            foreach (Alumno alunos in alumnosAUX)
            {
                if (alunos.getNombre() == nombreUniversitario)
                {
                    alumnos.Remove(alunos);
                }
            }
        }

        //ELIMINO CARRERA

        public void eliminarCarrera(string nombreCarrera) 
        {
            List<Carrera> carrerasAux = new List<Carrera>();
            foreach (Carrera carrera in carreras)
            {
                carrerasAux.Add(carrera);
            }
            foreach (Carrera univercidad in carrerasAux)
            {
                if (univercidad.getNombre() == nombreCarrera)
                {
                    carreras.Remove(univercidad);
                }
            }
            
        }

        //Eliminar Docente
        public void eliminarDocente(string nombreDocente) 
        {
            List<Docente>docenteAux = new List<Docente>();
            foreach (Docente docente1 in docentes )
            {
                docenteAux.Add(docente1);
            }
            foreach (Docente univercidad in docenteAux)
            {
                if (univercidad.getNombre() == nombreDocente)
                {
                    docentes.Remove(univercidad);
                }
            }
        }

        


        public void registrarEnCarrera(string nombreCarrera, string nombreAlumno) 
        {
       
            alumnosRegistrados.Add(nombreCarrera, nombreAlumno);
        }
    }
}
