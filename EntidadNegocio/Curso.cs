using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadNegocio
{
    class Curso
    {
        public string descripcion { get; set; }
        private List<Alumno> alumnos = new List<Alumno>();

        public void agregarAlumno(Alumno a)
        {
            this.alumnos.Add(a);
        }



    }
}
