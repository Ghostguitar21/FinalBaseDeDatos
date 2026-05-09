using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDeDatos.Modelos
{
    public class Roles
    {
        private int id_rol;
        private string nombre_rol;
        private string descripcion;

        public Roles()
        {
           
        }

        public Roles(int id_rol, string nombre_rol, string descripcion)
        {
            this.id_rol = id_rol;
            this.nombre_rol = nombre_rol;
            this.descripcion = descripcion;
        }

        public int Id_rol { get => id_rol; set => id_rol = value; }
        public string Nombre_rol { get => nombre_rol; set => nombre_rol = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }

    
}
