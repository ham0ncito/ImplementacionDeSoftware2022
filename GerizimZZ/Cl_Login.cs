﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace GerizimZZ
{
    internal class Cl_Login
    {
        SqlConnection con = new SqlConnection("Data Source=MEMO;Initial Catalog=GERIZIM; Integrated Security=True;");
        private String nombreUsuario { get; set; }
        private string contraseñaUsuario { get; set; }

        public bool iniciarSesion(string nombreUsuario, String contraseñaUsuario)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseñaUsuario = contraseñaUsuario;
            FrmLogin login = new FrmLogin();
            bool entro = false;
            string sql = "SELECT * FROM Usuarios WHERE nombreUsuario = '" + nombreUsuario + "' AND contraseñaUsuario = '" + contraseñaUsuario + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login exitoso", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                entro = true;
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return entro;
        }
    }
}