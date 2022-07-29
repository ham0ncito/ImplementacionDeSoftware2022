using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class Cl_SolicitarInventario
    {
        // funcion para el llenado de la datatable con la tabla de Producto de la BD
        public static DataTable GetAll()
        {
            // conexion a la BD
            SqlConnection conec = Cl_conexiones.GetConnection();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conec;
            comando.CommandType = CommandType.Text;
            // llenado del sqlcommand con los datos de la tabla producto de la BD
            comando.CommandText = "SELECT * FROM Producto";
            using (conec)
            {
                conec.Open();
                // llenado del reader con los datos de la tabla de producto
                SqlDataReader reader = comando.ExecuteReader();
                // creacion de la datatable
                DataTable table = new DataTable();
                table.Load(reader);
                return table;
            }
        }

        // funcion para agregar la solicitud del producto
        public void Agregar_Solicitud(int ID_codigoProducto, double Precio_producto, string NombreProducto, double PesoProducto, string CodigoBarra, string CodigoCatologo, int CantidadProducto, int CantidadMinima, string DescripcionProducto, int EstadoPRoducto, DateTime Fechaingreso)
        {
            // conexion a la BD
            SqlConnection conec = Cl_conexiones.GetConnection();
            // mensaje para confirmar la solicitud del producto al usuario
            DialogResult result = MessageBox.Show("Seguro que desea solicitar el producto?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // consulta para la BD
                    string sql = "INSERT INTO Producto(ID_codigoProducto, Precio_producto, NombreProducto, PesoProducto, CodigoBarra, CodigoCatologo, CantidadProducto, CantidadMinima, DescripcionProducto, EstadoPRoducto, Fechaingreso) VALUES ('"
                    + ID_codigoProducto + "','" + Precio_producto + "','" + NombreProducto + "','" + PesoProducto + "','" + CodigoBarra + "','" + CodigoCatologo +
                    "','" + CantidadProducto + "','" + CantidadMinima + "','" + DescripcionProducto + "','" + EstadoPRoducto + "','" + Convert.ToDateTime(Fechaingreso) + "')";
                    conec.Open();
                    SqlCommand cmd = new SqlCommand(sql, conec);
                    cmd.ExecuteNonQuery();
                    conec.Close();
                    // mensaje para confirmar que el registro se agrego correctamente
                    MessageBox.Show("Registro agregado con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }
    }
}