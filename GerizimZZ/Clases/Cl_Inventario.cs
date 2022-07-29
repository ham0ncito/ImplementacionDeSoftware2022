using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class Cl_Inventario : Cl_conexiones
    {
        private SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
        private int iD_codigoProducto;
        private double precio_producto;
        private string nombreProducto;
        private double pesoProducto;
        private string codigoBarra;
        private string codigoCatologo;
        private int cantidadProducto;
        private int cantidadMinima;
        private string descripcionProducto;
        private int estadoPRoducto;
        private string fechaingreso;

        public int ID_codigoProducto { get => iD_codigoProducto; set => iD_codigoProducto = value; }
        public double Precio_producto { get => precio_producto; set => precio_producto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double PesoProducto { get => pesoProducto; set => pesoProducto = value; }
        public string CodigoBarra { get => codigoBarra; set => codigoBarra = value; }
        public string CodigoCatologo { get => codigoCatologo; set => codigoCatologo = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public int CantidadMinima { get => cantidadMinima; set => cantidadMinima = value; }
        public string DescripcionProducto { get => descripcionProducto; set => descripcionProducto = value; }
        public int EstadoPRoducto { get => estadoPRoducto; set => estadoPRoducto = value; }
        public string Fechaingreso { get => fechaingreso; set => fechaingreso = value; }

        //funcion para traer la conexion a la BD
        private static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
            return con;
        }

        //funcion para llenar el datatable con la tabla Producto de la BD
        public static DataTable GetAll()
        {
            SqlConnection con = GetConnection();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Producto";
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

        ////funcion para agregar producto a la BD
        public void Agregar_Producto(int ID_codigoProducto, double Precio_producto, string NombreProducto, double PesoProducto, string CodigoBarra, string CodigoCatologo, int CantidadProducto, int CantidadMinima, string DescripcionProducto, int EstadoPRoducto, string Fechaingreso)
        {
            // mensaje para asegurar que el usuario desea agregar el producto
            DialogResult result = MessageBox.Show("Seguro que desea agregar el producto?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //consulta hacia la BD
                string sql = "INSERT INTO Producto(ID_codigoProducto, Precio_producto, NombreProducto, PesoProducto, CodigoBarra, CodigoCatologo, CantidadProducto, CantidadMinima, DescripcionProducto, EstadoPRoducto, Fechaingreso) VALUES ('"
                + ID_codigoProducto + "','" + Precio_producto + "','" + NombreProducto + "','" + PesoProducto + "','" + CodigoBarra + "','" + CodigoCatologo +
                "','" + CantidadProducto + "','" + CantidadMinima + "','" + DescripcionProducto + "','" + EstadoPRoducto + "','" + Fechaingreso + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                //mensaje para confirmar que el registro fue agregado
                MessageBox.Show("Registro agregado con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //funcion para modificar el producto seleccionado
        public void Modificar_Producto(int ID_codigoProducto, double Precio_producto, string NombreProducto, double PesoProducto, string CodigoBarra, string CodigoCatologo, int CantidadProducto, int CantidadMinima, string DescripcionProducto, int EstadoPRoducto, string Fechaingreso)
        {
            // mensaje para asegurar que el usuario desea modificar el producto
            DialogResult result = MessageBox.Show("Seguro que desea Modificar el producto?", "Modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //consulta hacia la BD
                string sql = "UPDATE Producto SET precio_producto = '" +
                Precio_producto + "', nombreProducto = '" +
                NombreProducto + "', pesoProducto = '" +
                PesoProducto + "', codigoBarra = '" +
                CodigoBarra + "', codigoCatologo = '" +
                CodigoCatologo + "', cantidadProducto  = '" +
                CantidadProducto + "', cantidadMinima  = '" +
                CantidadMinima + "', descripcionProducto  = '" +
                DescripcionProducto + "', estadoPRoducto  = '" +
                EstadoPRoducto + "', fechaingreso  = '" +
                Fechaingreso + "' WHERE ID_codigoProducto = '" +
                ID_codigoProducto + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                //mensaje para confirmar que el registro fue modificado
                MessageBox.Show("Registro modificado con exito", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //funcion para eliminar el producto seleccionado
        public void Eliminar_Producto(int ID_codigoProducto)
        {
            // mensaje para asegurar que el usuario desea eliminar el producto
            DialogResult result = MessageBox.Show("Seguro que desea Eliminar?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //consulta hacia la BD
                string sql = "DELETE FROM Producto WHERE ID_codigoProducto = '" + ID_codigoProducto + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                //mensaje para confirmar que el registro fue eliminado
                MessageBox.Show("Registro eliminado con exito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}