using GerizimZZ.Formularios;

namespace GerizimZZ
{
    public partial class Barra_preview : Form
    {
        public Barra_preview()
        {
            InitializeComponent();
        }

        private void Barra_preview_Load(object sender, EventArgs e)
        {
        }

        private void btnUsua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUsua_Hover(object sender, EventArgs e)
        {
            
        }

        private void btnUsua_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnHisto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en la nueva actualizacion", "Muy Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHisto_Hover(object sender, EventArgs e)
        {
            
        }

        private void btnHisto_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnOpcio_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOpcio_Hover(object sender, EventArgs e)
        {
            
        }

        private void btnOpcio_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnRepor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRepor_Hover(object sender, EventArgs e)
        {
            
        }

        private void btnRepor_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El sistema no tiene actualizaciones pendientes", "Sistema Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Hover(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btnAviso_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAviso_Hover(object sender, EventArgs e)
        {
           
        }

        private void btnAviso_MouseLeave(object sender, EventArgs e)
        {
            
        }

        //click a boton de regresar
        private void btncerrarBP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnavi_Click(object sender, EventArgs e)
        {
            frmAvisos aviso = new frmAvisos();

            aviso.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUsuario nuevoUsuario = new frmUsuario();
            nuevoUsuario.ShowDialog();
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            frmPendientes mostrar = new frmPendientes();
            mostrar.Text = "Gerizim | Actualizaciones";
            mostrar.ShowDialog();   
        }

        private void btnopc_Click(object sender, EventArgs e)
        {
            frmOpciones opciones = new frmOpciones();
            opciones.ShowDialog();
        }
    }
}