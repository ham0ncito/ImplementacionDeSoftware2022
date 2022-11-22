using GerizimZZ.Clases;
using GerizimZZ.Datasets;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace GerizimZZ
{
    public partial class FrmInventario : Form
    {
        private Cl_Inventario productos = new Cl_Inventario();
        private Productosdst dstProducto;
        private DataTable dtProducto;
        private int codigo, cantidadproducto, cantidadminima, estadoproducto;
        private double precio_producto, pesoproducto;


        Validaciones validar = new Validaciones();

        public FrmInventario()
        {
            InitializeComponent();
            txtFechaingreso.Text = DateTime.Now.ToString("yyyy'-'mm'-'dd' 'hh:mm");
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            dtProducto = Cl_Inventario.GetAll();
            dstProducto = new Productosdst();
            dstProducto.Tables.Add(dtProducto);
            dgvProducto.DataSource = dstProducto.Tables[0];
            LoadHeader();
        }

        private void dgvProducto_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvProducto.SelectedRows)

            {
                //txtID_codigoProducto.Text = item.Cells[0].Value.ToString();
                txtPrecio_producto.Text = item.Cells[1].Value.ToString();
                txtNombreProducto.Text = item.Cells[2].Value.ToString();
                txtPesoProducto.Text = item.Cells[3].Value.ToString();
                txtCodigoBarra.Text = item.Cells[4].Value.ToString();
                txtCodigoCatologo.Text = item.Cells[5].Value.ToString();
                txtCantidadProducto.Text = item.Cells[6].Value.ToString();
                txtCantidadMinima.Text = item.Cells[7].Value.ToString();
                txtDescripcionProducto.Text = item.Cells[8].Value.ToString();
                txtEstadoPRoducto.Text = item.Cells[9].Value.ToString();
                txtFechaingreso.Text = item.Cells[10].Value.ToString();
                //dgvProducto.Columns["precio_producto"].HeaderText = "Precio";

            }
        }

        private void LoadHeader()
        {
            //this.dgvProducto.Columns[0].Name = "ID producto";
            //this.dgvProducto.Columns[1].Name = "ID producto";
            //this.dgvProducto.Columns[2].Name = "ID producto";
            //this.dgvProducto.Columns[3].Name = "ID producto";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dstProducto.Tables[0].DefaultView.RowFilter = /*string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "ID_codigoProducto", txtBuscar.Text) + " OR " +*/
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Precio producto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Nombre producto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Peso producto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Código de barra", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Código de Catálogo", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Cantidad producto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Cantidad minima", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Descripción producto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Estado producto", txtBuscar.Text); /*+ " OR " +*/
            //string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Fechaingreso", txtBuscar.Text);
            dgvProducto.DataSource = dstProducto.Tables[0].DefaultView;
        }


        private void txtPrecio_producto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese Solo Números", "Campo codigo producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }


        private void txtID_codigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese Solo Números", "Campo codigo producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Letras(e, txtPrecio_producto);
        }

        private void txtDescripcionProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Letras(e, txtPrecio_producto);
        }

        private void txtPesoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese Solo Números", "Campo peso producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtCodigoCatologo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese Solo Números", "Campo codigo catalogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese Solo Números", "Cantidad producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese Solo Números", "Campo Cantidad minima", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtEstadoPRoducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese Solo Números", "Estado producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox )
                {
                    if(c is not null)
                    {
                        c.Text = "";
                    }
                }
            }
            txtFechaingreso.Text = DateTime.Now.ToString("yyyy'-'mm'-'dd' 'hh:mm");
            txtFechaingreso.Focus();
            MessageBox.Show("Valores limpiados");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCatologo.Text == "" || txtDescripcionProducto.Text == "" || txtEstadoPRoducto.Text == "" || /*txtID_codigoProducto.Text == ""*/ /*||*/ txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecio_producto.Text == "")
                {
                    MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else
                {
                    //codigo = Convert.ToInt32(txtID_codigoProducto.Text);
                    cantidadproducto = Convert.ToInt32(txtCantidadProducto.Text);
                    cantidadminima = Convert.ToInt32(txtCantidadMinima.Text);
                    estadoproducto = Convert.ToInt32(txtEstadoPRoducto.Text);
                    precio_producto = Convert.ToDouble(txtPrecio_producto.Text);
                    pesoproducto = Convert.ToDouble(txtPesoProducto.Text);
                    //cambio de 1
                    int cantidadproductos = dtProducto.Rows.Count + 1;
                    codigo = cantidadproductos + 1;
                    productos.Agregar_Producto(codigo, precio_producto, txtNombreProducto.Text, pesoproducto, txtCodigoBarra.Text, txtCodigoCatologo.Text, cantidadproducto, cantidadminima, txtDescripcionProducto.Text, estadoproducto, txtFechaingreso.Text);
                    SqlConnection con = new SqlConnection("Data Source= localhost;Initial Catalog=Gerizim; Integrated Security=True;");
                    SqlDataAdapter comando = new SqlDataAdapter();
                    string sql = "SELECT * FROM Producto";
                    comando.SelectCommand = new SqlCommand(sql, con);
                    dtProducto = Cl_Inventario.GetAll();
                    dstProducto = new Productosdst();
                    dstProducto.Tables.Add(dtProducto);
                    dgvProducto.DataSource = dstProducto.Tables[0];
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar el producto " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //No sirve para nada este
        private void txtPrecio_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.Letras(e, txtPrecio_producto);
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCatologo.Text == "" || txtDescripcionProducto.Text == "" || txtEstadoPRoducto.Text == "" || txtFechaingreso.Text == ""/* || txtID_codigoProducto.Text == ""*/ || txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecio_producto.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //codigo = Convert.ToInt32(txtID_codigoProducto.Text);
                cantidadproducto = Convert.ToInt32(txtCantidadProducto.Text);
                cantidadminima = Convert.ToInt32(txtCantidadMinima.Text);
                estadoproducto = Convert.ToInt32(txtEstadoPRoducto.Text);
                precio_producto = Convert.ToDouble(txtPrecio_producto.Text);
                pesoproducto = Convert.ToDouble(txtPesoProducto.Text);
                productos.Modificar_Producto(codigo, precio_producto, txtNombreProducto.Text, pesoproducto, txtCodigoBarra.Text, txtCodigoCatologo.Text, cantidadproducto, cantidadminima, txtDescripcionProducto.Text, estadoproducto);
                SqlConnection con = new SqlConnection("Data Source= localhost;Initial Catalog=Gerizim; Integrated Security=True;");
                SqlDataAdapter comando = new SqlDataAdapter();
                string sql = "SELECT * FROM Producto";
                comando.SelectCommand = new SqlCommand(sql, con);
                dtProducto = Cl_Inventario.GetAll();
                dstProducto = new Productosdst();
                dstProducto.Tables.Add(dtProducto);
                dgvProducto.DataSource = dstProducto.Tables[0];
                con.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCatologo.Text == "" || txtDescripcionProducto.Text == "" || txtEstadoPRoducto.Text == "" || txtFechaingreso.Text == ""/* || txtID_codigoProducto.Text == ""*/ || txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecio_producto.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ID_codigoProducto;
                foreach (DataGridViewRow item in this.dgvProducto.SelectedRows)
                {
                    ID_codigoProducto = item.Cells[0].Value.ToString();
                    productos.Eliminar_Producto(Convert.ToInt32(ID_codigoProducto));
                }
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
                SqlDataAdapter comando = new SqlDataAdapter();
                string sql = "SELECT * FROM Producto";
                comando.SelectCommand = new SqlCommand(sql, con);
                dtProducto = Cl_Inventario.GetAll();
                dstProducto = new Productosdst();
                dstProducto.Tables.Add(dtProducto);
                dgvProducto.DataSource = dstProducto.Tables[0];
                con.Close();
            }
        }
    }
}