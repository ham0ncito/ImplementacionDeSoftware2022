using GerizimZZ.Clases;
using GerizimZZ.Formularios;

namespace GerizimZZ
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            label1.Text = "Bienvenido " + Usuario.username.ToString();
        }

        private void frmUsuario_Load()
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPendientes mostrar = new frmPendientes();
            mostrar.Text = "Gerizim | Usuarios | Ayuda";
            mostrar.ShowDialog();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea continuar?", "Continuar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string contraseña = "";
                string contra;
                int cambio;
                if (InputBox.inputBox("Cambio de Contraseña", "Ingrese su nueva contraseña", ref contraseña) == DialogResult.OK)
                {
                    contra = contraseña;

                    string consulta = "use Gerizim; Update Usuarios set contraseñaUsuario = '" + contraseña + "' where nombreUsuario = '" + Usuario.username + "';";
                    Usuario.Conexion(consulta);
                }
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void cambiarCorreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea continuar?", "Continuar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string correo = "";
                string con;
                int cambio;
                if (InputBox.inputBox("Cambio de Correo", "Ingrese su nuevo correo", ref correo) == DialogResult.OK)
                {
                    con = correo;

                    string consulta = "use Gerizim; Update Usuarios set EmailUsuario = '" + con + "' where nombreUsuario = '" + Usuario.username + "';";
                    Usuario.Conexion(consulta);
                }
            }
        }

        private void cambiarFotoDePerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPendientes mostrar = new frmPendientes();
            mostrar.Text = "Gerizim | Cambiar mi foto de Perfil";
            mostrar.ShowDialog();
        }

        private void configuracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPendientes mostrar = new frmPendientes();
            mostrar.Text = "Gerizim | Configuraciones";
            mostrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPendientes mostrar = new frmPendientes();
            mostrar.Text = "Gerizim | Cerrar Sesion";
            mostrar.ShowDialog();
        }
    }
}