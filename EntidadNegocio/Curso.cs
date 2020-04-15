using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadNegocio
{
    class Curso
    {
        private string brach_pp_descripcion;
        private List<Alumno> alumnos = new List<Alumno>();

        public void agregarAlumno(Alumno a)
        {
            this.alumnos.Add(a);
        }

        public void setDescripcion(string descripcion)
        {
            this.brach_pp_descripcion = descripcion;
        }
        public string getDescripcion()
        {
            return this.brach_pp_descripcion;
        }

    }
}
