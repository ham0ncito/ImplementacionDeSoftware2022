using GerizimZZ.Clases;
using GerizimZZ.Datasets;
using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ
{
    public partial class FrmInventario : Form
    {
        private Producto producto = new Producto();
        // instanciamos la clase de inventario con el nombre productos
        private Cl_Inventario productos = new Cl_Inventario();
        // creamos una variable de nuestro dataset
        private Productosdst dstProducto;
        // creamos una variable de nuestro datatable
        private DataTable dtProducto;
        private int codigo, cantidadproducto, cantidadminima, estadoproducto;
        private double precio_producto, pesoproducto;
        private bool si;

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
            // limitamos el tamano maximo del codigo
            txtID_codigoProducto.MaxLength = 4;
            // limitamos el tamano maximo del precio
            txtPrecio_producto.MaxLength = 4;
            // limitamos el tamano maximo del peso
            txtPesoProducto.MaxLength = 3;
            // limitamos el tamano maximo de la cantidad
            txtCantidadProducto.MaxLength = producto.Stockactual;
            // llenamos el combobox con un dato de la lista
            cbcodigo_Catalogo.Text = "1";
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
                cbcodigo_Catalogo.Text = item.Cells[5].Value.ToString();
                txtCantidadProducto.Text = item.Cells[6].Value.ToString();
                txtCantidadMinima.Text = item.Cells[7].Value.ToString();
                txtDescripcionProducto.Text = item.Cells[8].Value.ToString();
                txtEstadoPRoducto.Text = item.Cells[9].Value.ToString();
                dateTimePicker1.Text = item.Cells[10].Value.ToString();
            }
        }

        private void txtID_codigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecio_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPesoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255) || e.KeyChar == 46)
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidadMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEstadoPRoducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 48 || e.KeyChar == 49 || e.KeyChar == 08))
            {
            }
            else
            {
                MessageBox.Show("Solo números (0 o 1)", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDescripcionProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
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
            si = validaciones();
            if (si == true)
            {
                if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || cbcodigo_Catalogo.Text == "" || txtDescripcionProducto.Text == "" || txtEstadoPRoducto.Text == "" || dateTimePicker1.Text == "" || txtID_codigoProducto.Text == "" || txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecio_producto.Text == "")
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
                    productos.Agregar_Producto(codigo, precio_producto, txtNombreProducto.Text, pesoproducto, txtCodigoBarra.Text, cbcodigo_Catalogo.Text, cantidadproducto, cantidadminima, txtDescripcionProducto.Text, estadoproducto, dateTimePicker1.Text);
                    // hacemos conexion a la BD
                    SqlConnection con = Cl_conexiones.GetConnection();
                    SqlDataAdapter comando = new SqlDataAdapter();
                    // consulta a la BD
                    string sql = "SELECT * FROM Producto";
                    comando.SelectCommand = new SqlCommand(sql, con);

                    // actualizamos nuestro datagridview con la informacion agregada
                    dtProducto = Cl_Inventario.GetAll();
                    dstProducto = new Productosdst();
                    dstProducto.Tables.Add(dtProducto);
                    // llenamos de nuevo el datagridview
                    dgvProducto.DataSource = dstProducto.Tables[0];
                    con.Close();
                }
            }    
        }

        // funcion para modificar producto
        private void btnModificar_Click(object sender, EventArgs e)
        {
            si = validaciones();
            if (si == true)
            {
                if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || cbcodigo_Catalogo.Text == "" || txtDescripcionProducto.Text == "" || txtEstadoPRoducto.Text == "" || dateTimePicker1.Text == "" || txtID_codigoProducto.Text == "" || txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecio_producto.Text == "")
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
                    productos.Modificar_Producto(codigo, precio_producto, txtNombreProducto.Text, pesoproducto, txtCodigoBarra.Text, cbcodigo_Catalogo.Text, cantidadproducto, cantidadminima, txtDescripcionProducto.Text, estadoproducto, dateTimePicker1.Text);
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
                }
            }    
        }

        // funcion para modificar producto
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            si = validaciones();
            if (si == true)
            {

                if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || cbcodigo_Catalogo.Text == "" || txtDescripcionProducto.Text == "" || txtEstadoPRoducto.Text == "" || dateTimePicker1.Text == "" || txtID_codigoProducto.Text == "" || txtNombreProducto.Text == "" || txtPesoProducto.Text == "" || txtPrecio_producto.Text == "")
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

        private bool validaciones()
        {
            Boolean si = false;
            int igual = 0, validado = 0;
            if(txtNombreProducto.TextLength < 3)
            {
                MessageBox.Show("El tamano minimo para el nombre es de 4 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                }
            else
            {
                validado++;
            }
            for (int i = 0; i < txtNombreProducto.Text.Length - 1; i++)
            {
                if (txtNombreProducto.Text[i] == txtNombreProducto.Text[i + 1])
                {
                    igual++;
                }
            }
            if (igual > 1)
            {
                MessageBox.Show("Revise el nombre de producto, tiene mas de 2 caracteres iguales consecutivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                igual = 0;
            }
            else
            {
                igual = 0;
                validado++;
            }
            if (txtCodigoBarra.TextLength < 5)
            {
                MessageBox.Show("El tamano minimo para el codigo de barra es de 7 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                igual = 0;
            }
            else
            {
                validado++;
            }
            for (int i = 0; i < txtCodigoBarra.Text.Length - 1; i++)
            {
                if (txtCodigoBarra.Text[i] == txtCodigoBarra.Text[i + 1])
                {
                    igual++;
                }
            }
            if (igual > 1)
            {
                MessageBox.Show("Revise el codigo de barra, tiene mas de 2 caracteres iguales consecutivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                igual = 0;
            }
            else
            {
                igual = 0;
                validado++;
            }
            if (txtDescripcionProducto.TextLength < 5)
            {
                MessageBox.Show("El tamano minimo para la descripcion del producto es de 7 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                igual = 0;
            }
            else
            {
                validado++;
            }
            for (int i = 0; i < txtDescripcionProducto.Text.Length - 1; i++)
            {
                if (txtDescripcionProducto.Text[i] == txtDescripcionProducto.Text[i + 1])
                {
                    igual++;
                }
            }
            if (igual > 1)
            {
                MessageBox.Show("Revise la descripcion del producto, tiene mas de 2 caracteres iguales consecutivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                igual = 0;
            }
            else
            {
                igual = 0;
                validado++;
            }

            // revisamos si ha cumplido con todas las validaciones
            if (validado == 6)
            {
                si = true;
                return si;
            }
            else
            {
                return si;
            }
        }
    }
}