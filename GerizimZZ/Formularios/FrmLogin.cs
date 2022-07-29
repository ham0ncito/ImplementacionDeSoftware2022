using GerizimZZ.Clases;

namespace GerizimZZ
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            // ocultamos nuestro checkbox de mostrar la contraseña
            chbxmotrar.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // usamos un sistema de ocultacion para la contraseña
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {
            // mandamos un mensaje de recuperacion de contraseña cuando de click al label
            MessageBox.Show("Para recuperar su contraseña, contactese con soporte +50433510129", "Restablecer Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // verificamos que los campos no esten vacios
            if (string.IsNullOrEmpty(txtContraseña.Text) && string.IsNullOrEmpty(txtUsuario.Text))
            {
                // mandamos un mensaje de que ingrese datos a los campos
                errorProvider1.SetError(groupBox1, "Ingrese todos los datos para continuar"); 
            }
            else
            {
                errorProvider1.SetError(groupBox1, "");
                try
                {
                    // boleano para saber si entro o no al sistema
                    bool entro = false;
                    Inicio inicio = new Inicio();
                    Cl_Login login = new Cl_Login();
                    //aqui verificamos si logro entrar al sistema con los datos proporcionados por el usuario
                    entro = login.iniciarSesion(txtUsuario.Text, txtContraseña.Text);
                    // le asignamos el texto proporcionado por el usuario a nuestra variable username en la clase de usuario
                    Usuario.username = txtUsuario.Text;
                    if (entro)
                    {
                        // si entro al sistema ocultamos el formulario de login
                        this.Hide();
                        // mostramos el formulario de inicio
                        inicio.Show();
                        // asignamos el usuario a nuestro label de usuario en la clase de inicio
                        inicio.lblUsernma.Text = txtUsuario.Text;
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message); 
                }
            }
        }

        // funcion para verificar si el usuario desea ver los datos ingresados en el campo de contraseña
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxmotrar.Checked)
            {
                // hacemos que la contraseña no tenga formato de contraseña oculta
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                // hacemos que la contraseña tenga formato de contraseña oculta
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btSalir_Click_1(object sender, EventArgs e)
        {
            // mensaje para confirmar que desea salir del sistema
            if (MessageBox.Show("Desea Continuar", "Saliendo del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // no salimos del sistema
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // string con diferentes numeros para mostrar cuando el usuario olvido la contraseña
            string[] numeros = { "+50499499796", "+50433505976", "+50496140758", "+50496671433", "+50494951699", "+50433027713" };
            Random rnd = new Random();
            // hacemos uso de la funcion random para mostrar diferentes numeros al usuario cuando olvide su contraseña
            int llamar = rnd.Next(0, 6);
            // mensaje para recuperar contraseña para el usuario
            MessageBox.Show("Para recuperar su contraseña, contactese con soporte " + numeros[llamar], "Restablecer Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // hace que el checkbox se muestre
                chbxmotrar.Visible = true; 
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message); 
            }
        }
    }
}