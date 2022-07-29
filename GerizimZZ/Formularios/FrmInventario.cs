using GerizimZZ.Clases;
using GerizimZZ.Datasets;
using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ
{
    public partial class FrmInventario : Form
    {
        // instanciamos la clase de inventario con el nombre productos
        private Cl_Inventario productos = new Cl_Inventario();
        // creamos una variable de nuestro dataset
        private Productosdst dstProducto;
        // creamos una variable de nuestro datatable
        private DataTable dtProducto;
        private int codigo, cantidadproducto, cantidadminima, estadoproducto;
        private double precio_producto, pesoproducto;

        public FrmInventario()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            // llenamos el datatable con la informacion del metodo GetAll de nuestra clase de inventario
            dtProducto = Cl_Inventario.GetAll();
            // instanciamos nuestro dataset
            dstProducto = new Productosdst();
            // llenamos el dataset con el datatable lleno
            dstProducto.Tables.Add(dtProducto);
            // llenamos el datagridview con nuestro dataset
            dgvProducto.DataSource = dstProducto.Tables[0];
        }

        private void dgvProducto_Click(object sender, EventArgs e)
        {
            // hacemos un for que recorra todo los items del datagridview para asignarle a los textboxs los valores del datagridview segun el click del usuario
            foreach (DataGridViewRow item in this.dgvProducto.SelectedRows)
            {
                txtID_codigoProducto.Text = item.Cells[0].Value.ToString();
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
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // hacemos un filtrado por fila del datagridview para poder buscar un elemento deseado por el usuario
            dstProducto.Tables[0].DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "ID_codigoProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Precio_producto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "NombreProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "PesoProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "CodigoBarra", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "CodigoCatologo", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "CantidadProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "CantidadMinima", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "DescripcionProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "EstadoPRoducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Fechaingreso", txtBuscar.Text);
            dgvProducto.DataSource = dstProducto.Tables[0].DefaultView;
        }

        // funcion para agregar producto
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCatologo.Text == "" || txtDescripcionProducto.Text == "" || txtEstadoPRoducto.Text == "" || txtFechaingreso.Text == "" || txtID_codigoProducto.Text == "" || txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecio_producto.Text == "")
            {
                // mensaje de error al usuario para que los campos no vayan vacios
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // convertimos los valores ya sea para numeros enteros o dobles para que sean del mismo valor a la BD
                codigo = Convert.ToInt32(txtID_codigoProducto.Text);
                cantidadproducto = Convert.ToInt32(txtCantidadProducto.Text);
                cantidadminima = Convert.ToInt32(txtCantidadMinima.Text);
                estadoproducto = Convert.ToInt32(txtEstadoPRoducto.Text);
                precio_producto = Convert.ToDouble(txtPrecio_producto.Text);
                pesoproducto = Convert.ToDouble(txtPesoProducto.Text);

                // hacemos un llamado a nuestro metodo de Agregar_producto dentro de nuestra Cl_producto instanciado como productos y mandamos como parametro toda la informacion dentro de nuestros texbox
                productos.Agregar_Producto(codigo, precio_producto, txtNombreProducto.Text, pesoproducto, txtCodigoBarra.Text, txtCodigoCatologo.Text, cantidadproducto, cantidadminima, txtDescripcionProducto.Text, estadoproducto, txtFechaingreso.Text);
                // hacemos conexion a la BD
                SqlConnection con = Cl_conexiones.GetConnection();
                SqlDataAdapter comando = new SqlDataAdapter();
                // consulta a la BD
                string sql = "SELECT * FROM Producto";
                comando.SelectCommand = new SqlCommand(sql, con);

                // actualizamos nuestro datagridview con la informacion agregada
                dtProducto = Cl_Clientes.GetAll();
                dstProducto = new Productosdst();
                dstProducto.Tables.Add(dtProducto);
                // llenamos de nuevo el datagridview
                dgvProducto.DataSource = dstProducto.Tables[0];
                con.Close();
                // mensaje para confirmarle al usuario que el campo se agrego con exito
                MessageBox.Show("Registro agregado con exito", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // funcion para modificar producto
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCatologo.Text == "" || txtDescripcionProducto.Text == "" || txtEstadoPRoducto.Text == "" || txtFechaingreso.Text == "" || txtID_codigoProducto.Text == "" || txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecio_producto.Text == "")
            {
                // mensaje de error al usuario para que los campos no vayan vacios
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // convertimos los valores ya sea para numeros enteros o dobles para que sean del mismo valor a la BD
                codigo = Convert.ToInt32(txtID_codigoProducto.Text);
                cantidadproducto = Convert.ToInt32(txtCantidadProducto.Text);
                cantidadminima = Convert.ToInt32(txtCantidadMinima.Text);
                estadoproducto = Convert.ToInt32(txtEstadoPRoducto.Text);
                precio_producto = Convert.ToDouble(txtPrecio_producto.Text);
                pesoproducto = Convert.ToDouble(txtPesoProducto.Text);
                // hacemos un llamado a nuestro metodo de Modificar_producto dentro de nuestra Cl_producto instanciado como productos y mandamos como parametro toda la informacion dentro de nuestros texbox
                productos.Modificar_Producto(codigo, precio_producto, txtNombreProducto.Text, pesoproducto, txtCodigoBarra.Text, txtCodigoCatologo.Text, cantidadproducto, cantidadminima, txtDescripcionProducto.Text, estadoproducto, txtFechaingreso.Text);
                // hacemos conexion a la BD
                SqlConnection con = Cl_conexiones.GetConnection();
                SqlDataAdapter comando = new SqlDataAdapter();
                // consulta a la BD
                string sql = "SELECT * FROM Producto";
                comando.SelectCommand = new SqlCommand(sql, con);

                // actualizamos nuestro datagridview con la informacion nueva
                dtProducto = Cl_Inventario.GetAll();
                dstProducto = new Productosdst();
                dstProducto.Tables.Add(dtProducto);
                // llenamos de nuevo el datagridview
                dgvProducto.DataSource = dstProducto.Tables[0];
                con.Close();
                // mensaje para confirmarle al usuario que el campo se agrego con exito
                MessageBox.Show("Registro modificado con exito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // funcion para modificar producto
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCatologo.Text == "" || txtDescripcionProducto.Text == "" || txtEstadoPRoducto.Text == "" || txtFechaingreso.Text == "" || txtID_codigoProducto.Text == "" || txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecio_producto.Text == "")
            {
                // mensaje de error al usuario para que los campos no vayan vacios
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ID_codigoProducto;
                // hacemos un for para recorrer cada item dentro de nuestro datagridview
                foreach (DataGridViewRow item in this.dgvProducto.SelectedRows)
                {
                    // le asignamos a esta variable el valor que tiene ese item
                    ID_codigoProducto = item.Cells[0].Value.ToString();
                    // hacemos un llamado a nuestro metodo Eliminar_producto de la clase de Cl_productos con el nombre productos mandandole como parametro el ID_codigoProducto
                    productos.Eliminar_Producto(Convert.ToInt32(ID_codigoProducto));
                }
                // hacemos conexion a la BD
                SqlConnection con = Cl_conexiones.GetConnection();
                SqlDataAdapter comando = new SqlDataAdapter();
                // hacemos la consulta a la BD
                string sql = "SELECT * FROM Producto";
                comando.SelectCommand = new SqlCommand(sql, con);

                // actualizamos nuestro datagridview
                dtProducto = Cl_Inventario.GetAll();
                dstProducto = new Productosdst();
                dstProducto.Tables.Add(dtProducto);
                // llenamos de nuevo el datagridview
                dgvProducto.DataSource = dstProducto.Tables[0];
                con.Close();
            }
        }
    }
}