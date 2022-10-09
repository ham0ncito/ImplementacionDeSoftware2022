using GerizimZZ.Clases;
using iTextSharp.text.xml;

namespace GerizimZZ
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            chbxmotrar.Visible = false;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para recuperar su contraseña, contactese con soporte +50433510129", "Restablecer Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clValidacion validar = new clValidacion();
            validar.validacionTexto(txtUsuario, 5, 45, 3,false);
            validar.validacionTexto(txtContraseña, 5, 45, (int)Math.Round((decimal)(45 / 10)), true);
            try
                {
                    bool entro = false;
                    frmInicio inicio = new frmInicio();
                    Cl_Login login = new Cl_Login();
                    entro = login.iniciarSesion(txtUsuario.Text, txtContraseña.Text);
                    Usuario.username = txtUsuario.Text;
                    if (entro)
                    {
                        this.Hide();
                        inicio.Show();
                        inicio.lblUsernma.Text = txtUsuario.Text;
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message); 
                }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxmotrar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void btSalir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Continuar", "Saliendo del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] numeros = { "+50499499796", "+50433505976", "+50496140758", "+50496671433", "+50494951699", "+50433027713" };
            Random rnd = new Random();
            int llamar = rnd.Next(0, 6);
            MessageBox.Show("Para recuperar su contraseña, contactese con soporte " + numeros[llamar] + "\n En caso de no ser resuelto de inmediato, utilice la cuenta de invitado Usuario: GerizimBarahona Contaseña: Gerizim1234 , para ingresar", "Restablecer Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            try
            {
                chbxmotrar.Visible = true; 
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message); 
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Ingrese el usuario dado por el equipo de soporte en la caja de texto de la parte superior, y su contraseña de 8 carácteres en la siguiente caja de texto \n\t - Equipo de soporte","Tutorial", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(check(txtContraseña.Text) && check(txtUsuario.Text)))
            {
                txtContraseña.Clear();
                txtUsuario.Clear();
            }
            else
            {
                MessageBox.Show("Campos se encuentran vacios", "Campos Vacios", MessageBoxButtons.OK);
            }
        }
        public static bool check(string s)
        {
            return (s == null || s == String.Empty) ? true : false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirmo que he escrito correctamente mi contraseña", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
            {
               
                txtContraseña.AutoCompleteMode = AutoCompleteMode.SuggestAppend; 
                txtContraseña.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                data.Add(txtContraseña.Text);
                txtContraseña.AutoCompleteCustomSource = data;
            }
        }
    }
}