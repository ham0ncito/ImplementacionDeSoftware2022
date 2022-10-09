using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class ConexionVentascs: Cl_conexiones
    {
       
        public void llenargrid(DataGridView grid)
        {
            SqlCommand cm = new SqlCommand("SELECT TOP (1000) [ID_factura] as 'Codigo de factura'\r\n      ,[numeroventa] as 'Numero de venta'\r\n      ,[fechaFactura] as 'Fecha de emisión'\r\n      ,[fechaVencimientoFactura] as 'Fecha de vencimiento'\r\n      ,[estadoPago] as 'Estado de pago'\r\n      ,[ID_cliente] as 'Codigo de cliente'\r\n      ,[ID_sucursal] as 'Id Sucursal'\r\n      ,[ID_cajas] as 'Id caja de venta'\r\n  FROM [Gerizim].[dbo].[Factura]\r\n ", conex);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);
    
            grid.DataSource = dt;
            
        }
    }
}