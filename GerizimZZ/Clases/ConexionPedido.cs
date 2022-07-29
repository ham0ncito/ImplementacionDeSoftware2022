using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class ConexionPedido: Cl_conexiones
    {
        
        //funcion para el llenado de la datatable con la tabla pedidos de la BD
        public void llenargrid(DataGridView grid)
        {
            SqlCommand cm = new SqlCommand("Select * From Pedidos", conex);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt); //Para llenar la tabla con lo que está dentro de DataAdapter

            // asignarle al data source la datatable llena 
            grid.DataSource = dt;
        }
    }
}