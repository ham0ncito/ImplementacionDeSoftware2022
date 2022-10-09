using GerizimZZ.Clases;
using System.Data;
using System.Data.SqlClient;
using GerizimZZ.Datasets;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GerizimZZ
{
    public partial class RegistrosVentas : Form

    {
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

        private void RegistrosVentas_Load(object sender, EventArgs e)
        {
            cmda.llenargrid(dataGridView1);
            dataGridView1.Columns[0].HeaderText = "Id Venta";
            dataGridView1.Columns[1].HeaderText = "Nº Venta";
            dataGridView1.Columns[2].HeaderText = "Fecha Pago";
            dataGridView1.Columns[3].HeaderText = "Fecha Vencimiento";
            dataGridView1.Columns[4].HeaderText = "Estado de pago";
            dataGridView1.Columns[5].HeaderText = "Ïd Cliente";
            dataGridView1.Columns[6].HeaderText = "Id Sucursal";
            dataGridView1.Columns[7].HeaderText = "Id Cajas";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            txtFechap.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtIdCliente.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtidsucursal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtidcajas.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void barraBusqueda_TextChanged_1(object sender, EventArgs e)
        {
        }

        private SqlConnection conectarr = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

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
            //Imprimir datos de la tabla seleccionados
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "PDF (*.pdf)|*.pdf";
                guardar.FileName = "Datos Factura.pdf";
                bool errormessage = false;
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(guardar.FileName))
                    {
                        try
                        {
                            File.Delete(guardar.FileName);
                        }
                        catch (Exception ex)
                        {
                            errormessage = true;
                            MessageBox.Show(ex.Message);
                        }
                    }
                    if (!errormessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 4;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridView1.Columns)
                            {
                                PdfPCell pcell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pcell);
                            }
                            foreach (DataGridViewRow viewrow in dataGridView1.Rows)
                            {
                                if (viewrow.Selected == true)
                                {
                                    foreach (DataGridViewCell dcell in viewrow.Cells)
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(guardar.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4.Rotate(), 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Informacion guardara correctamente", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay informacion en la tabla(datagrid)", "Info");
            }
        }
       
    



        private void VPedido_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void intsemanal_TextChanged(object sender, EventArgs e)
        {
        }

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}