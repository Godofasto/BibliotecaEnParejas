using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEnParejas.Clases
{
    internal class Libros
    {
        private String ubicacion;
        private String titulo;
        private int identificador;

        public Libros(){}

        public void setUbicacion(String ubi)
        {
            this.ubicacion = ubi;
        }

        public void setTitulo(String tit)
        {
            this.titulo = tit;
        }

        public void setIdentificador(int id)
        {
            this.identificador = id;
        }

        public String getUbicacion()
        {
            return ubicacion;
        }

        public String getTitulo()
        {
            return titulo;
        }

        public int getIdentificador()
        {
            return identificador;
        }
    }

    
}
