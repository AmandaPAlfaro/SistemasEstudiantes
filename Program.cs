using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univercidad
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("* UNIVERCIDAD *");
            Console.WriteLine();
            Console.WriteLine("Ingrese a cual univercidad quiere entrar: ");
            string nombreUnivercidad = Console.ReadLine();
            Univercidad univercidad = new Univercidad(nombreUnivercidad);
            Console.WriteLine();

            Console.WriteLine("Ingrese Notas");
            string notas = Console.ReadLine();
            Console.WriteLine();

            Carrera sistemas = new Carrera("sistemas");
            Carrera enfermeria = new Carrera("enfermeria");
            Carrera informatica = new Carrera("informatica");
            univercidad.ingreseCarrera(sistemas);
            univercidad.ingreseCarrera(enfermeria);
            univercidad.ingreseCarrera(informatica);

            Console.WriteLine();           
            Console.WriteLine("Las carreras disponibles son: ");
            univercidad.imprimirCarreras();
            Console.WriteLine();

            //carreras eliminadas

            Console.WriteLine("Insertar la carrera que eliminara");
            string carreraeliminar = Console.ReadLine();
            univercidad.eliminarCarrera(carreraeliminar);
            Console.WriteLine();
            Console.WriteLine("Las carreras son: ");
            univercidad.imprimirCarreras();
            Console.WriteLine();

            Console.WriteLine("Aque carrera quiere registrarce: ");
            string nombrecarrera = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Las Materias que hay en la carrera son:");
            Console.WriteLine("Quimica,matematicas,fisica,algebra");

            Console.WriteLine();

            Console.WriteLine("Cual es la materia que decea pasar:");
            Console.WriteLine();
            Materia Materia1 = new Materia();
            string Materia = Console.ReadLine();

            Console.WriteLine("Temarios");
            string temario = Console.ReadLine();
            Console.WriteLine();

            int cont = 0;
            do
            {
                Console.WriteLine("Ingrese el Nombre del Alumno");
                string nombreAlumno = Console.ReadLine();
                Alumno Alumno11 = new Alumno(nombreAlumno);
                univercidad.ingreseAlumnos(Alumno11);
                Console.WriteLine("El codigo del univercitario es:" + Alumno11.getCodigo());
             

                Console.WriteLine();
                cont++;

            } while (cont < 4);

            Console.WriteLine();
            Console.WriteLine("Listas de estudiantes: ");
            univercidad.imprimirUniversitarios();
            Console.WriteLine();

            //Eliminar Alumnos

            Console.WriteLine("Insertar los alumnos que quiere eliminar");
            string alumnoseliminar = Console.ReadLine();
            univercidad.eliminarUniversitario(alumnoseliminar);
            Console.WriteLine();
            Console.WriteLine("Los alumnos eliminados son: ");
            univercidad.imprimirUniversitarios();
            Console.WriteLine();


            Console.WriteLine("Ingrese nuevo nombre");
            string nombreAlumno1 = Console.ReadLine();
            Console.WriteLine("los estudiantes registrados son " + nombreAlumno1 + " \n Su carrera es: " + nombrecarrera);
            string nombreUniversitario1 = Console.ReadLine();


          


            //Console.WriteLine("Ingrese el Nombre de la carrera que decea estudiar:");
            //string nombreCarrera = Console.ReadLine();
            //Alumno Carrera1 = new Alumno(nombreCarrera);
            //Console.WriteLine();

            //Console.WriteLine("El codigo del carrera es:" + Carrera1.getCodigo());
            //Console.WriteLine();

            Console.WriteLine("***DDOSENTES***");
            Console.WriteLine("Ingrese el Nombre del Docente");
            string nombreDocente = Console.ReadLine();
            Alumno Docente1= new Alumno(nombreDocente);
            Console.WriteLine();

            //Docentes eliminados


            Console.WriteLine("Insertar la carrera que eliminara");
            string docenteseliminar = Console.ReadLine();
            univercidad.eliminarDocente(docenteseliminar);
            Console.WriteLine();
            Console.WriteLine("Los docentes son: ");
            univercidad.imprimirCarreras();
            Console.WriteLine();

            Console.WriteLine("Profecion del docente");
            string profecion = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("El codigo del Docente es:" + Docente1.getCodigo());




            Console.ReadLine();
        }
    }
}
