using GerizimZZ.Clases;
using GerizimZZ.Formularios;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
namespace GerizimZZ
{
    //detalle venta realiza todas las funciones de venta


    public partial class frmDetalleVenta : Form
    {
        private int x = 0;
        private decimal suma;
        private bool bandera = false;

        private DataGridView dgView;
        ClDetalleVentas detalleVenta = new ClDetalleVentas();




        //inicializa el detallventa, busca nombres de cliente, lee los valores el datagrid
        public frmDetalleVenta()
        {
            InitializeComponent();
            nombresCliente();
            DataGridLector();
            datagrid();
        }
        //activa las funciones del chechbox de delivery
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            datagrid();
            btnNuevaDireccion.Visible = true;
            btnNuevoTelefono.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }
        //TODOS los botones toman un color al momento de hacer hover en ellos y retornan a su valor inicial saliendo
        private void button1_Hover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeaves(object sender, EventArgs e)
        {
            
        }

        private void button2_Hover(object sender, EventArgs e)
        {
           
        }

        private void button2_MouseLeaves(object sender, EventArgs e)
        {
            
        }
        //limpia los datos de la venta
        private void button1_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }
        //este metodo limpia todos los valores que son alterados al momento de realizar una venta. 

        public void Limpiar()
        {
            try
            {
                dgDetalleVenta.Columns.Clear();
                for  (int i = 1; i <= dgDetalleVenta.Rows.Count; i++ )
                {
                    dgDetalleVenta.Rows.Remove(dgDetalleVenta.Rows[i]);
                 }
                dgDetalleVenta.DataSource = null;
                lblTotal.Text = "L 00";
                cmbCliente.Text = "";
                delivery.Checked = false;
                cmbNumero.Items.Clear();
                cmbDireccion.Items.Clear();
                lblCodigoCliente.Text = "";

              
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        //este boton es el que verifica si se realizara una venta, al verificar realiza las funciones de impresion, y modificacion

        private void button2_Click(object sender, EventArgs e)
        {
            datagrid();
            verificacion();
            if (string.IsNullOrEmpty(cmbCliente.Text) == true ||
                string.IsNullOrEmpty(lblNumeroFactura.Text) == true || string.IsNullOrEmpty(cmbPago.Text) == true || lblTotal.Text == "L 00" || dgDetalleVenta.Columns.Count == 0)
            {
                errorProvider1.SetError(groupBox1, "Ingrese todos los campos");
                errorProvider1.SetError(dgDetalleVenta, "Ingrese todos los campos");
            }
            else
            {
                errorProvider1.SetError(groupBox1, "");
                errorProvider1.SetError(dgDetalleVenta, "");
                detalleVenta.ventecita(lblNumeroFactura, lblCodigoCliente, dgDetalleVenta, delivery, cmbDireccion, cmbNumero);
                Imprimir = new PrintDocument();
                try
                {
                    PrinterSettings ps = new PrinterSettings();
                    MessageBox.Show("Factura " + lblNumeroFactura.Text + " en impresion", "Venta realizada");
                    Imprimir.PrinterSettings = ps;
                    
                   
                    Imprimir.PrintPage += printDocument1_PrintPage;
                    Imprimir.DocumentName = String.Concat("Factura#", lblNumeroFactura);
                    Imprimir.Print();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                
                Limpiar();
                Recargar();
            }
        }

        public static DataTable tablita = new DataTable();
        public static List<string> idlist = new List<string>();

        public DataGridView DgView1 { get => dgView; set => dgView = value; }
      
       
        //encapsula el datagrid para poder ser tomado como un objeto
        public void DataGridLector()
        {
            dgView = dgDetalleVenta;
        }
        //llena el datagrid de venta, tomando los valores de los users controls de la pantalla de inicio. 
        public void llenartablita()
        {
            int cont = 0;
            if (tablita.Rows.Count == 0)
            {
                tablita.Columns.Add("Id");
                tablita.Columns.Add("Nombre");
                tablita.Columns.Add("Cantidad");
                tablita.Columns.Add("Precio");
                tablita.Columns.Add("Total");
            }
            string comparacion = textc.Id;
            int cantidadcero = Int16.Parse(textc.Cantidad);

            idlist.Add(comparacion);

            {
                if (tablita.Rows.Count == 0)
                {
                    tablita.Rows.Add(textc.Id, textc.NombreProducto, textc.Cantidad, textc.precio, textc.total);
                }
                else
                {
                    int estado = 0;
                    for (int i = 0; i < tablita.Rows.Count; i++)
                    {
                        if (idlist[i] == textc.Id)
                        {
                            if (cantidadcero == 0)
                            {
                                tablita.Rows.RemoveAt(i);
                                idlist.RemoveAt(i);
                                estado = 1;
                                break;
                            }
                            else
                            {
                                tablita.Rows.RemoveAt(i);
                                tablita.Rows.Add(textc.Id, textc.NombreProducto, textc.Cantidad, textc.precio, textc.total);
                                idlist.RemoveAt(i);
                                estado = 1;
                                break;
                            }
                        }
                        if (idlist[i] != textc.Id)
                        {
                            estado = 2;
                        }
                    }
                    if (estado == 2)
                    {
                        tablita.Rows.Add(textc.Id, textc.NombreProducto, textc.Cantidad, textc.precio, textc.total);
                    }
                }
            }
        }
        //inicializa y recarga los valores de detalle venta. lenta el datagrid con los valores de los users controls
        public void DetalleVenta_Load(object sender, EventArgs e)
        {
            datagrid();
            dgDetalleVenta.DataSource = tablita;
            Recargar();
            cmbCliente.SelectedIndex = 1; 
            cmbPago.SelectedIndex = 0; 
            ClDetalleVentas claseDetalleVenta = new ClDetalleVentas();
            claseDetalleVenta.llenarProductos(dgProductos);

        }
        //reiniza los valores de factura, si hubo una venta tomara el valor maximo y lo sumara
        //esto permite que al momento de hacer la venta, este valor sea el id de toda la venta, posibilitando
        //que se ingresen los valores. 
        public void Recargar()
        {
            detalleVenta.recargito(lblNumeroFactura);
        }

        public void dgDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgDetalleVenta_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
        //accede al formulario de codigobarra , rl cual permite leer los valores
        private void button4_Click(object sender, EventArgs e)
        {
            frCodigoBarra CodigoBarra = new frCodigoBarra();
            AddOwnedForm(CodigoBarra);
            CodigoBarra.Show();
        }
        //Este es el documento que se modifica segun la venta. Es una plantilla que se llena segun los datos la cual 
        //luego se manda a imprimir 
        public void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            Font fuente = new Font("Arial", 12);
            Font Titulo = new Font("Arial", 24, FontStyle.Bold);
            float ubicacion = 460;
            e.Graphics.DrawImage(pictureBox1.Image, 350, 60, 150, 150);
            e.Graphics.DrawString(" Multiservicios Gerizim  ", Titulo, Brushes.Black, new RectangleF(250, 220, 600, 60));
            e.Graphics.DrawString(" Barrio Paz Barahona  1 Calle  2 Avenida  22505876 ", fuente, Brushes.Black, new RectangleF(230, 280, 1000, 100));
            e.Graphics.DrawString(String.Concat("   " + lblFecha.Text + "   " + lblHora.Text), fuente, Brushes.Black, new RectangleF(280, 300, 1000, 100));
            e.Graphics.DrawString(String.Concat("Factura #  " + lblNumeroFactura.Text), fuente, Brushes.Black, new RectangleF(360, 320, 1000, 100));
            e.Graphics.DrawString(String.Concat("Cliente  " + cmbCliente.Text), fuente, Brushes.Black, new RectangleF(200, 380, 1000, 100));
            e.Graphics.DrawString("Listado de productos: ", fuente, Brushes.Black, new RectangleF(200, 420, 1000, 100));
            foreach (DataGridViewRow row in dgDetalleVenta.Rows)
            {
                e.Graphics.DrawString(row.Cells["Nombre"].Value + "      " + row.Cells["Cantidad"].Value + "       "
                    + row.Cells["Precio"].Value + "       " + row.Cells["Total"].Value, fuente, Brushes.Black, new RectangleF(200, ubicacion, 1000, 100));
                ubicacion += 30;
            }
            if (delivery.Checked)
            {
                e.Graphics.DrawString("Su costo de envio es de L100.00 ", fuente, Brushes.Black, new RectangleF(200, ubicacion += 40, 1000, 100));
                e.Graphics.DrawString("Se le llamará al numero " + cmbNumero.Text, fuente, Brushes.Black, new RectangleF(200, ubicacion += 40, 1000, 100));
                e.Graphics.DrawString("Su direccion de envio es : " + cmbDireccion.Text, fuente, Brushes.Black, new RectangleF(200, ubicacion += 40, 1000, 100));
            }
            e.Graphics.DrawString("Su total es de : " + lblTotal.Text, fuente, Brushes.Black, new RectangleF(200, ubicacion += 40, 1000, 100));
            e.Graphics.DrawString("Gracias por confiar en nosotros", fuente, Brushes.Black, new RectangleF(320, ubicacion += 40, 1000, 100));
        }

        private void lblHora_Click(object sender, EventArgs e)
        {
        }
        //timer que modifica la hora de venta
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss:ff");
        }

        private void txtFactura_TextChanged(object sender, EventArgs e)
        {
        }
        //suma los valores del datagrid, esto permite totalizar todos los valores en cada columna
        private void datagrid()
        {
            suma = 0;
            bandera = false;
            foreach (DataGridViewRow row in dgDetalleVenta.Rows)
            {
                suma += Convert.ToDecimal(row.Cells["Total"].Value);
            }
            lblTotal.Text = "L. " + suma.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        //verifica los valores si hay un pedido

        private void verificacion()
        {
            if (delivery.Checked && !string.IsNullOrEmpty(cmbNumero.Text) && !string.IsNullOrEmpty(cmbDireccion.Text) && !bandera)
            {
                bandera = true;
                errorProvider1.SetError(groupBox2, "");
                suma += 100;
            }
            else if (!delivery.Checked && (!string.IsNullOrEmpty(cmbNumero.Text) || !string.IsNullOrEmpty(cmbDireccion.Text)))
            {
                errorProvider1.SetError(groupBox2, "Ingrese todos los valores si hará un pedido");
            }
            else if (delivery.Checked && (string.IsNullOrEmpty(cmbNumero.Text) || string.IsNullOrEmpty(cmbDireccion.Text)))
            {
                errorProvider1.SetError(groupBox2, "Ingrese todos los valores si hará un pedido");
            }
            else
            {
                errorProvider1.SetError(groupBox2, "");
            }
            lblTotal.Text = "L. " + suma.ToString();
        }
        //actualiza los valores del datagrid
        private void button3_Click(object sender, EventArgs e)
        {
            datagrid();
            verificacion();
        }
        //accede al formulario de cliente si sdesea agregar
        private void NuevoCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            AddOwnedForm(frmCliente);
            frmCliente.Show();
        }
        //busca los valores del cliente segun su id. Esto permite que al selleccionar un nuevo nombre
        //los datos del envio sean alterados y se asignen los de ese cleinte
        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDireccion.Items.Clear();
            cmbNumero.Items.Clear();
            buscarId();
            lblCodigoCliente.Visible = true;
            lblCodCliente.Visible = true;
            
            TelefonosDireccions();
        }
        //busca las direcciones del cliente que han sido registradas
        public void direccion()
        {
            detalleVenta.direccion(lblCodigoCliente,cmbDireccion);
        }

        //busca los telefonos que el cliente tiene registrado. 
        public void TelefonosDireccions()
        {
            detalleVenta.telefonosDireccion(lblCodigoCliente, cmbNumero, cmbDireccion);
        }
        //busca el id del cliente segun el seleccionado en el combobox. 
        public void buscarId()
        {
            detalleVenta.buscarId(cmbCliente, lblCodigoCliente, cmbNumero, cmbDireccion);
        }
        //busca todos los nombres de clientes que han sido registrados. 
        public void nombresCliente()
        {
          
            detalleVenta.llenarClientes(cmbCliente);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
        }
        //verifica que el numero del cliente sea valido
        private void btnNuevoTelefono_Click(object sender, EventArgs e)
        {
            vertelefono();
        }
        private void vertelefono()
        {
            string telefono = "";
            if (InputBox.inputBox("Ingrese su numero de telefono de envio ", "Nuevo Telefono de envio", ref telefono) == DialogResult.OK)
            {

                if (Regex.IsMatch(telefono, @"^[0-9]+$")  && telefono.Length == 8 && !string.Equals(lblCodigoCliente.Text, "00") && (string.Equals(telefono.Substring(0,1),"3") || string.Equals(telefono.Substring(0,1), "2") || string.Equals(telefono.Substring(0,1), "8") || string.Equals(telefono.Substring(0,1), "9")))
                {
                    string consulta = "insert into telefonosClientes (ID_cliente, numeroCliente) values (" + lblCodigoCliente.Text + ", '" + Convert.ToString(telefono) + "');";
                    cmbNumero.Items.Add(telefono);
                    detalleVenta.ejecutar(consulta);
                    MessageBox.Show("Valores Ingresados", "Ejecución exitosa");
                }
                else
                {
                    MessageBox.Show("Valores no validos", "Ingrese un telefono valido");
                }
            }
        }
        //por medio de un inputbox, toma los valores ingresados por el cliente, y luego los verifica 

        private void btnNuevaDireccion_Click(object sender, EventArgs e)
        {
            verDireccion(); 
        }
        private void verDireccion()
        {
            string direccion = "";
            
            if (InputBox.inputBox("Ingrese su nueva Direccion de envio ", "Direccion de envio", ref direccion) == DialogResult.OK)
            {
                int contador = 0; 
                for (int i = 1; i < direccion.Length; i ++)
                {
                    if (string.Equals(direccion.Substring(i,1), direccion.Substring((i-1), 1)) && direccion.Length > 1)
                    {
                        contador += 1; 
                    }
                    
                }
                if (direccion.Length > 7 && direccion.Length < 100 && contador < Math.Floor(Convert.ToDecimal(direccion.Length / 2) ) && !string.Equals(lblCodigoCliente.Text,"00"))
                {
                    string consulta = "insert into DireccionesClientes (ID_cliente, direccionCliente) values (" + lblCodigoCliente.Text + ", '" + Convert.ToString(direccion) + "');";
                    cmbDireccion.Items.Add(direccion);
                    detalleVenta.ejecutar(consulta);
                    MessageBox.Show("Valores Ingresados", "Ejecución exitosa");
                }
                else
                {
                    MessageBox.Show("Valores no validos", "Ingrese un telefono valido");
                }

            }

        }
        // al acceder una nueva fila en el datagrid, se actualizan los valores mediante el metodo datagrid. 
        
        private void dgDetalleVenta_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            datagrid(); 
        }

        private void lblNumeroFactura_Click(object sender, EventArgs e)
        {

        }

        private void llenarProductos()
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frmDetalleVentaAyuda desplegar = new frmDetalleVentaAyuda();
            desplegar.ShowDialog();
        }

        private void txtBusquedaCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}