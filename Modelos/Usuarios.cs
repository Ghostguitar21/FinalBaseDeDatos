using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDeDatos.Modelos
{
    public class Usuarios
    {
        private int id_usuario;
        private int codigo;
        private string nombre1U;
        //private string nombre2U;
        private string apellido1U;
        //private string apellido2U;
        private string correo;
        private string telefono;
        private string programa;
        private string activo;
        private string id_rol_FK;

        public Usuarios()
        {
           
        }

        public Usuarios(int id_usuario, int codigo, string nombre1U, string nombre2U, 
            string apellido1U, string apellido2U, string correo, string telefono, 
            string programa, string activo, string id_rol_FK)
        {
            this.id_usuario = id_usuario;
            this.codigo = codigo;
            this.nombre1U = nombre1U;
            //this.nombre2U = nombre2U;
            this.apellido1U = apellido1U;
            //this.apellido2U = apellido2U;
            this.correo = correo;
            this.telefono = telefono;
            this.programa = programa;
            this.activo = activo;
            this.id_rol_FK = id_rol_FK;
        }

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre1U { get => nombre1U; set => nombre1U = value; }
        //public string Nombre2U { get => nombre2U; set => nombre2U = value; }
        public string Apellido1U { get => apellido1U; set => apellido1U = value; }
        //public string Apellido2U { get => apellido2U; set => apellido2U = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Programa { get => programa; set => programa = value; }
        public string Activo { get => activo; set => activo = value; }
        public string Id_rol_FK { get => id_rol_FK; set => id_rol_FK = value; }
    }
}
