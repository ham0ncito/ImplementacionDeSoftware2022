using GerizimZZ.Clases;
using System.Data;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing.Printing;

namespace GerizimZZ
{
    public partial class RegistrosVentas : Form

    {
        //Llamado de las funciones
        public RegistrosVentas()
        {
            InitializeComponent();
            calculosDiarios();
            calculosMensuales();
        }

        private ConexionVentascs cmda = new ConexionVentascs();

        private void label1_Click(object sender, EventArgs e)
        {
        }

        //Para llenar los datos del Datagridview
        private void RegistrosVentas_Load(object sender, EventArgs e)
        {
            cmda.llenargrid(dataGridView1);
        }

        //Aqui se llenan los text box con los datos del DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nventa.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            fechapago.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            idsucursal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            idcajas.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void barraBusqueda_TextChanged_1(object sender, EventArgs e)
        {
        }

        private SqlConnection conectarr = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        //Barra de busqueda
        private void barraBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            conectarr.Open();
            SqlCommand cmda = conectarr.CreateCommand();

            cmda.CommandType = CommandType.Text;
            cmda.CommandText = "SELECT * FROM Factura where ID_cliente like ('" + barraBusqueda.Text + "%')";
            cmda.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmda);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conectarr.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void VFactura_Click(object sender, EventArgs e)
        {
            ImprimirFactura = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            ImprimirFactura.PrinterSettings = ps;
            ImprimirFactura.PrintPage += VFact;
            ImprimirFactura.Print();
            printPreviewDialog2.Show();//Esta hace que imprima
        }

        private void VPedido_Click(object sender, EventArgs e)
        {
            //pantallafactura rc = new pantallafactura();
            //rc.ShowDialog();
        }

        private void VFact(object sender, PrintPageEventArgs e)
        {


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void intsemanal_TextChanged(object sender, EventArgs e)
        {
        }

        //Revisa ventas diarias
        public void calculosDiarios()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source = localhost ; Initial Catalog = Gerizim; Integrated Security = True");
                SqlCommand comando = new SqlCommand("exec totalDiario; ", conexion);
                conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() && !registro.IsDBNull(0))
                {
                    intventasdia.Text = registro[0].ToString();
                }
                else
                {
                    intventasdia.Text = "0";
                }

                conexion.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        //Revisa cuantaas ventas mensuales hay 
        public void calculosMensuales()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source = localhost ; Initial Catalog = Gerizim; Integrated Security = True");
                SqlCommand comando = new SqlCommand("exec totalMensual; ", conexion);
                conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read() && !registro.IsDBNull(0))
                {
                    intmensual.Text = registro[0].ToString();
                }
                else
                {
                    intmensual.Text = "0";
                }

                conexion.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pantallafactura botonpant = new pantallafactura();
            botonpant.ShowDialog();
        }

        //ImprimirFacturaa
        private void ImprimirSolicitud_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Font fuente = new System.Drawing.Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Point);
            // e.Graphics.DrawImage(ImgLogoGerizim.Image, 370, 100, 150, 150);
            e.Graphics.DrawString(" Multiservicios Gerizim  ", fuente, Brushes.Green, new RectangleF(330, 240, 600, 60));
            e.Graphics.DrawString(" Barrio Paz Barahona  1 Calle  2 Avenida  22505876 ", fuente, Brushes.Black, new RectangleF(200, 280, 1000, 100));
            e.Graphics.DrawString("Factura ", fuente, Brushes.Black, new RectangleF(330, 310, 1000, 100));
            e.Graphics.DrawString("Id Venta: " + txtid.Text, fuente, Brushes.Black, new RectangleF(190, 350, 1000, 100));
            e.Graphics.DrawString("Fecha Pago: " + nventa.Text, fuente, Brushes.Black, new RectangleF(190, 380, 1000, 100));
            e.Graphics.DrawString("Detalle: " + indetalle.Text, fuente, Brushes.Black, new RectangleF(190, 350, 1000, 100));
            e.Graphics.DrawString("Id Sucursal: " + idsucursal.Text, fuente, Brushes.Black, new RectangleF(190, 380, 1000, 100));
            e.Graphics.DrawString("Cliente: " + incliente.Text, fuente, Brushes.Black, new RectangleF(190, 350, 1000, 100));
            e.Graphics.DrawString("Sucursal: " + insucursal.Text, fuente, Brushes.Black, new RectangleF(190, 380, 1000, 100));
            e.Graphics.DrawString("Fecha Venta: " + infecha.Text, fuente, Brushes.Black, new RectangleF(190, 350, 1000, 100));
            //e.Graphics.DrawString("Total Venta: " + in.Text, fuente, Brushes.Black, new RectangleF(190, 380, 1000, 100));

        }
    }
}