using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDeDatos.Modelos
{
    public class Solicitudes_prestamo
    {
        private int id_solicitudes_prestamo;
        private DateTime fecha_solicitud;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private string estado_solicitud;
        private string observacion;
        private int id_usuario_FK;

        public Solicitudes_prestamo()
        {

        }

        public Solicitudes_prestamo(int id_solicitudes_prestamo, DateTime fecha_solicitud, DateTime fecha_inicio, DateTime fecha_fin, string estado_solicitud, string observacion, int id_usuario_FK)
        {
            this.id_solicitudes_prestamo = id_solicitudes_prestamo;
            this.fecha_solicitud = fecha_solicitud;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
            this.estado_solicitud = estado_solicitud;
            this.observacion = observacion;
            this.id_usuario_FK = id_usuario_FK;
        }

        public int Id_solicitudes_prestamo { get => id_solicitudes_prestamo; set => id_solicitudes_prestamo = value; }
        public DateTime Fecha_solicitud { get => fecha_solicitud; set => fecha_solicitud = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public string Estado_solicitud { get => estado_solicitud; set => estado_solicitud = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public int Id_usuario_FK { get => id_usuario_FK; set => id_usuario_FK = value; }
    }
}
