﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GerizimZZ
{
    internal class conexionfactura
    {
        SqlConnection conec = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        public void datosgrid(DataGridView grid)
        {
            SqlCommand cm = new SqlCommand("select c.primernombre,d.precioproductohistorico,s.nombresucursal, d.cantidad_detalle ,f.ID_factura, f.fechafactura, d.cantidad_detalle , p.ID_factura from dbo.Cliente as c, dbo.Factura as f, dbo.Sucursal as s, dbo.Pedidos as p, dbo.Detalle as d inner join dbo.Factura as e on d.ID_factura = d.ID_factura where d.ID_factura = 10006 ;", conec);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            grid.DataSource = dt;
        }
    }
}
