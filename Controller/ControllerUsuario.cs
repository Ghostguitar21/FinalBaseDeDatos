using BaseDeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDeDatos.Controller
{
    public class ControllerUsuario
    {
        public bool InsertUsuario(Usuarios objUsuario)
        {
            bool resultado = false;
           
            string sql = $"INSERT INTO usuarios (id_usuario, codigo, nombre1U, apellido1U, correo, telefono, programa, activo, id_rol_FK) "
           + $"VALUES ('{objUsuario.Id_usuario}', '{objUsuario.Codigo}', '{objUsuario.Nombre1U}', '{objUsuario.Apellido1U}', '{objUsuario.Correo}', '{objUsuario.Telefono}', '{objUsuario.Programa}', '{objUsuario.Activo}', '{objUsuario.Id_rol_FK}');";


            ConnectionBD objConnectioBD = new ConnectionBD();
            resultado = objConnectioBD.ExceuteQuery(sql);

            return resultado;
        }
    }
}
