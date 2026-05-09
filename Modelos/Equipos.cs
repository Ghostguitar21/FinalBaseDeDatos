using System;
using System.Collections.Generic;
using System.Text;

namespace BaseDeDatos.Modelos
{
    public class Equipos
    {
        private int id_equipo;
        private string codigo_interno;
        private string nombre;
        private string marca;
        private string modelo;
        private string descripcion;
        private DateTime fecha_compra;
        private string archivo;
        private int id_categoria_FK;
        private int id_estado_FK;

        public Equipos()
        {

        }

        public Equipos(int id_equipo, string codigo_interno, string nombre,
            string marca, string modelo, string descripcion,
            DateTime fecha_compra, string archivo,
            int id_categoria_FK, int id_estado_FK)
        {
            this.id_equipo = id_equipo;
            this.codigo_interno = codigo_interno;
            this.nombre = nombre;
            this.marca = marca;
            this.modelo = modelo;
            this.descripcion = descripcion;
            this.fecha_compra = fecha_compra;
            this.archivo = archivo;
            this.id_categoria_FK = id_categoria_FK;
            this.id_estado_FK = id_estado_FK;
        }

        public int Id_equipo { get => id_equipo; set => id_equipo = value; }
        public string Codigo_interno { get => codigo_interno; set => codigo_interno = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha_compra { get => fecha_compra; set => fecha_compra = value; }
        public string Archivo { get => archivo; set => archivo = value; }
        public int Id_categoria_FK { get => id_categoria_FK; set => id_categoria_FK = value; }
        public int Id_estado_FK { get => id_estado_FK; set => id_estado_FK = value; }
    }
}
