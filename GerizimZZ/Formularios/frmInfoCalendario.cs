using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace GerizimZZ.Formularios
{

    public partial class frmInfoCalendario : Form
    {
        // declaracion de variables 
        public SqlDataReader read2;
        public static SqlConnection conn = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");
        public SqlCommand com;
        private bool mouseDown;
        private Point lastLocation;
        String fechahora;
        public String fechaIn { get; set; }
        public String fechaFormato { get; set; }
        String fechasql;

        //llamado en usercontroldays para pasar fecha
        public frmInfoCalendario(String fecha, String fechaform)
        {
            InitializeComponent();
            fechaIn = fecha;
            fechaFormato = fechaform;
        }

        //funcionalidad boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        // funcionalidad de boton para minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // en los siguientes 3 metodos se desarrollan las funciones/metodos de eventos para el movimiento de la ventana
        private void frmInfoCalendario_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmInfoCalendario_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmInfoCalendario_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //llenar el form de infocalendario 
        public void llenar()
        {
            try
            {
                conn.Open();
                fechasql = fechaFormato + " 00:00:00.000";
                int initial = fechaFormato.IndexOf("-");
                int last = fechaFormato.LastIndexOf("-");
                String month = fechaFormato.Substring(initial + 1, last - initial - 1);
                String year = fechaFormato.Substring(0, 4);
                String monthday = fechaFormato.Substring(initial + 1);
                int datsub = monthday.IndexOf("-");
                string day = monthday.Substring(datsub + 1);

                // declaracion de query sql
                String sql = "select p.ID_codigoProducto,p.nombreProducto,p.precio_producto,p.cantidadProducto,pr.ID_proveedores ,pr.nombreProveedores , pr.direccionProveedores " +
                    "from Producto p " +
                    "join ProductoProveedores pp " +
                    "on p.ID_codigoProducto = pp.ID_codigoProducto " +
                    "join Proveedores pr " +
                    "on pr.ID_proveedores = pp.ID_proveedores " +
                    "where (datepart(yy, fechaIngreso) = " + year + " and Datepart(mm, fechaIngreso) = " + month + " and Datepart(dd, fechaIngreso) = " + day + ")";



                com = new SqlCommand(sql, conn);
                com.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime));
                com.Parameters["@fecha"].Value = fechasql;
                com.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                read2 = com.ExecuteReader();
                // obtener las posiciones de los valores a buscar
                var indexprecio = read2.GetOrdinal("precio_producto");
                var indexcodigo = read2.GetOrdinal("ID_codigoProducto");
                var indexnombre = read2.GetOrdinal("nombreProducto");
                var indexcantidad = read2.GetOrdinal("cantidadProducto");
                var indexid = read2.GetOrdinal("ID_proveedores");
                var indexnombreproveedor = read2.GetOrdinal("nombreProveedores");
                var indexdireccion = read2.GetOrdinal("direccionProveedores");


                while (read2.Read())
                {
                    //sacar el valor de las posiciones
                    var prPro = read2.GetValue(indexprecio);
                    var prNombre = read2.GetValue(indexnombre);
                    var prCod = read2.GetValue(indexcodigo);
                    var prCant = read2.GetValue(indexcantidad);
                    var prProveedor = read2.GetValue(indexnombreproveedor);
                    var prIdProv = read2.GetValue(indexid);
                    var prDir = read2.GetValue(indexdireccion);

                    //asignar esos valores a los txtbox
                    txtFrmPrecioProducto.Text = prPro.ToString();
                    txbFrmProducto.Text = prNombre.ToString();
                    txbFrmCodigo.Text = prCod.ToString();
                    txbFrmCantProducto.Text = prCant.ToString();
                    txbFrmProveedor.Text = prProveedor.ToString();
                    txbIdProveedor.Text = prIdProv.ToString();
                    txbFrmDirProveedor.Text = prDir.ToString();
                }


                read2.Dispose();
                com.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmInfoCalendario_Load(object sender, EventArgs e)
        {
            lblfrmfecha.Text = "Ingreso " + fechaIn;
            llenar();
            
        }

        private void txbFrmProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
