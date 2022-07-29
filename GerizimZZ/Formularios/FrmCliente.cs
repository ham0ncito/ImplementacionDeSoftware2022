using GerizimZZ.Clases;
using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ
{
    public partial class FrmCliente : Form
    {
        // instanciamos como objeto la clase Cl_Clientes
        private Cl_Clientes clientes = new Cl_Clientes();
        // asignamos nombre para un dataset
        private Clientedst dstCliente;
        // asignamos nombre a un datatable
        private DataTable dtCliente;

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // llenamos el datatable de cliente con la informacion de la tabla de Cliente de la BD con una funcion en la clase Cl_Clientes llamada GetAll
            dtCliente = Cl_Clientes.GetAll();
            // instanciamos el objeto del dataset de cliente 
            dstCliente = new Clientedst();
            // llenamos el dataset de cliente con el datatable lleno de cliente
            dstCliente.Tables.Add(dtCliente);
            // asignamos al datagridview de cliente con el dataset de cliente
            dgvCliente.DataSource = dstCliente.Tables[0];
        }

        // funcion para eliminar cliente
        private void btneliminar_Cliente_Click(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "" || txtID_cliente.Text == "" || txtprimerApellido.Text == "" || txtprimerNombre.Text == "" || txtsegundoApellido.Text == "" || txtsegundoNombre.Text == "" || txtTelefono.Text == "")
            {
                // mensaje de error al usuario para que los campos no vayan vacios
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ID_cliente;
                // for que recorre todos los items del datagridview uno por uno
                foreach (DataGridViewRow item in this.dgvCliente.SelectedRows)
                {
                    // asignamos a nuestra variable de id_cliente el item en el lugar[0] de nuestro datagridview y lo convertimos a tipo string
                    ID_cliente = item.Cells[0].Value.ToString();
                    // hacemos un llamado a nuestro metodo Eliminar_Cliente dentro de nuestra clase de clientes y le mandamos como parametro el ID_cliente
                    clientes.Eliminar_Cliente(ID_cliente);
                }
                // hacemos conexion con nuestra BD
                SqlConnection con = Cl_conexiones.GetConnection();
                // instanciamos nuestro dataadapter
                SqlDataAdapter comando = new SqlDataAdapter();
                // hacemos la consulta a la BD
                string sql = "SELECT * FROM Cliente";
                comando.SelectCommand = new SqlCommand(sql, con);
                // llenamos de nuevo nuestro datatable con nuestro metodo GetAll de nuestra clase Cl_Clientes
                dtCliente = Cl_Clientes.GetAll();
                // instanciamos de nuevo el dataset
                dstCliente = new Clientedst();

                // llenamos de nuevo el dataset con lo que tenemos en nuestro datatable
                dstCliente.Tables.Add(dtCliente);
                // llenamos nuestro datagridview de Cliente con nuestro dataset
                dgvCliente.DataSource = dstCliente.Tables[0];
                con.Close();
            }
        }

        // funcion para modificar el cliente
        private void btnmodificar_Cliente_Click(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "" || txtID_cliente.Text == "" || txtprimerApellido.Text == "" || txtprimerNombre.Text == "" || txtsegundoApellido.Text == "" || txtsegundoNombre.Text == "" || txtTelefono.Text == "")
            {
                // mensaje de error al usuario para que los campos no vayan vacios
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // hacemos un llamado a nuestro metodo de Modificar_Cliente dentro de nuestra Cl_Clientes instanciado como clientes y mandamos como parametro toda la informacion dentro de nuestros texbox
                clientes.Modificar_Cliente(txtID_cliente.Text, txtprimerNombre.Text, txtsegundoNombre.Text, txtprimerApellido.Text, txtsegundoApellido.Text, txtTelefono.Text, txtdireccion.Text);
                // hacemos conexion con nuestra BD
                SqlConnection con = Cl_conexiones.GetConnection();
                SqlDataAdapter comando = new SqlDataAdapter();
                // hacemos la consulta a la BD
                string sql = "SELECT * FROM Cliente";
                comando.SelectCommand = new SqlCommand(sql, con);

                // volvemos a actualizar el datagridview con la nueva informacion que modificamos
                dtCliente = Cl_Clientes.GetAll();
                dstCliente = new Clientedst();
                dstCliente.Tables.Add(dtCliente);
                // llenamos de nuevo el datagridview
                dgvCliente.DataSource = dstCliente.Tables[0];
                con.Close();
            }
            actualizarDatos();
        }

        // funcion para agregar cliente
        private void btnagregar_Cliente_Click(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "" || txtID_cliente.Text == "" || txtprimerApellido.Text == "" || txtprimerNombre.Text == "" || txtsegundoApellido.Text == "" || txtsegundoNombre.Text == "" || txtTelefono.Text == "")
            {
                // mensaje de error al usuario para que los campos no vayan vacios
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // hacemos un llamado a nuestro metodo de Agregar_Cliente dentro de nuestra Cl_Clientes instanciado como clientes y mandamos como parametro toda la informacion dentro de nuestros texbox
                clientes.Agregar_Cliente(txtID_cliente.Text, txtprimerNombre.Text, txtsegundoNombre.Text, txtprimerApellido.Text, txtsegundoApellido.Text, txtTelefono.Text, txtdireccion.Text);
                SqlConnection con = Cl_conexiones.GetConnection();
                SqlDataAdapter comando = new SqlDataAdapter();
                // hacemos la consulta a la BD
                string sql = "SELECT * FROM Cliente";
                comando.SelectCommand = new SqlCommand(sql, con);

                // volvemos a actualizar el datagridview con la nueva informacion que modificamos
                dtCliente = Cl_Clientes.GetAll();
                dstCliente = new Clientedst();
                dstCliente.Tables.Add(dtCliente);
                // llenamos de nuevo el datagridview
                dgvCliente.DataSource = dstCliente.Tables[0];
                con.Close();
                // mensaje para confirmarle al usuario que el campo se agrego con exito
                MessageBox.Show("Registro agregado con exito", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            actualizarDatos();
        }

        public void actualizarDatos()
        {
            DetalleVenta dr = Owner as DetalleVenta;
            dr.nombresCliente();
        }

        private void dgvCliente_Click(object sender, EventArgs e)
        {
            // hacemos un for que recorra todo los items del datagridview para asignarle a los textboxs los valores del datagridview segun el click del usuario
            foreach (DataGridViewRow item in this.dgvCliente.SelectedRows)
            {
                txtID_cliente.Text = item.Cells[0].Value.ToString();
                txtprimerNombre.Text = item.Cells[1].Value.ToString();
                txtsegundoNombre.Text = item.Cells[2].Value.ToString();
                txtprimerApellido.Text = item.Cells[3].Value.ToString();
                txtsegundoApellido.Text = item.Cells[4].Value.ToString();
                txtTelefono.Text = item.Cells[5].Value.ToString();
                txtdireccion.Text = item.Cells[6].Value.ToString();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // hacemos un filtrado por fila del datagridview para poder buscar un elemento deseado por el usuario
            dstCliente.Tables[0].DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "ID_cliente", txtBuscar.Text) + " OR " +
                string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "primerNombre", txtBuscar.Text) + " OR " +
                string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "segundoNombre", txtBuscar.Text) + " OR " +
                string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "primerApellido", txtBuscar.Text) + " OR " +
                string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "SegundoApellido", txtBuscar.Text) + " OR " +
                string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "telefono", txtBuscar.Text) + " OR " +
                string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "direccion", txtBuscar.Text);
            dgvCliente.DataSource = dstCliente.Tables[0].DefaultView;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblID_cliente_Click(object sender, EventArgs e)
        {
        }

        private void lblsegundoNombre_Click(object sender, EventArgs e)
        {
        }

        private void lbldireccion_Click(object sender, EventArgs e)
        {
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtsegundoNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtprimerNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtID_cliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbltelefono_Click(object sender, EventArgs e)
        {
        }

        private void lblprimerApellido_Click(object sender, EventArgs e)
        {
        }

        private void lblsegundoApellido_Click(object sender, EventArgs e)
        {
        }

        private void txtsegundoApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtprimerApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblprimerNombre_Click(object sender, EventArgs e)
        {
        }
    }
}