using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDeDatos.Modelos
{
    public class Estado_equipos
    {
        private int id_estado_equipo;
        private string nombre_estado;
        private string descripcion_estado;

        public Estado_equipos()
        {
            
        }
        public Estado_equipos(int id_estado_equipo, string nombre_estado, string descripcion_estado)
        {
            this.id_estado_equipo = id_estado_equipo;
            this.nombre_estado = nombre_estado;
            this.descripcion_estado = descripcion_estado;
        }
        public int Id_estado_equipo { get => id_estado_equipo; set => id_estado_equipo = value; }
        public string Nombre_estado { get => nombre_estado; set => nombre_estado = value; }
        public string Descripcion_estado { get => descripcion_estado; set => descripcion_estado = value; }
    }
}
