using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDeDatos.Modelos
{
    public class Detalles_Solicitud
    {
        private int id_detalle;
        private int id_solicitud_FK;
        private int id_equipo_FK;

        public Detalles_Solicitud()
        {

        }

        public Detalles_Solicitud(int id_detalle, int id_solicitud_FK, int id_equipo_FK)
        {
            this.id_detalle = id_detalle;
            this.id_solicitud_FK = id_solicitud_FK;
            this.id_equipo_FK = id_equipo_FK;
        }

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Id_solicitud_FK { get => id_solicitud_FK; set => id_solicitud_FK = value; }
        public int Id_equipo_FK { get => id_equipo_FK; set => id_equipo_FK = value; }
    }
}
