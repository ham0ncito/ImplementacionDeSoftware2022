using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class ConexionPedido: Cl_conexiones
    {
        
        public void llenargrid(DataGridView grid)
        {
            SqlCommand cm = new SqlCommand("SELECT TOP (1000) [fechapedido] as 'Fecha del Pedido',[fechaentrega] as 'Fecha del pedido'\r\n      ,[direccionEntrega] as 'Direccion de entrega'\r\n      ,[estadoentrega] as 'Estado de la entrega'\r\n      ,[ID_factura] as 'Numero de factura'\r\n      ,[ID_repartidores] as 'Codigo de repartidor'\r\n      ,[telefonoContacto] as 'Telefono de contacto'\r\n  FROM [Gerizim].[dbo].[Pedidos]", conex);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt); //Para llenar la tabla con lo que está dentro de DataAdapter

            grid.DataSource = dt;
        }
    }
}