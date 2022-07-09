﻿using IronBarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerizimZZ
{
    public partial class frCodigoBarra : Form
    {
        SqlCommand cmd;
        bool existe = false; 
        SqlConnection connection = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");
        public frCodigoBarra()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|*.png" })

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {


                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    BarcodeResult codigoLeido = BarcodeReader.QuicklyReadOneBarcode(pictureBox1.Image, BarcodeEncoding.QRCode | BarcodeEncoding.Code128, true);

                    if (codigoLeido != null)
                    {
                        textBox1.Text = codigoLeido.ToString();
                    }
                }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean productoEnElCarrito = false;
            int pos = 0;
            int[] cantidad = new int[2]; 

            if ((string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true))
            {
                errorProvider1.SetError(groupBox1, "Ingrese todos los datos");
            }
            else if (existe == true && string.IsNullOrEmpty(textBox1.Text) == false && string.IsNullOrEmpty(textBox2.Text) == false) 
            {
                errorProvider1.SetError(groupBox1, "");
                SqlCommand consulta = new SqlCommand("Select ID_codigoProducto, precio_producto, nombreProducto, cantidadProducto, estadoPRoducto from Producto where codigoBarra = '" + textBox1.Text + "';",connection);
                connection.Open();
                //consulta.Parameters.AddWithValue("codigoBarra", textBox2.Text);
                SqlDataReader registro = consulta.ExecuteReader();
                if (registro.Read())
                {
                    cantidad[1] = Convert.ToInt32(registro[3]);
                    if (Convert.ToInt32(registro[4]) != 0 && Convert.ToInt32(textBox2.Text) <= Convert.ToInt32(registro[3]))
                    {

                       
                        DetalleVenta dv = Owner as DetalleVenta;
                        DataTable dt = new DataTable();
                       
                        for (int i = 0; i < dv.dgDetalleVenta.Rows.Count; i++)
                        {
                          
                            if (Convert.ToInt32(dv.dgDetalleVenta.Rows[i].Cells[0].Value) == Convert.ToInt32(registro["ID_codigoProducto"]))
                            {
                                productoEnElCarrito = true; 
                                pos = i;
                                cantidad[0] = Convert.ToInt32(dv.dgDetalleVenta.Rows[i].Cells[2].Value);
                            }
                        }
                        dt = dv.dgDetalleVenta.DataSource as DataTable;
                        DataRow datarow;
                        datarow = dt.NewRow();
                        if (productoEnElCarrito == false)
                        {
                            
                            datarow["Id"] = registro[0].ToString();
                            datarow["Nombre"] = registro[2].ToString();
                            datarow["Cantidad"] = textBox2.Text;
               
                            datarow["Precio"] = registro[1].ToString();
                            datarow["Total"] = (Convert.ToInt32(textBox2.Text) * Convert.ToInt32(registro[1])).ToString();
                            dt.Rows.Add(datarow);
                        }
                        else
                        {
                            if(MessageBox.Show("Ese producto ya se encuentra agregado en el carrito ¿Desea Agregar mas cantidad?", "Producto en el carrito", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                            {
                                if((Convert.ToInt32(dv.dgDetalleVenta.Rows[pos].Cells[2].Value) + Convert.ToInt32(textBox2.Text)) <= cantidad[1])
                                {
                                    dv.dgDetalleVenta.Rows[pos].Cells[2].Value = Convert.ToInt32(dv.dgDetalleVenta.Rows[pos].Cells[2].Value) + Convert.ToInt32(textBox2.Text); 
                                }
                                else
                                {
                                    MessageBox.Show("El Inventario es insuficiente");
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Algo Salio Mal. No pudimos procesar su solicitud"); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Algo Salio Mal. Lo sentimos");
            }
            connection.Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql; 
            
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    sql = "Select imagen from Producto where codigoBarra = '" + textBox1.Text+ "'";
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        cmd = new SqlCommand(sql, connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        
                        if (reader.HasRows)
                        {
                            existe = true;
                            byte[] imag = (byte[])(reader[0]);
                            if (imag == null)
                            {
                                pictureBox1.Image = GerizimZZ.Properties.Resources.Imagen1_PhotoRoom__1_; ;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(imag);
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                            
                        }
                        else
                        {
                            connection.Close();
                            MessageBox.Show("No existe el producto");
                            pictureBox1.Image = GerizimZZ.Properties.Resources.losentimos;
                        }
                    }
                }
                catch (Exception ee)
                {
                    Image imagen = GerizimZZ.Properties.Resources.Imagen1_PhotoRoom__1_;
                    pictureBox1.Image = imagen;
                    
                }
                
            }
            connection.Close();
        }
    }
}
