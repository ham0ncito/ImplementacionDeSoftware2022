namespace GerizimZZ
{
    public partial class frmOpciones : Form
    {
        public frmOpciones()
        {
            InitializeComponent();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Espere futuras actualizaciones", "Esta en Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}