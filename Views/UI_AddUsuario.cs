using BaseDeDatos.Modelos;
using BaseDeDatos.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BaseDeDatos.Views
{
    public partial class UI_AddUsuario : Form
    {
        public UI_AddUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idUsuario = Guid.NewGuid().ToString();
            string nombreUsuario = textBox1.Text;
            string apellidoUsuario = textBox2.Text;
            string correoUsuario = textBox3.Text;
            string telefonoUsuario = textBox4.Text;
            string programaUsuario = textBox5.Text;
            int codigoUsuatio = int.Parse(textBox6.Text);
            //int idRolFK = 0;
            //string rolSelecionado = comboBox1.SelectedItem.ToString();
            //for (int i = 0; i < comboBox1.Items.Count; i++) 
            //{
            //    if(rolSelecionado == Roles[i].NombreRoles)
            //    {
            //        idRolFK = Roles[i].id_rol;
            //    }
            //}

            //Usuarios objUsuarios = new Usuarios(idUsuario, nombreUsuario, apellidoUsuario, correoUsuario, 
            //    telefonoUsuario, programaUsuario, idRolFK);

            Usuarios objUsuarios = new Usuarios(idUsuario, codigoUsuatio, nombreUsuario, apellidoUsuario, correoUsuario,
                telefonoUsuario, programaUsuario);

            ControllerUsuario objCUsuario = new ControllerUsuario();

            bool resultado = objCUsuario.InsertUsuario(objUsuarios);

            if (resultado)
            {
                MessageBox.Show("Usuario registrado");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
