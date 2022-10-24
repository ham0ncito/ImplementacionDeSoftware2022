using GerizimZZ.Clases;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace GerizimZZ
{
    public partial class FrmCliente : Form
    {
        private Cl_Clientes clientes = new Cl_Clientes();
        private Clientedst dstCliente;
        private DataTable dtCliente;

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Gerizimdst.Cliente' table. You can move, or remove it, as needed.
            dtCliente = Cl_Clientes.GetAll();
            dstCliente = new Clientedst();
            dstCliente.Tables.Add(dtCliente);
            dgvCliente.DataSource = dstCliente.Tables[0];

            dgvCliente.Columns[0].HeaderText = "ID Cliente";
            dgvCliente.Columns[1].HeaderText = "Primer nombre";
            dgvCliente.Columns[2].HeaderText = "Segundo nombre";
            dgvCliente.Columns[3].HeaderText = "Primer apellido";
            dgvCliente.Columns[4].HeaderText = "Segundo apellido";
            dgvCliente.Columns[5].HeaderText = "Direccion";
            dgvCliente.Columns[6].HeaderText = "Telefono";

            txtBuscar.Focus();
        }

        private void btneliminar_Cliente_Click(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "" || txtID_cliente.Text == "" || txtprimerApellido.Text == "" || txtprimerNombre.Text == "" || txtsegundoApellido.Text == "" || txtsegundoNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ID_cliente;
                foreach (DataGridViewRow item in this.dgvCliente.SelectedRows)
                {
                    ID_cliente = item.Cells[0].Value.ToString();
                    clientes.Eliminar_Cliente(ID_cliente);
                }
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
                SqlDataAdapter comando = new SqlDataAdapter();
                string sql = "SELECT * FROM Cliente";
                comando.SelectCommand = new SqlCommand(sql, con);
                dtCliente = Cl_Clientes.GetAll();
                dstCliente = new Clientedst();
                dstCliente.Tables.Add(dtCliente);
                dgvCliente.DataSource = dstCliente.Tables[0];
                con.Close();
            }
        }

        private void btnmodificar_Cliente_Click(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "" || txtID_cliente.Text == "" || txtprimerApellido.Text == "" || txtprimerNombre.Text == "" || txtsegundoApellido.Text == "" || txtsegundoNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clientes.Modificar_Cliente(txtID_cliente.Text, txtprimerNombre.Text, txtsegundoNombre.Text, txtprimerApellido.Text, txtsegundoApellido.Text, txtTelefono.Text, txtdireccion.Text);
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
                SqlDataAdapter comando = new SqlDataAdapter();
                string sql = "SELECT * FROM Cliente";
                comando.SelectCommand = new SqlCommand(sql, con);
                dtCliente = Cl_Clientes.GetAll();
                dstCliente = new Clientedst();
                dstCliente.Tables.Add(dtCliente);
                dgvCliente.DataSource = dstCliente.Tables[0];
                con.Close();
            }
            actualizarDatos();
        }

        private void btnagregar_Cliente_Click(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "" || txtID_cliente.Text == "" || txtprimerApellido.Text == "" || txtprimerNombre.Text == "" || txtsegundoApellido.Text == "" || txtsegundoNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clientes.Agregar_Cliente(txtID_cliente.Text, txtprimerNombre.Text, txtsegundoNombre.Text, txtprimerApellido.Text, txtsegundoApellido.Text, txtTelefono.Text, txtdireccion.Text);
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
                SqlDataAdapter comando = new SqlDataAdapter();
                string sql = "SELECT * FROM Cliente";
                comando.SelectCommand = new SqlCommand(sql, con);
                dtCliente = Cl_Clientes.GetAll();
                dstCliente = new Clientedst();
                dstCliente.Tables.Add(dtCliente);
                dgvCliente.DataSource = dstCliente.Tables[0];
                con.Close();
                MessageBox.Show("Registro modificado con exito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            actualizarDatos();
        }

        public void actualizarDatos()
        {
            frmDetalleVenta dr = Owner as frmDetalleVenta;
            dr.nombresCliente();
        }

        private void dgvCliente_Click(object sender, EventArgs e)
        {
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

        private void txtID_cliente_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtID_cliente.Text,@"^(\d\d\d{0,1}|1000)$"))
            {
                txtID_cliente.Focus();
                MessageBox.Show("El valor ingresado debe ser un numero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtTelefono_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string telefono = txtTelefono.Text;
            if (Regex.IsMatch(telefono, @"^[0-9]+$") && telefono.Length == 8 && !string.Equals(txtTelefono.Text, "00") && (string.Equals(telefono.Substring(0, 1), "3") || string.Equals(telefono.Substring(0, 1), "2") || string.Equals(telefono.Substring(0, 1), "8") || string.Equals(telefono.Substring(0, 1), "9")))
            {
            }
            else
            {
                MessageBox.Show("Ingrese un numero de telefono valido", "Valores no validos");
            }
        }
    }
}