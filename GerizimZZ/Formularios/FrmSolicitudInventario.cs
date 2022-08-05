using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Markup;
using iTextSharp.text.pdf;
using iTextSharp.text;



namespace GerizimZZ
{
    public partial class FrmSolicitudInventario : Form
    {

        Cl_SolicitarInventario inventario = new Cl_SolicitarInventario();
        Productosdst dstInventario;
        DataTable dtInventario;
<<<<<<< HEAD:GerizimZZ/Formularios/FrmSolicitudInventario.cs
<<<<<<< HEAD:GerizimZZ/Formularios/FrmSolicitudInventario.cs

        //Creación de variables 
=======
       
>>>>>>> parent of e367ade (Cambio nuevo):GerizimZZ/FrmSolicitudInventario.cs
=======
       
>>>>>>> parent of e367ade (Cambio nuevo):GerizimZZ/FrmSolicitudInventario.cs
        int codigo, cantidadproducto, cantidadminima, estadoproducto;
        double PrecioProducto, pesoproducto;

        private void btnSolicitar_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dstInventario.Tables[0].DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "ID_codigoProducto", txtBuscar.Text) + " OR " +
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
            dgvInventario.DataSource = dstInventario.Tables[0].DefaultView;
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFechaIngresoo_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            txtFechaIngresoo.Text = DateTime.Now.ToString("d");
        }
        public void limpiar()
        {
            txtNombreOriginal.Clear();
            txtBuscar.Clear();
            txtCodigoCatalogo.Clear();
            txtCantidadProducto.Clear();
            txtCantidadMinima.Clear();
            txtCodigoBarra.Clear();
            txtEstadoProducto.Clear();
            txtDescripcion.Clear();
            txtPesoProducto.Clear();
            txtPrecioProducto.Clear();

            txtID_CodigoProducto.Clear();
        }

        //Este es el boton que imprime
        private void btnImpresion_Click(object sender, EventArgs e)
        {
            ImprimirSolicitud = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            ImprimirSolicitud.PrinterSettings = ps;
            ImprimirSolicitud.PrintPage += Impresion;
            ImprimirSolicitud.Print();
            printPreviewDialog1.Show();//Esta hace que imprima

        }

        private void Impresion(object sender, PrintPageEventArgs e)
        {


        }

        private void ImprimirSolicitud_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font fuente = new System.Drawing.Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Point);
            ////Graphics.DrawImage(pictureBox1.Image, 350, 60, 150, 150);
            e.Graphics.DrawImage(ImgLogoGerizim.Image, 370, 100, 150, 150); //(Desplazamiento Izquierda/Derecha, Altura en el Doc, Ancho, Alto)
            e.Graphics.DrawString(" Multiservicios Gerizim  ", fuente, Brushes.Green, new RectangleF(330, 240, 600, 60));
            e.Graphics.DrawString(" Barrio Paz Barahona  1 Calle  2 Avenida  22505876 ", fuente, Brushes.Black, new RectangleF(200, 280, 1000, 100));
<<<<<<< HEAD:GerizimZZ/Formularios/FrmSolicitudInventario.cs
<<<<<<< HEAD:GerizimZZ/Formularios/FrmSolicitudInventario.cs
            e.Graphics.DrawString("Solicitud Inventario ", fuente, Brushes.Black, new RectangleF(330, 310, 1000, 100));
            e.Graphics.DrawString("Nombre Original: " + txtNombreOriginal.Text, fuente, Brushes.Black, new RectangleF(190, 350, 1000, 100));
            e.Graphics.DrawString("Cantidad Producto: " + txtCantidadProducto.Text, fuente, Brushes.Black, new RectangleF(190, 380, 1000, 100));
=======
=======
>>>>>>> parent of e367ade (Cambio nuevo):GerizimZZ/FrmSolicitudInventario.cs
            e.Graphics.DrawString("Nombre Original: " + txtNombreOriginal.Text, fuente, Brushes.Black, new RectangleF (190, 350, 1000, 100));
            e.Graphics.DrawString("Cantidad Producto: " + txtCantidadProducto.Text, fuente, Brushes.Black, new RectangleF (190, 380, 1000, 100));
>>>>>>> parent of e367ade (Cambio nuevo):GerizimZZ/FrmSolicitudInventario.cs
            e.Graphics.DrawString("Codigo Barra: " + txtCodigoBarra.Text, fuente, Brushes.Black, new RectangleF(190, 410, 1000, 100));
            e.Graphics.DrawString("Estado Producto: " + txtEstadoProducto.Text, fuente, Brushes.Black, new RectangleF(190, 440, 1000, 100));
            e.Graphics.DrawString("Peso Producto: " + txtPesoProducto.Text, fuente, Brushes.Black, new RectangleF(190, 470, 1000, 100));
            e.Graphics.DrawString("Cantidad Minima: " + txtCantidadMinima.Text, fuente, Brushes.Black, new RectangleF(190, 500, 1000, 100));
            e.Graphics.DrawString("Codigo Producto: " + txtID_CodigoProducto.Text, fuente, Brushes.Black, new RectangleF(190, 530, 1000, 100));
            e.Graphics.DrawString("Codigo Catalogo: " + txtCodigoCatalogo.Text, fuente, Brushes.Black, new RectangleF(190, 560, 1000, 100));
            e.Graphics.DrawString("Precio Producto: " + txtPrecioProducto.Text, fuente, Brushes.Black, new RectangleF(190, 590, 1000, 100));
            e.Graphics.DrawString("Descripcion: " + txtDescripcion.Text, fuente, Brushes.Black, new RectangleF(190, 620, 500, 100));

        }

        public FrmSolicitudInventario()
        {
            InitializeComponent();
        }


        private void FrmSolicitudInventario_Load(object sender, EventArgs e)
        {
            dtInventario = Cl_SolicitarInventario.GetAll();
            dstInventario = new Productosdst();
            dstInventario.Tables.Add(dtInventario);
            dgvInventario.DataSource = dstInventario.Tables[0];
            txtFechaIngresoo.Text = DateTime.Now.ToString("d");


        }

        private void dgvSolicitudInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvInventario.SelectedRows)
            {

                txtID_CodigoProducto.Text = item.Cells[0].Value.ToString();
                txtPrecioProducto.Text = item.Cells[1].Value.ToString();
                txtNombreOriginal.Text = item.Cells[2].Value.ToString();
                txtPesoProducto.Text = item.Cells[3].Value.ToString();
                txtCodigoBarra.Text = item.Cells[4].Value.ToString();
                txtCodigoCatalogo.Text = item.Cells[5].Value.ToString();
                txtCantidadProducto.Text = item.Cells[6].Value.ToString();
                txtCantidadMinima.Text = item.Cells[7].Value.ToString();
                txtDescripcion.Text = item.Cells[8].Value.ToString();
                txtEstadoProducto.Text = item.Cells[9].Value.ToString();
                txtFechaIngresoo.Text = item.Cells[10].Value.ToString();

            }
        }




        //Este es el boton de  Solicitud
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCatalogo.Text == "" || txtDescripcion.Text == "" || txtEstadoProducto.Text == "" || txtFechaIngresoo.Text == "" || txtID_CodigoProducto.Text == "" || txtNombreOriginal.Text == "" || txtPesoProducto.Text == "" || txtPrecioProducto.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //cantidad = Convert.ToInt32(txtCantidadProducto.Text);
                    codigo = Convert.ToInt32(txtID_CodigoProducto.Text);
                    cantidadproducto = Convert.ToInt32(txtCantidadProducto.Text);
                    cantidadminima = Convert.ToInt32(txtCantidadMinima.Text);
                    estadoproducto = Convert.ToInt32(txtEstadoProducto.Text);
                    PrecioProducto = Convert.ToDouble(txtPrecioProducto.Text);
                    pesoproducto = Convert.ToDouble(txtPesoProducto.Text);
                    //Llama a la clase de Solicitar Inventario 

                    inventario.Agregar_Solicitud(codigo, PrecioProducto, txtNombreOriginal.Text, pesoproducto, txtCodigoBarra.Text, txtCodigoCatalogo.Text, cantidadproducto, cantidadminima, txtDescripcion.Text, estadoproducto, Convert.ToDateTime(txtFechaIngresoo.Text));
                    SqlConnection conec = new SqlConnection("Data Source= localhost;Initial Catalog=Gerizim; Integrated Security=True;");
                    SqlDataAdapter coman = new SqlDataAdapter();
                    string sql = "SELECT * FROM Producto";
                    coman.SelectCommand = new SqlCommand(sql, conec);
                    dtInventario = Cl_SolicitarInventario.GetAll();
                    dstInventario = new Productosdst();
                    dstInventario.Tables.Add(dtInventario);
                    dgvInventario.DataSource = dstInventario.Tables[0];
                    conec.Close();
                    MessageBox.Show("Registro modificado con exito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}