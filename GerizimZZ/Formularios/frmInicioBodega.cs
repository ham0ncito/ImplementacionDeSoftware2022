using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerizimZZ.Formularios
{
    public partial class frInicioBodega : Form
    {
        public frInicioBodega()
        {
            InitializeComponent();
        }

        private void frInicioBodega_Load(object sender, EventArgs e)
        {
            
        }

        private void btninventariomi_Click(object sender, EventArgs e)
        {
            FrmSolicitudInventario inventario = new FrmSolicitudInventario();
            AddOwnedForm(inventario);
            inventario.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmRepartidores frRepartidores = new FrmRepartidores();
            AddOwnedForm(frRepartidores);
            frRepartidores.Show();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            frmPendientes mostrar = new frmPendientes();
            mostrar.Text = "Gerizim | Enviar";
            mostrar.ShowDialog();
        }

        private void btnmaterias_Click(object sender, EventArgs e)
        {
            frmPendientes mostrar = new frmPendientes();
            mostrar.Text = "Gerizim | Materias Primas";
            mostrar.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea continuar?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Salida del sistema de bodega cancelada");
            }
        }

        private void Calendario_Click(object sender, EventArgs e)
        {
            frmCalendario fcal = new frmCalendario();
            fcal.Show();
        }
    }
}
