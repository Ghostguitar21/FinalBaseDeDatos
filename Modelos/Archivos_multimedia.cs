using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDeDatos.Modelos
{
    public class Archivos_multimedia
    {
        private int id_archivo;
        private string nombre_archivo;
        private string tipo_archivo;
        private string ruta_archivo;
        private string descripcion;
        private string principal;
        private int id_equipo_FK;

        public Archivos_multimedia()
        {
            
        }

        public Archivos_multimedia(int id_archivo, string nombre_archivo,
            string tipo_archivo, string ruta_archivo, string descripcion,
            string principal, int id_equipo_FK)
        {
            this.id_archivo = id_archivo;
            this.nombre_archivo = nombre_archivo;
            this.tipo_archivo = tipo_archivo;
            this.ruta_archivo = ruta_archivo;
            this.descripcion = descripcion;
            this.principal = principal;
            this.id_equipo_FK = id_equipo_FK;
        }

        public int Id_archivo { get => id_archivo; set => id_archivo = value; }
        public string Nombre_archivo { get => nombre_archivo; set => nombre_archivo = value; }
        public string Tipo_archivo { get => tipo_archivo; set => tipo_archivo = value; }
        public string Ruta_archivo { get => ruta_archivo; set => ruta_archivo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Principal { get => principal; set => principal = value; }
        public int Id_equipo_FK { get => id_equipo_FK; set => id_equipo_FK = value; }
    }
}
