using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class Cl_Clientes : Cl_conexiones
    {
        private string iD_cliente;
        private string primerNombre_Cliente;
        private string segundoNombre_Cliente;
        private string primerApellido_Cliente;
        private string segunndoApellido_Cliente;
        private string direccion_Cliente;
        private string telefono_Cliente;

        public string ID_cliente { get => iD_cliente; set => iD_cliente = value; }
        public string PrimerNombre_Cliente { get => primerNombre_Cliente; set => primerNombre_Cliente = value; }
        public string SegundoNombre_Cliente { get => segundoNombre_Cliente; set => segundoNombre_Cliente = value; }
        public string PrimerApellido_Cliente { get => primerApellido_Cliente; set => primerApellido_Cliente = value; }
        public string SegunndoApellido_Cliente { get => segunndoApellido_Cliente; set => segunndoApellido_Cliente = value; }
        public string Direccion_Cliente { get => direccion_Cliente; set => direccion_Cliente = value; }
        public string Telefono_Cliente { get => telefono_Cliente; set => telefono_Cliente = value; }
        

        //llenado de la data table con los datos de Cliente de la BD
        public static DataTable GetAll()
        {
            SqlConnection con = Cl_conexiones.GetConnection();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Cliente";
            using (con)
            {
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                //creacion de la datatable
                DataTable table = new DataTable();
                table.Load(reader);
                return table;
            }
        }

        //funcion para agregar cliente a la BD
        public void Agregar_Cliente(string ID_cliente, string primerNombre_Cliente, string segundoNombre_Cliente, string primerApellido_Cliente, string segundoApellido_Cliente, string Telefono_Cliente, string Direccion_Cliente)
        {
            SqlConnection con = Cl_conexiones.GetConnection();
            // mensaje para asegurar que el usuario desea agregar el cliente
            DialogResult result = MessageBox.Show("Seguro que desea agregar el cliente?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //consulta hacia la BD
                string sql = "INSERT INTO Cliente(ID_cliente, primerNombre, segundoNombre, primerApellido, SegundoApellido, telefono, direccion) VALUES ('"
                + ID_cliente + "','" + primerNombre_Cliente + "','" + segundoNombre_Cliente + "','"
                + primerApellido_Cliente + "','" + segundoApellido_Cliente + "','" + Telefono_Cliente + "','" + Direccion_Cliente + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                //mensaje para confirmar que el registro fue agregado
                MessageBox.Show("Registro agregado con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //funcion para modificar el cliente seleccionado
        public void Modificar_Cliente(string ID_cliente, string primerNombre_Cliente, string segundoNombre_Cliente, string primerApellido_Cliente, string segundoApellido_Cliente, string Direccion_Cliente, string Telefono_Cliente)
        {
            SqlConnection con = Cl_conexiones.GetConnection();
            // mensaje para asegurar que el usuario desea modificar el cliente
            DialogResult result = MessageBox.Show("Seguro que desea Modificar el cliente?", "Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //consulta para la BD
                string sql = "UPDATE Cliente SET primerNombre = '" +
                primerNombre_Cliente + "', segundoNombre = '" +
                segundoNombre_Cliente + "', primerApellido = '" +
                primerApellido_Cliente + "', SegundoApellido = '" +
                segundoApellido_Cliente + "', telefono = '" +
                Telefono_Cliente + "', direccion  = '" +
                Direccion_Cliente + "' WHERE ID_cliente = '" +
                ID_cliente + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                //mensaje para confirmar que el registro fue modificado
                MessageBox.Show("Registro modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //funcion para eliminar el cliente
        public void Eliminar_Cliente(string ID_cliente)
        {
            SqlConnection con = Cl_conexiones.GetConnection();
            // mensaje para asegurar que el usuario desea eliminar el cliente
            DialogResult result = MessageBox.Show("Seguro que desea Eliminar?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // consulta para la BD
                string sql = "DELETE FROM Cliente WHERE ID_cliente = '" + ID_cliente + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                //mensaje para confirmar que el registro se elimino
                MessageBox.Show("Registro eliminado con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}