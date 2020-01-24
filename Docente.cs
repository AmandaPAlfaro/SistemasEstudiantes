﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univercidad
{
    class Docente
    {
        private string nombre;
        private static int codigo = 0;
        private string profesion;
        List<Materia> materia = new List<Materia>();
        public Docente(string nombre)
        {
            this.nombre = nombre;
        }

        public void ingresaProfecion(string profesion)
        {
            this.profesion = profesion;
        }
        public void ingreseMateria( Materia materia)
        {
           this.materia.Add(materia);
        }
        public string getNombre()
        {
            return nombre;
        }

    }
}
