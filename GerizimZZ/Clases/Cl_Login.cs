using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class Cl_Login
    {
        private string nombreUsuario { get; set; }
        private string contraseñaUsuario { get; set; }

        public bool iniciarSesion(string nombreUsuario, string contraseñaUsuario)
        {
            // conexion a la BD
            SqlConnection con = Cl_conexiones.GetConnection();
            // asignacion de variables
            this.nombreUsuario = nombreUsuario;
            this.contraseñaUsuario = contraseñaUsuario;
            // llamar al formulario de login
            FrmLogin login = new FrmLogin();
            // booleano para saber si entro o no al sistema
            bool entro = false;
            // consulta a la tabla usuarios de la Bd para confirmar autenticacion al sistema
            string sql = "SELECT * FROM Usuarios WHERE nombreUsuario = '" + nombreUsuario + "' AND contraseñaUsuario = '" + contraseñaUsuario + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                // mensaje de log in exitoso al sistema
                MessageBox.Show("Bienvenido/a de nuevo " + dr[1].ToString(), "Log In Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                entro = true;
            }
            else
            {
                // mensaje de error por no encontrar el usuario y contraseña de la base de datos del sistema
                MessageBox.Show("Datos incorrectos", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            return entro;
        }
    }
}