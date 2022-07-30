using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class ConexionVentascs: Cl_conexiones
    {

        SqlConnection conex = new SqlConnection("Data Source = TATO180\\SQLEXPRESS; Initial Catalog =Gerizim ; Integrated Security = True");
        public void llenargrid(DataGridView grid)
        {
            SqlCommand cm = new SqlCommand("Select * from Factura ", conex);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            grid.DataSource = dt;
            
        }
    }
}