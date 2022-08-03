using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class ConexionVentascs: Cl_conexiones
    {

        SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog =Gerizim ; Integrated Security = True");
        public void llenargrid(DataGridView grid)
        {
            SqlCommand cm = new SqlCommand("select f.numeroventa,f.estadoPago,f.fechaFactura,f.ID_sucursal,f.ID_cajas,f.fechaVencimientoFactura,f.ID_cliente,c.primernombre,d.precioproductohistorico,s.nombresucursal, d.cantidad_detalle ,f.ID_factura, f.fechafactura, d.cantidad_detalle , p.ID_factura from dbo.Cliente as c, dbo.Factura as f, dbo.Sucursal as s, dbo.Pedidos as p, dbo.Detalle as d inner join dbo.Factura as e on d.ID_factura = d.ID_factura  ", conex);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            grid.DataSource = dt;
            
        }
    }
}