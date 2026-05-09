using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDeDatos.Modelos
{
    public class Categoria_equipos
    {
        private int id_categoria;
        private string nombre_categoria;
        private string descripcion_categoria;

        public Categoria_equipos()
        {
          
        }
        public Categoria_equipos(int id_categoria, string nombre_categoria, string descripcion_categoria)
        {
            this.id_categoria = id_categoria;
            this.nombre_categoria = nombre_categoria;
            this.descripcion_categoria = descripcion_categoria;
        }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre_categoria { get => nombre_categoria; set => nombre_categoria = value; }
        public string Descripcion_categoria { get => descripcion_categoria; set => descripcion_categoria = value; }
    }
}
