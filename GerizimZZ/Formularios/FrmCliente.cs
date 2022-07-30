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
        private bool si;

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
            // limitamos el tamano maximo del telefono
            txtTelefono.MaxLength = 8;
            // limitamos el tamano maximo del primer nombre
            txtprimerNombre.MaxLength = 15;
            // limitamos el tamano maximo del segundo nombre
            txtsegundoNombre.MaxLength = 15;
            // limitamos el tamano maximo del primer apellido
            txtprimerApellido.MaxLength = 15;
            // limitamos el tamano maximo del segundo apellido
            txtsegundoApellido.MaxLength = 15;
            // limitamos el tamano maximo de la direccion
            txtdireccion.MaxLength = 150;
            // limitamos el tamano maximo del codigo
            txtID_cliente.MaxLength = 6;
        }

        // funcion para eliminar cliente
        private void btneliminar_Cliente_Click(object sender, EventArgs e)
        {
            si = validaciones();
            if (si == true)
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
        }

        // funcion para modificar el cliente
        private void btnmodificar_Cliente_Click(object sender, EventArgs e)
        {
            si = validaciones();
            if (si == true)
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
        }

        // funcion para agregar cliente
        private void btnagregar_Cliente_Click(object sender, EventArgs e)
        {
            si = validaciones();
            if (si == true)
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
                    }
                actualizarDatos();
            }   
        }

        public void actualizarDatos()
        {
            try
            {
                DetalleVenta dr = new DetalleVenta();
                dr.nombresCliente();
            }
            catch (Exception ex)
            {

            }
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

        // funcion para eliminar cliente
        private void bteliminar_Cliente_Click(object sender, EventArgs e)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }            
        }

        private void txtprimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }            
        }

        private bool validaciones()
        {
            Boolean si = false;
            int igual = 0, validado = 0;
            try
            {
                // verificamos que el tamano minimo de cada textbox no sea de un solo caracter
                if (txtprimerNombre.TextLength < 0 && txtsegundoNombre.TextLength < 0 && txtprimerApellido.TextLength < 0 && txtsegundoApellido.TextLength < 0)
                {
                    MessageBox.Show("El tamano minimo para su nombre es de 2 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    validado++;
                }
                if (txtprimerNombre.TextLength < 3)
                {
                    if (txtprimerNombre.Text[0] == txtprimerNombre.Text[1])
                    {
                        MessageBox.Show("Revise su primer nombre, tiene mas de 2 caracteres iguales consecutivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        validado++;
                    }
                }
                if (txtsegundoNombre.TextLength < 3)
                {
                    if (txtsegundoNombre.Text[0] == txtsegundoNombre.Text[1])
                    {
                        MessageBox.Show("Revise su segundo nombre, tiene mas de 2 caracteres iguales consecutivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        validado++;
                    }
                }
                if (txtprimerApellido.TextLength < 3)
                {
                    if (txtprimerApellido.Text[0] == txtprimerApellido.Text[1])
                    {
                        MessageBox.Show("Revise su primer apellido, tiene mas de 2 caracteres iguales consecutivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        validado++;
                    }
                }
                if (txtsegundoApellido.TextLength < 3)
                {
                    if (txtsegundoApellido.Text[0] == txtsegundoApellido.Text[1])
                    {
                        MessageBox.Show("Revise su segundo apellido, tiene mas de 2 caracteres iguales consecutivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        validado++;
                    }
                }
                int num1 = 3, num2 = 8, num3 = 9;
                if(txtTelefono.TextLength > 7)
                {
                    if (txtTelefono.Text[0] == '3')
                    {
                        validado++;
                    }else if(txtTelefono.Text[0] == '8')
                    {
                        validado++;
                    }else if (txtTelefono.Text[0] == '9')
                    {
                        validado++;
                    }
                    else
                    {
                        MessageBox.Show("Solo numeros locales que empiecen con 3, 8 o 9", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    MessageBox.Show("Digite los 8 digitos de su telefono", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }                
                for (int i = 0; i < txtprimerNombre.Text.Length - 1; i++)
                {
                    if (txtprimerNombre.Text[i] == txtprimerNombre.Text[i + 1])
                    {
                        igual++;
                    }
                }
                if (igual > 1)
                {
                    MessageBox.Show("Revise su primer nombre, tiene mas de 2 caracteres iguales consecutivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    igual = 0;
                    validado++;
                }
                for (int i = 0; i < txtsegundoNombre.Text.Length - 1; i++)
                {
                    if (txtsegundoNombre.Text[i] == txtsegundoNombre.Text[i + 1])
                    {
                        igual++;
                    }
                }
                if (igual > 1)
                {
                    MessageBox.Show("Revise su segundo nombre, tiene mas de 2 caracteres iguales consecutivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    igual = 0;
                    validado++;
                }
                for (int i = 0; i < txtprimerApellido.Text.Length - 1; i++)
                {
                    if (txtprimerApellido.Text[i] == txtprimerApellido.Text[i + 1])
                    {
                        igual++;
                    }
                }
                if (igual > 1)
                {
                    MessageBox.Show("Revise su primer apellido, tiene mas de 2 caracteres iguales consecutivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    igual = 0;
                    validado++;
                }
                for (int i = 0; i < txtsegundoApellido.Text.Length - 1; i++)
                {
                    if (txtsegundoApellido.Text[i] == txtsegundoApellido.Text[i + 1])
                    {
                        igual++;
                    }
                }
                if (igual > 1)
                {
                    MessageBox.Show("Revise su segundo apellido, tiene mas de 2 caracteres iguales consecutivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    igual = 0;
                    validado++;
                }
                for (int i = 0; i < txtdireccion.Text.Length - 1; i++)
                {
                    if (txtdireccion.Text[i] == txtdireccion.Text[i + 1])
                    {
                        igual++;
                    }
                }
                if (igual > 1)
                {
                    MessageBox.Show("Revise la direccion, tiene mas de 2 caracteres iguales consecutivos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    igual = 0;
                    validado++;
                }
            }
            catch (Exception ex)
            {

            }
            

            // revisamos si ha cumplido con todas las validaciones
            if (validado >= 7)
            {
                si = true;
                return si;
            }
            else
            {
                return si;
            }
        }

        private void txtsegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtprimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtsegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtID_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtID_cliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}