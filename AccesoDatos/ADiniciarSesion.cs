﻿using ConectarRedReal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class ADiniciarSesion
    {
        public void IniciarSesion(string usuario, string pass)
        {
            MySqlConnection con = new MySqlConnection("server=localhost; Database=agenciaautomotriz; User Id=root; password=");
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error "+ex.ToString());
                throw;
            }
            string sql = string.Format("select nombre, pass from usuario where nombre='{0}' and pass='{1}'",usuario,pass);
            MySqlCommand cmd = new MySqlCommand(con,sql);
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                MessageBox.Show("Bienvenido");
            }
            else
                MessageBox.Show("El usuario no existe");
        }
    }
}