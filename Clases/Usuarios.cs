using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEnParejas.Clases
{
    internal class Usuarios
    {
        private String tipo;
        private String nombre;
        private String departamento;
        private DateTime fechaSancion;  //Revisar si las fechas se ponen asi

        public Usuarios() { }

        public void setTipo(String tip)
        {
            this.tipo = tip;
        }
        public void setNombre(String nom)
        {
            this.nombre = nom;
        }
        public void setDepartamento(String depar)
        {
            this.departamento = depar;
        }
        public void setFechaSancion(DateTime fechaSan)
        {
            this.fechaSancion = fechaSan;
        }
    }
}
