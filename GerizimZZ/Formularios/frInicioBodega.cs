using System.Runtime.InteropServices;

namespace GerizimZZ
{
    public partial class frInicioBodega : Form
    {
        public frInicioBodega()
        {
            InitializeComponent();
            
        }

        public void Llenado()
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }


        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

       
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

      
        private void panel_titlebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Barra_preview barra_Preview = new Barra_preview();
            barra_Preview.ShowDialog();
        }

        private void button2_Hover(object sender, EventArgs e)
        {
         
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        // click a boton de minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // click a boton de maximizar
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //click a boton de cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Continuar?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_Click(object sender, EventArgs e)
        {
           
        }

        

        private void btnregresarMI_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btninventariomi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en la nueva actualizacion", "Muy Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btninventarioomi_Hover(object sender, EventArgs e)
        {
        }

        private void btninventarioomi_MouseLeaves(object sender, EventArgs e)
        {
           
        }

        private void btnclientesmi_Hover(object sender, EventArgs e)
        {
          
        }

        private void btnclientesmi_MouseLeaves(object sender, EventArgs e)
        {
            
        }

        private void btnpedidosmi_Hover(object sender, EventArgs e)
        {
            
        }

        private void btnpedidosmi_MouseLeaves(object sender, EventArgs e)
        {
            
        }

        private void btnventasmi_Hover(object sender, EventArgs e)
        {
            
        }

        private void btnventasmi_MouseLeaves(object sender, EventArgs e)
        {
            
        }

        private void btn(object sender, MouseEventArgs e)
        {
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void BarraBusqueda_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio fr = new Inicio();
            fr.Show();
            this.Close();
        }

        private void button3_Hover(object sender, EventArgs e)
        {
            
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        //Boton para abrir form de pedido
        private void btnpedidosmi_Click(object sender, EventArgs e)
        {
            frmPantallaPedido frmPantallaPedido = new frmPantallaPedido();
            frmPantallaPedido.ShowDialog();
        }

        private void btnventasmi_Click(object sender, EventArgs e)
        {
            RegistrosVentas bs = new RegistrosVentas();
            bs.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en la nueva actualizacion", "Muy Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnclientesmi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en la nueva actualizacion", "Muy Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en nuevas actualizaciones", "Proximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmSolicitudInventario frmSolicitudInventario = new FrmSolicitudInventario();
            frmSolicitudInventario.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Abrir Pantalla repartidores
            FrmRepartidores repartidores = new FrmRepartidores();
            repartidores.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en nuevas actualizaciones", "Proximamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}