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
using System.Drawing.Printing;
using System.Windows.Markup;


namespace GerizimZZ.Clases

{
   public class ClDetalleVentas: Cl_conexiones
    {
        SqlDataAdapter sqlDA;
        DataTable dt;
        public void llenarProductos(DataGridView dataGrid)
        {
            try
            {
                conex.Open();
                string query = " select nombreProducto as 'Nombre del producto', precio_producto as 'Precio de venta', cantidadProducto as 'Cantidad disponible', codigoBarra as 'Codigo de Barra del producto' from Producto order by nombreProducto ASC; \r\n";
                SqlCommand comando = new SqlCommand(query, conex);
                sqlDA = new SqlDataAdapter(comando);
                dt = new DataTable();
                sqlDA.Fill(dt);
                dataGrid.DataSource = dt;
                conex.Close();
                comando.Dispose();
                
            } catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }
        
        

        
        public void llenarClientes(ComboBox combo)
        {
            try
            {
                
                SqlCommand comando = new SqlCommand("exec nombres; ", conex);
                conex.Open();
                combo.Items.Clear();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    combo.Items.Add(registro["Nombre"]).ToString();
                   
                }
                conex.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }

        }
        public void buscarId(ComboBox cmbCliente, Label lblCodigoCliente, ComboBox cmbNumero, ComboBox cmbDireccion)
        {

            try
            {
                SqlCommand comando = new SqlCommand(" exec buscarId '" + cmbCliente.Text + "' ; ", conex);
                conex.Open();
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    lblCodigoCliente.Text = registro[0].ToString();
                    cmbNumero.Items.Add(registro["telefono"].ToString());
                    cmbDireccion.Items.Add(registro["direccion"].ToString());
                }
                else
                {
                    MessageBox.Show("Tuvimos un problema buscando la informacion del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conex.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }
        public void telefonosDireccion(Label lblCodigoCliente, ComboBox cmbNumero, ComboBox cmbDireccion)
        {
            try
            {
                
                SqlCommand comando = new SqlCommand(" exec Telefonos '" + lblCodigoCliente.Text + "' ; ", conex);
                conex.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read() && !(registro.IsDBNull(0) == true))
                {
                    cmbNumero.Items.Add(registro[0].ToString());
                }

                comando.Dispose();
                conex.Close();
                direccion(lblCodigoCliente, cmbDireccion);

            }

            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public void direccion(Label lblCodigoCliente, ComboBox cmbDireccion)
        {
           
            conex.Open();
            SqlCommand coma = new SqlCommand(" exec Direcciones '" + lblCodigoCliente.Text + "' ; ", conex);
            SqlDataReader regist = coma.ExecuteReader();
            while (regist.Read() && !(regist.IsDBNull(0) == true))
            {
                cmbDireccion.Items.Add(regist[0].ToString());
            }
            conex.Close();
        }
        public void ventecita(Label lblNumeroFactura, Label lblCodigoCliente, DataGridView dgDetalleVenta, CheckBox delivery, ComboBox cmbDireccion, ComboBox cmbNumero)
        {
            try
            {
                conex.Open();
                try
                {
                    SqlCommand comando = new SqlCommand("exec ventaNueva '" + lblNumeroFactura.Text + "', '" + lblCodigoCliente.Text + "','1','1'", conex);
                    comando.ExecuteNonQuery();
                }
                catch (SqlException x)
                {
                    MessageBox.Show(x.Message);
                }
                foreach (DataGridViewRow row in dgDetalleVenta.Rows)
                {
                    SqlCommand comando = new SqlCommand("exec detalleVenta '" + lblNumeroFactura.Text.ToString() + "','" + row.Cells[2].Value + "' , '" + row.Cells[3].Value + "' , '" + row.Cells[0].Value + "';", conex);
                    comando.ExecuteNonQuery();
                }
                if (delivery.Checked)
                {
                    Random rand = new Random();
                    int id = rand.Next(1, 5);
                    SqlCommand comando = new SqlCommand("exec nuevoPedido '" + lblNumeroFactura.Text + "','" + id.ToString() + "', '" + cmbDireccion.Text + "', ' " + cmbNumero.Text + "';", conex);
                    comando.ExecuteNonQuery();
                }
                conex.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
           


        }

        public void recargito(Label lblNumeroFactura)
        {
            int numeroFactura = 0;

            conex.Open();
            SqlCommand comando = new SqlCommand("Use Gerizim; select MAX(ID_factura) from Factura ;", conex);
            comando.Parameters.AddWithValue("ID", lblNumeroFactura.Text);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                numeroFactura = Convert.ToInt32(registro[0]) + 1;
                lblNumeroFactura.Text = numeroFactura.ToString();
            }
            conex.Close();

        }

        public void ejecutar(string consulta)
        {
            conex.Open();
            SqlCommand comandito = new SqlCommand(consulta, conex);
            comandito.ExecuteNonQuery();
            conex.Close(); 
        }

        public void nombre(TextBox txtFiltrar, DataGridView dgProductos)
        {
            

           
        }
    }
}
