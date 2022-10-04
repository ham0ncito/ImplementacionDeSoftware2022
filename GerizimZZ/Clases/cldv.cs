using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient; 
using Microsoft.SqlServer; 
using System.Threading.Tasks;
using System.Security.Policy;
using System.Data;
using System.Windows.Forms;

namespace GerizimZZ.Clases

{
   internal class cldv: Cl_conexiones
    {

        public void llenarProductos(DataGridView dataGrid)
        {
            try
            {
                conex.Open();
                string query = " select nombreProducto as 'Nombre del producto', precio_producto as 'Precio de venta', cantidadProducto as 'Cantidad disponible', codigoBarra as 'Codigo de Barra del producto' from Producto order by nombreProducto ASC; \r\n";
                SqlCommand comando = new SqlCommand(query, conex);
                SqlDataAdapter sqlDA = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGrid.DataSource = dt;
                conex.Close(); 
            } catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

    }
}
