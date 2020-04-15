using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadNegocio
{
    class Curso
    {
        private string descripcion;
        private List<Alumno> alumnos = new List<Alumno>();

        public void agregarAlumno(Alumno a)
        {
            this.alumnos.Add(a);
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public string getDescripcion()
        {
            return this.descripcion;
        }

    }
}
